using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public ProgrammerComm MySP { get; private set; }

        public Main()
        {
            InitializeComponent();
            tmUpdate_Tick(null, null);
        }

        private void cbSerialPort_DropDown(object sender, EventArgs e)
        {
            this.cbSerialPort.Items.Clear();
            this.cbSerialPort.Items.AddRange(SerialPort.GetPortNames());
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = (string)this.cbSerialPort.SelectedItem;

            if(string.IsNullOrEmpty(selectedPort))
            {
                MessageBox.Show("Invalid Selected Serial Port or None Selected!");
                return;
            }

            if(this.nmBaudRate.Value <= 0)
            {
                MessageBox.Show("Invalid Baud-Rate!");
            }

            if (this.nmPageSize.Value <= 0)
            {
                MessageBox.Show("Invalid Page Size!");
            }

            if (this.nmPages.Value <= 0)
            {
                MessageBox.Show("Invalid Number of Pages!");
            }


            this.MySP = new ProgrammerComm(selectedPort, 
                (int)this.nmBaudRate.Value,
                (int)this.nmPageSize.Value,
                (int)this.nmPages.Value);

            MySP.Open();
            tmUpdate.Enabled = true;
        }

        private void tmUpdate_Tick(object sender, EventArgs e)
        {
            if(this.MySP != null && this.MySP.IsOpen)
            {
                this.btnConnect.Enabled = false;
                this.btnClose.Enabled = true;
                this.btnDump.Enabled = true;
                this.btnRefresh.Enabled = true;
            }
            else
            {
                this.btnConnect.Enabled = true;
                this.btnClose.Enabled = false;
                this.btnDump.Enabled = false;
                this.btnRefresh.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.tmUpdate.Enabled = false;
            this.MySP.Close();
        }

        private void nmPageSize_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateTotalSize();
        }

        private void UpdateTotalSize()
        {
            decimal value = (this.nmPageSize.Value * this.nmPages.Value) / 1024;
            this.lbTotalSize.Text = value + "K";
        }

        private void nmPages_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateTotalSize();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
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
    }
}
