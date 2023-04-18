using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x = 0;
        string message = "init" ;
        string cacat;
        string buffer;
        Array ports;
        bool connected = false;

        public Form1()
        {
            InitializeComponent();
            ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange((object[])ports);
            comboBox1.BackColor = Color.Red;
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("rx.val=\"101\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("rx.val=\"102\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("rx.val=\"103\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        public void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            message = serialPort1.ReadByte().ToString();
            Shit(message);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

         private void Shit(string cacat)
        {

            Form1.CheckForIllegalCrossThreadCalls = false;
            if (cacat == "49")
            {
                button1.BackgroundImage = Properties.Resources.btn2green;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2;
            }

            if (cacat == "50")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2green;
                button3.BackgroundImage = Properties.Resources.btn2;
            }
            if (cacat == "51")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2green;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
          if (connected == true) { 
            serialPort1.Write("rx.val=101");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
           } 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (connected == true)
            {
                serialPort1.Write("rx.val=102");
                serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
                serialPort1.Write("execute_rx.en=1");
                serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (connected == true)
            {
                serialPort1.Write("rx.val=103");
                serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
                serialPort1.Write("execute_rx.en=1");
                serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            }
            }

        private void button4_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("rx.txt=\"101\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("rx.txt=\"101\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("rx.txt=\"101\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text !=  "")
            {
                comboBox1.BackColor = Color.Green;
                button7.Enabled = true;
               

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Connect")
            {
                connected = true;
                serialPort1.PortName = "COM6";
                serialPort1.Open();
                serialPort1.Write("execute_rx.en=1");
                serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
                button7.Text = "Disconnect";
                comboBox1.BackColor = Color.Green;
                return  ;
            }    
            if (button7.Text == "Disconnect")
                {
                connected = false;
                serialPort1.Close();
                button7.Text = "Connect";
                comboBox1.BackColor = Color.Red;
                return ;

            }
                
                
                }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
        }
    }

       
}
