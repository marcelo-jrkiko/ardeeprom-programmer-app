using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArdEepromProgrammer
{
    public partial class Main : Form
    {
        private int currentProgress;
        private decimal memoryTotal;

        public ProgrammerComm MySP { get; private set; }

        public Main()
        {
            InitializeComponent();
            tmUpdate_Tick(null, null);

            this.LoadSettings();
        }

        private void LoadSettings()
        {
            AppConfig.Load();
            cbSerialPort_DropDown(null, null);
            this.cbSerialPort.SelectedItem = AppConfig.Default.Port;
            this.nmPages.Value = AppConfig.Default.Pages;
            this.nmPageSize.Value = AppConfig.Default.PageSize;
        }

        private void SaveSettings()
        {
            if (cbSerialPort.SelectedItem == null)
                return;

            AppConfig.Default.Port = (string)cbSerialPort.SelectedItem;
            AppConfig.Default.Pages = (int)nmPages.Value;
            AppConfig.Default.PageSize = (int)nmPageSize.Value;
            AppConfig.Save();
        }

        private void cbSerialPort_DropDown(object sender, EventArgs e)
        {
            this.cbSerialPort.Items.Clear();
            this.cbSerialPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.SaveSettings();

            string selectedPort = (string)this.cbSerialPort.SelectedItem;

            if(string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Invalid Selected Serial Port or None Selected!");
                return;
            }

            if (this.nmPageSize.Value <= 0)
            {
                MessageBox.Show("Invalid Page Size!");
            }

            if (this.nmPages.Value <= 0)
            {
                MessageBox.Show("Invalid Number of Pages!");
            }

            this.UpdateTotalSize();
            this.MySP = new ProgrammerComm(selectedPort, 
                (int)this.nmPageSize.Value,
                (int)this.nmPages.Value);

            MySP.Open();
            tmUpdate.Enabled = true;

            this.btnSetSetts_Click(null, null);
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            if(this.MySP != null && this.MySP.IsOpen)
            {
                this.btnConnect.Enabled = false;
                this.btnClose.Enabled = true;
                this.btnDump.Enabled = true;
                this.btnRefresh.Enabled = true;
                this.btnSetSetts.Enabled = true;
                this.btnVerify.Enabled = true;
            
            }
            else
            {
                this.btnConnect.Enabled = true;
                this.btnSetSetts.Enabled = false;
                this.btnClose.Enabled = false;
                this.btnDump.Enabled = false;
                this.btnRefresh.Enabled = false;
                this.btnVerify.Enabled = false;
            }


            this.dumpProgress.Value = (int)currentProgress;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.tmUpdate.Enabled = false;
            this.MySP.Close();
            tmUpdate_Tick(null, null);
        }

        private void nmPageSize_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateTotalSize();
        }

        private void UpdateTotalSize()
        {
            this.memoryTotal = (this.nmPageSize.Value * this.nmPages.Value);
            this.lbTotalSize.Text = (memoryTotal / 1024) + "K";
        }

        private void nmPages_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateTotalSize();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.UpdateTotalSize();
            this.UpdateTitle("- Seeking for the device id ...");
            this.Enabled = false;

            var tsk = new Thread(() => {
                string myValue = this.MySP.GetDeviceId();
                this.Invoke(new Action(() => {
                    this.txtDeviceId.Text = myValue;
                    this.UpdateTitle();
                    this.Enabled = true;
                }));
            });

            tsk.Start();
        }

        private void UpdateTitle(string v = "")
        {
            this.Text = "ArdEEPROM Programmer " + v;               
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveSettings();
        }

        private void btnDumpSlcFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "bin";
            saveFileDialog.Filter = "BIN BIOS (*.bin)|*.*";
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtOutFile.Text= saveFileDialog.FileName;
            }
        }

        private void btnDump_Click(object sender, EventArgs e)
        {
            this.UpdateTotalSize();
            this.UpdateTitle("- Dumping the memory...");
            this.Enabled = false;

            var tsk = new Thread(() => {
                using (FileStream fs = File.Open(this.txtOutFile.Text, FileMode.Create))
                {
                    MySP.DumpMemory(ProgrammerDumpMode.RAW, fs, (p) =>
                    {
                        this.currentProgress = p;
                    });
                }
                

                this.Invoke(new Action(() => {
                    this.UpdateTitle();
                    this.currentProgress = 0;
                    this.Enabled = true;
                }));
            });

            tsk.Start();
        }

        private void btnSetSetts_Click(object sender, EventArgs e)
        {
            this.UpdateTotalSize();
            this.UpdateTitle("- Send device settings ..");
            this.Enabled = false;

            var tsk = new Thread(() => {
                String cfg = this.MySP.SetDeviceSettings();

                this.Invoke(new Action(() => {
                    this.UpdateTitle();
                    this.Enabled = true;
                }));
            });

            tsk.Start();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnVerifySelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BIN BIOS (*.bin)|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtVerifyFile.Text = openFileDialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UpdateTotalSize();
            this.UpdateTitle("- Verifing the memory...");
            this.Enabled = false;

            bool onlyChecksum = chkOnlyChecksum.Checked;

            var tsk = new Thread(() => {
                ProgrammerVerifyResult results;

                using (FileStream fs = File.Open(this.txtVerifyFile.Text, FileMode.Open))
                {
                    results = MySP.VerifyMemory(fs, (p) =>
                    {
                        this.currentProgress = p;
                    }, onlyChecksum);
                }


                this.Invoke(new Action(() => {
                    this.UpdateTitle();
                    this.currentProgress = 0;
                    this.Enabled = true;
                    this.UpdateVerifyResults(results);
                }));
            });

            tsk.Start();
        }

        private void UpdateVerifyResults(ProgrammerVerifyResult results)
        {
            this.txtVerifyResults.Text =
                "Result: " + (results.IsOkay ? " Contents are the same! " : "Memory contents are not the same") +
                "\r\nEEPROM CHECKSUM: " + results.EEPROM_HASH +
                "\r\nCOMPARED CHECKSUM: " + results.COMPARE_HASH;
        }
    }
}
