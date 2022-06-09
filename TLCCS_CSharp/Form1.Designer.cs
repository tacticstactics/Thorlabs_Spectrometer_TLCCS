namespace CCS_CSharpDemo
{
    partial class Form1_CCS
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SerialNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_IntegrationTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_StartScan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_StartScanCont = new System.Windows.Forms.Button();
            this.button_Init = new System.Windows.Forms.Button();
            this.button_Release = new System.Windows.Forms.Button();
            this.textBox_deviceStatus = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_GetDeviceStatus = new System.Windows.Forms.Button();
            this.button_GetScanData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IntegrationTime)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_SerialNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instrument Informations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "::RAW\'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opening Session to \'USB0::0x1313::0x8081::M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start the application \"sample.exe\" and read out the 8 numerics serial number (wit" +
    "h leading zeros)";
            // 
            // textBox_SerialNumber
            // 
            this.textBox_SerialNumber.Location = new System.Drawing.Point(241, 30);
            this.textBox_SerialNumber.Name = "textBox_SerialNumber";
            this.textBox_SerialNumber.Size = new System.Drawing.Size(100, 19);
            this.textBox_SerialNumber.TabIndex = 1;
            this.textBox_SerialNumber.Text = "00403814";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Integration Time";
            // 
            // numericUpDown_IntegrationTime
            // 
            this.numericUpDown_IntegrationTime.DecimalPlaces = 1;
            this.numericUpDown_IntegrationTime.Location = new System.Drawing.Point(95, 18);
            this.numericUpDown_IntegrationTime.Name = "numericUpDown_IntegrationTime";
            this.numericUpDown_IntegrationTime.Size = new System.Drawing.Size(100, 19);
            this.numericUpDown_IntegrationTime.TabIndex = 3;
            this.numericUpDown_IntegrationTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numericUpDown_IntegrationTime);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 46);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instrumenmt Settings";
            // 
            // button_StartScan
            // 
            this.button_StartScan.Location = new System.Drawing.Point(198, 129);
            this.button_StartScan.Name = "button_StartScan";
            this.button_StartScan.Size = new System.Drawing.Size(142, 21);
            this.button_StartScan.TabIndex = 5;
            this.button_StartScan.Text = "Start Scan";
            this.button_StartScan.UseVisualStyleBackColor = true;
            this.button_StartScan.Click += new System.EventHandler(this.button_StartScan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 65);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 267);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 69);
            this.textBox1.TabIndex = 7;
            // 
            // button_StartScanCont
            // 
            this.button_StartScanCont.Location = new System.Drawing.Point(372, 129);
            this.button_StartScanCont.Name = "button_StartScanCont";
            this.button_StartScanCont.Size = new System.Drawing.Size(126, 23);
            this.button_StartScanCont.TabIndex = 8;
            this.button_StartScanCont.Text = "StartScanCont";
            this.button_StartScanCont.UseVisualStyleBackColor = true;
            this.button_StartScanCont.Click += new System.EventHandler(this.button_StartScanCont_Click);
            // 
            // button_Init
            // 
            this.button_Init.Location = new System.Drawing.Point(12, 127);
            this.button_Init.Name = "button_Init";
            this.button_Init.Size = new System.Drawing.Size(75, 23);
            this.button_Init.TabIndex = 9;
            this.button_Init.Text = "Init";
            this.button_Init.UseVisualStyleBackColor = true;
            this.button_Init.Click += new System.EventHandler(this.button_Init_Click);
            // 
            // button_Release
            // 
            this.button_Release.Location = new System.Drawing.Point(107, 129);
            this.button_Release.Name = "button_Release";
            this.button_Release.Size = new System.Drawing.Size(75, 23);
            this.button_Release.TabIndex = 10;
            this.button_Release.Text = "Release";
            this.button_Release.UseVisualStyleBackColor = true;
            this.button_Release.Click += new System.EventHandler(this.button_Release_Click);
            // 
            // textBox_deviceStatus
            // 
            this.textBox_deviceStatus.Location = new System.Drawing.Point(94, 12);
            this.textBox_deviceStatus.Name = "textBox_deviceStatus";
            this.textBox_deviceStatus.Size = new System.Drawing.Size(70, 19);
            this.textBox_deviceStatus.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_GetDeviceStatus);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_deviceStatus);
            this.groupBox3.Location = new System.Drawing.Point(242, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 45);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "devceStatus";
            // 
            // button_GetDeviceStatus
            // 
            this.button_GetDeviceStatus.Location = new System.Drawing.Point(171, 12);
            this.button_GetDeviceStatus.Name = "button_GetDeviceStatus";
            this.button_GetDeviceStatus.Size = new System.Drawing.Size(100, 23);
            this.button_GetDeviceStatus.TabIndex = 13;
            this.button_GetDeviceStatus.Text = "GetDeviceStatus";
            this.button_GetDeviceStatus.UseVisualStyleBackColor = true;
            this.button_GetDeviceStatus.Click += new System.EventHandler(this.button_GetDeviceStatus_Click);
            // 
            // button_GetScanData
            // 
            this.button_GetScanData.Location = new System.Drawing.Point(20, 238);
            this.button_GetScanData.Name = "button_GetScanData";
            this.button_GetScanData.Size = new System.Drawing.Size(101, 23);
            this.button_GetScanData.TabIndex = 13;
            this.button_GetScanData.Text = "GetScanData";
            this.button_GetScanData.UseVisualStyleBackColor = true;
            this.button_GetScanData.Click += new System.EventHandler(this.button_GetScanData_Click);
            // 
            // Form1_CCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 348);
            this.Controls.Add(this.button_GetScanData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Release);
            this.Controls.Add(this.button_Init);
            this.Controls.Add(this.button_StartScanCont);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_StartScan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1_CCS";
            this.Text = "CSS CSharpDemo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IntegrationTime)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_SerialNumber;
        private System.Windows.Forms.NumericUpDown numericUpDown_IntegrationTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_StartScan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_StartScanCont;
        private System.Windows.Forms.Button button_Init;
        private System.Windows.Forms.Button button_Release;
        private System.Windows.Forms.TextBox textBox_deviceStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_GetDeviceStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_GetScanData;
    }
}

