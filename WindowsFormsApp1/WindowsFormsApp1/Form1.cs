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


        int x = 0;
        string message = "init" ;

        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
           
        }
        private void serial_send(int val)
        {
          
            var message = "rx.val=" + val;
            serialPort1.Write(message);
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            var message = "va0.val=101";
            serialPort1.Write(message);
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var message = "va0.val=102";
            serialPort1.Write(message);
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var message = "va0.val=103";
            serialPort1.Write(message);
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            serial_send(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text =  "cacat";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serial_send(6);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            x++;
            message = serialPort1.ReadExisting();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            label1.Text = message.ToString();
            if(message=="101")
            {
                button1.Text = "101";
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Green;
            }
            if (message == "102")
            {
                button1.Text = "102";
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Green;
            }
            if (message == "103")
            {
                button1.Text = "103";
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Red;
            }
            

        }
    }
}
