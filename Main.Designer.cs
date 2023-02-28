
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
            this.tbControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.nmBaudRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDumpSlcFile = new System.Windows.Forms.Button();
            this.txtOutFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmPageSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmPages = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalSize = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDump = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dumpProgress = new System.Windows.Forms.ProgressBar();
            this.tmUpdate = new System.Windows.Forms.Timer(this.components);
            this.tbControls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBaudRate)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPages)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControls
            // 
            this.tbControls.Controls.Add(this.tabPage1);
            this.tbControls.Controls.Add(this.tabPage2);
            this.tbControls.Location = new System.Drawing.Point(12, 12);
            this.tbControls.Name = "tbControls";
            this.tbControls.SelectedIndex = 0;
            this.tbControls.Size = new System.Drawing.Size(445, 194);
            this.tbControls.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbTotalSize);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nmPages);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nmPageSize);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btnClose);
            this.tabPage1.Controls.Add(this.btnConnect);
            this.tabPage1.Controls.Add(this.nmBaudRate);
            this.tabPage1.Controls.Add(this.label2);
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
            // nmBaudRate
            // 
            this.nmBaudRate.Location = new System.Drawing.Point(184, 24);
            this.nmBaudRate.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmBaudRate.Name = "nmBaudRate";
            this.nmBaudRate.Size = new System.Drawing.Size(84, 20);
            this.nmBaudRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud-Rate:";
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
            // btnDumpSlcFile
            // 
            this.btnDumpSlcFile.Location = new System.Drawing.Point(347, 35);
            this.btnDumpSlcFile.Name = "btnDumpSlcFile";
            this.btnDumpSlcFile.Size = new System.Drawing.Size(75, 23);
            this.btnDumpSlcFile.TabIndex = 3;
            this.btnDumpSlcFile.Text = "...";
            this.btnDumpSlcFile.UseVisualStyleBackColor = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Size:";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.dumpProgress);
            this.panel2.Controls.Add(this.btnDump);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(10, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 55);
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
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Progress:";
            // 
            // dumpProgress
            // 
            this.dumpProgress.Location = new System.Drawing.Point(7, 21);
            this.dumpProgress.Name = "dumpProgress";
            this.dumpProgress.Size = new System.Drawing.Size(324, 23);
            this.dumpProgress.TabIndex = 3;
            // 
            // tmUpdate
            // 
            this.tmUpdate.Interval = 500;
            this.tmUpdate.Tick += new System.EventHandler(this.tmUpdate_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 210);
            this.Controls.Add(this.tbControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ArdEeprom Programmer ";
            this.tbControls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmBaudRate)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPages)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControls;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.NumericUpDown nmBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDumpSlcFile;
        private System.Windows.Forms.TextBox txtOutFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmPageSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar dumpProgress;
        private System.Windows.Forms.Button btnDump;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer tmUpdate;
    }
}

