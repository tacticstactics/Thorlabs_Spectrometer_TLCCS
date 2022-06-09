using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using Thorlabs.CCS_Series;



namespace CCS_CSharpDemo
{
    public partial class Form1_CCS : Form
    {

        private TLCCS ccsSeries;

        public Form1_CCS()
        {
            InitializeComponent();

            button_StartScan.Enabled = false;
            button_StartScanCont.Enabled = false;
            button_Release.Enabled = false;
            button_GetScanData.Enabled = false;
            button_SaveAsText.Enabled = false;

        }

        private void button_Init_Click(object sender, EventArgs e)
        {

            if (textBox_SerialNumber.Text.Length == 0)
            {
                MessageBox.Show("Please insert the 8 numerics of the serial number");
                return;
            }

            // set the busy cursor
            this.Cursor = Cursors.WaitCursor;

            // connect the ccs device and start the sample c application. Read out the instrument resource name from the sample application
            // the instrument number 0x8081 is used for the CCS100 device. If you have another CCS instrument please change the number.
            // 0x8081: CCS100
            // 0x8083: CCS125
            // 0x8085: CCS150
            // 0x8087: CCS175
            // 0x8089: CCS200
            // 0x80A0: LC-100
            string instrumentNumber = "0x8087";
            string resourceName = "USB0::0x1313::" + instrumentNumber + "::M" + textBox_SerialNumber.Text.ToString() + "::RAW";

            // initialize device with the resource name (be sure the device is still connected)
            ccsSeries = new TLCCS(resourceName, false, false);

            int status;
            int res = ccsSeries.getDeviceStatus(out status);

            // set the integration time
            res = ccsSeries.setIntegrationTime((double)numericUpDown_IntegrationTime.Value);

            // reset the cursor
            this.Cursor = Cursors.Default;

            res = ccsSeries.getDeviceStatus(out status);

            textBox_deviceStatus.Text = status.ToString();
            //MessageBox.Show(status.ToString(), "status", MessageBoxButtons.OK, MessageBoxIcon.None);


            button_Init.Enabled = false;
            button_Release.Enabled = true;
            button_StartScan.Enabled = true;
            button_StartScanCont.Enabled = true;
            button_GetScanData.Enabled = false;
            button_SaveAsText.Enabled = false;

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button_Release_Click(object sender, EventArgs e)
        {

            // release the device
            if (ccsSeries != null)
                ccsSeries.Dispose();

            button_Init.Enabled = true;
            button_Release.Enabled = false;
            button_StartScan.Enabled = false;
            button_StartScanCont.Enabled = false;
            button_GetScanData.Enabled = false;
            button_SaveAsText.Enabled = false;

        }



        private void button_StartScan_Click(object sender, EventArgs e)
        {
            int status;
            int res;

            // has the device started?
            //res = ccsSeries.getDeviceStatus(out status);
            //textBox_deviceStatus.Text = status.ToString();
            //MessageBox.Show(status.ToString(), "status", MessageBoxButtons.OK, MessageBoxIcon.None);

            // start the scan
            res = ccsSeries.startScan();

            if (res == 0)
            {
                // color the button green
                //button_StartScan.BackColor = System.Drawing.Color.LightGreen;
                button_StartScan.Enabled = true;
            }

            res = ccsSeries.getDeviceStatus(out status);
            textBox_deviceStatus.Text = status.ToString();

            //MessageBox.Show(status.ToString(), "status", MessageBoxButtons.OK, MessageBoxIcon.None);


            // camera has spectrumdata available for transfer
            if ((status & 0x0010) > 0)
            {

                //MessageBox.Show("status is > 0x00010. There should be data.", "status", MessageBoxButtons.OK, MessageBoxIcon.None);


                double[] spectrumdata = new double[3648];
                res = ccsSeries.getScanData(spectrumdata);


                for (int i = 0; i < spectrumdata.Length; i++)
                {
                    textBox1.Text = "pixel number," + i.ToString() + ", data " + Convert.ToString(spectrumdata[i]) + "\r\n";
                }

                res = ccsSeries.getDeviceStatus(out status);
                textBox_deviceStatus.Text = status.ToString();

            }

            else
            {
                //MessageBox.Show("status is not > 0x00010. There is no data", "status", MessageBoxButtons.OK, MessageBoxIcon.None);

                res = ccsSeries.getDeviceStatus(out status);
                textBox_deviceStatus.Text = status.ToString();
                button_GetScanData.Enabled = true;

            }

        }

        private void button_StartScanCont_Click(object sender, EventArgs e)
        {
            int status;

            int res = ccsSeries.getDeviceStatus(out status);

            // start the scanCont
            res = ccsSeries.startScanCont();


            if (res == 0)
            {
                // color the button green
                //button_StartScan.BackColor = System.Drawing.Color.LightGreen;
                button_StartScan.Enabled = false;
            }

            res = ccsSeries.getDeviceStatus(out status);
            textBox_deviceStatus.Text = status.ToString();

        }

        private void button_GetDeviceStatus_Click(object sender, EventArgs e)
        {

            int status;

            ccsSeries.getDeviceStatus(out status);
            textBox_deviceStatus.Text = status.ToString();

            button_StartScan.Enabled = true;
            button_StartScanCont.Enabled = true;
            button_GetScanData.Enabled = true;


        }

        private void button_GetScanData_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            double[] spectrumdata = new double[3648];
            int res = ccsSeries.getScanData(spectrumdata);


            for (int i = 0; i < spectrumdata.Length; i++)
  
            {
                textBox1.AppendText(i.ToString() + ", " + Convert.ToString(spectrumdata[i]) + "\r\n");

                //                textBox1.Text = "pixel number," + i.ToString() + ", data " + Convert.ToString(spectrumdata[i]) + "\r\n";
                //                textBox1.AppendText("\r\n");

            }

            button_StartScan.Enabled = true;
            button_StartScanCont.Enabled = true;
            button_SaveAsText.Enabled = true;
        }

        private void button_SaveAsText_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                label_filename.Text = saveFileDialog1.FileName;

                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(fs, Encoding.GetEncoding("shift_jis"));

                sw.Write(textBox1.Text);

                sw.Close();
                fs.Close();

            }
        }
    }
}