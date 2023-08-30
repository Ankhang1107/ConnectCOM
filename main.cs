using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String a;
        String b;
        public Form1()
        {
            InitializeComponent();
            btConnect.Enabled = true;
            btDisconnect.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cbCom.Text;
            serialPort1.BaudRate = Convert.ToInt32(cbBaud.Text);
            serialPort1.Open();
            sttConnect.Text = "Connected";
            btConnect.Enabled = false;
            btDisconnect.Enabled = true;
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            sttConnect.Text = "Disonnected";
            btConnect.Enabled = true;
            btDisconnect.Enabled = false;
        }

        private void sttMessage_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            tbSend.Text = "";
            a = serialPort1.ReadLine();
            tbData.Text = a;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            b = tbSend.Text;
            serialPort1.WriteLine(b);

        }
    }
}
