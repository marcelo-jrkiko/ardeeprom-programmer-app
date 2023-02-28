
namespace ArdEepromProgrammer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtVerifyResults = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnVerifySelFile = new System.Windows.Forms.Button();
            this.txtVerifyFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDump = new System.Windows.Forms.Button();
            this.btnDumpSlcFile = new System.Windows.Forms.Button();
            this.txtOutFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSetSetts = new System.Windows.Forms.Button();
            this.lbTotalSize = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmPages = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nmPageSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbControls = new System.Windows.Forms.TabControl();
            this.dumpProgress = new System.Windows.Forms.ProgressBar();
            this.chkOnlyChecksum = new System.Windows.Forms.CheckBox();
            this.tabPage5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPageSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.tbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmUpdate
            // 
            this.tmUpdate.Interval = 500;
            this.tmUpdate.Tick += new System.EventHandler(this.tmUpdate_Tick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel3);
            this.tabPage5.Controls.Add(this.btnVerifySelFile);
            this.tabPage5.Controls.Add(this.txtVerifyFile);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(437, 168);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Verify";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.chkOnlyChecksum);
            this.panel3.Controls.Add(this.txtVerifyResults);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnVerify);
            this.panel3.Location = new System.Drawing.Point(10, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 99);
            this.panel3.TabIndex = 7;
            // 
            // txtVerifyResults
            // 
            this.txtVerifyResults.Location = new System.Drawing.Point(7, 34);
            this.txtVerifyResults.Multiline = true;
            this.txtVerifyResults.Name = "txtVerifyResults";
            this.txtVerifyResults.ReadOnly = true;
            this.txtVerifyResults.Size = new System.Drawing.Size(405, 62);
            this.txtVerifyResults.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(4, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Results:";
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(339, 5);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "VERIFY";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerifySelFile
            // 
            this.btnVerifySelFile.Location = new System.Drawing.Point(347, 35);
            this.btnVerifySelFile.Name = "btnVerifySelFile";
            this.btnVerifySelFile.Size = new System.Drawing.Size(75, 23);
            this.btnVerifySelFile.TabIndex = 3;
            this.btnVerifySelFile.Text = "...";
            this.btnVerifySelFile.UseVisualStyleBackColor = true;
            this.btnVerifySelFile.Click += new System.EventHandler(this.btnVerifySelFile_Click);
            // 
            // txtVerifyFile
            // 
            this.txtVerifyFile.Location = new System.Drawing.Point(13, 37);
            this.txtVerifyFile.Name = "txtVerifyFile";
            this.txtVerifyFile.Size = new System.Drawing.Size(328, 20);
            this.txtVerifyFile.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "File:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Compares the File to the EEPROM";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(437, 168);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Program";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btnDumpSlcFile);
            this.tabPage2.Controls.Add(this.txtOutFile);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(437, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dump";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.btnDump);
            this.panel2.Location = new System.Drawing.Point(10, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 33);
            this.panel2.TabIndex = 7;
            // 
            // btnDump
            // 
            this.btnDump.Enabled = false;
            this.btnDump.Location = new System.Drawing.Point(339, 5);
            this.btnDump.Name = "btnDump";
            this.btnDump.Size = new System.Drawing.Size(75, 23);
            this.btnDump.TabIndex = 2;
            this.btnDump.Text = "DUMP";
            this.btnDump.UseVisualStyleBackColor = true;
            this.btnDump.Click += new System.EventHandler(this.btnDump_Click);
            // 
            // btnDumpSlcFile
            // 
            this.btnDumpSlcFile.Location = new System.Drawing.Point(347, 35);
            this.btnDumpSlcFile.Name = "btnDumpSlcFile";
            this.btnDumpSlcFile.Size = new System.Drawing.Size(75, 23);
            this.btnDumpSlcFile.TabIndex = 3;
            this.btnDumpSlcFile.Text = "...";
            this.btnDumpSlcFile.UseVisualStyleBackColor = true;
            this.btnDumpSlcFile.Click += new System.EventHandler(this.btnDumpSlcFile_Click);
            // 
            // txtOutFile
            // 
            this.txtOutFile.Location = new System.Drawing.Point(13, 37);
            this.txtOutFile.Name = "txtOutFile";
            this.txtOutFile.Size = new System.Drawing.Size(328, 20);
            this.txtOutFile.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dumps the content of the EEPROM to a File";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSetSetts);
            this.tabPage1.Controls.Add(this.lbTotalSize);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nmPages);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nmPageSize);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.cbSerialPort);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(437, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chip ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSetSetts
            // 
            this.btnSetSetts.Enabled = false;
            this.btnSetSetts.Location = new System.Drawing.Point(351, 61);
            this.btnSetSetts.Name = "btnSetSetts";
            this.btnSetSetts.Size = new System.Drawing.Size(75, 23);
            this.btnSetSetts.TabIndex = 3;
            this.btnSetSetts.Text = "Set Settings";
            this.btnSetSetts.UseVisualStyleBackColor = true;
            this.btnSetSetts.Click += new System.EventHandler(this.btnSetSetts_Click);
            // 
            // lbTotalSize
            // 
            this.lbTotalSize.AutoSize = true;
            this.lbTotalSize.Location = new System.Drawing.Point(196, 71);
            this.lbTotalSize.Name = "lbTotalSize";
            this.lbTotalSize.Size = new System.Drawing.Size(32, 13);
            this.lbTotalSize.TabIndex = 12;
            this.lbTotalSize.Text = "000K";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Size:";
            // 
            // nmPages
            // 
            this.nmPages.Location = new System.Drawing.Point(102, 71);
            this.nmPages.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmPages.Name = "nmPages";
            this.nmPages.Size = new System.Drawing.Size(84, 20);
            this.nmPages.TabIndex = 10;
            this.nmPages.ValueChanged += new System.EventHandler(this.nmPages_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pages";
            // 
            // nmPageSize
            // 
            this.nmPageSize.Location = new System.Drawing.Point(12, 71);
            this.nmPageSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmPageSize.Name = "nmPageSize";
            this.nmPageSize.Size = new System.Drawing.Size(84, 20);
            this.nmPageSize.TabIndex = 8;
            this.nmPageSize.ValueChanged += new System.EventHandler(this.nmPageSize_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Page-Size";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.txtDeviceId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 55);
            this.panel1.TabIndex = 6;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(339, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(7, 20);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.ReadOnly = true;
            this.txtDeviceId.Size = new System.Drawing.Size(100, 20);
            this.txtDeviceId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Device ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(355, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(274, 23);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Open";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(12, 24);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(162, 21);
            this.cbSerialPort.TabIndex = 1;
            this.cbSerialPort.DropDown += new System.EventHandler(this.cbSerialPort_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // tbControls
            // 
            this.tbControls.Controls.Add(this.tabPage1);
            this.tbControls.Controls.Add(this.tabPage2);
            this.tbControls.Controls.Add(this.tabPage3);
            this.tbControls.Controls.Add(this.tabPage5);
            this.tbControls.Location = new System.Drawing.Point(12, 12);
            this.tbControls.Name = "tbControls";
            this.tbControls.SelectedIndex = 0;
            this.tbControls.Size = new System.Drawing.Size(445, 194);
            this.tbControls.TabIndex = 0;
            // 
            // dumpProgress
            // 
            this.dumpProgress.Location = new System.Drawing.Point(16, 208);
            this.dumpProgress.Name = "dumpProgress";
            this.dumpProgress.Size = new System.Drawing.Size(437, 18);
            this.dumpProgress.TabIndex = 4;
            // 
            // chkOnlyChecksum
            // 
            this.chkOnlyChecksum.AutoSize = true;
            this.chkOnlyChecksum.Checked = true;
            this.chkOnlyChecksum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyChecksum.Location = new System.Drawing.Point(225, 9);
            this.chkOnlyChecksum.Name = "chkOnlyChecksum";
            this.chkOnlyChecksum.Size = new System.Drawing.Size(106, 17);
            this.chkOnlyChecksum.TabIndex = 7;
            this.chkOnlyChecksum.Text = "Only Checksum?";
            this.chkOnlyChecksum.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 233);
            this.Controls.Add(this.dumpProgress);
            this.Controls.Add(this.tbControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ArdEeprom Programmer ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPageSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmUpdate;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtVerifyResults;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnVerifySelFile;
        private System.Windows.Forms.TextBox txtVerifyFile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Button btnDumpSlcFile;
        private System.Windows.Forms.TextBox txtOutFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSetSetts;
        private System.Windows.Forms.Label lbTotalSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmPageSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbControls;
        private System.Windows.Forms.ProgressBar dumpProgress;
        private System.Windows.Forms.CheckBox chkOnlyChecksum;
    }
}

