using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USBFeeder
{
    public partial class Form1 : Form
    {
        byte[] USBdata = new byte[] {100};

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();


           
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write(USBdata, 0, 1 );
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            label1.Text = serialPort1.ReadByte().ToString();

        }

        
    }
}
