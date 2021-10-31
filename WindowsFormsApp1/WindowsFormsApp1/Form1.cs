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

        public Form1()
        {
            InitializeComponent();
            

                    //serialPort1.PortName = ports.ToString();
                    serialPort1.PortName = "COM5";
                    serialPort1.Open();
                    serialPort1.Write("execute_rx.en=1");
                    serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
               
           
        }
 


        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("rx.txt=\"101\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
      


        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("rx.txt=\"102\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
     

        }

        private void button3_Click(object sender, EventArgs e)
        {

            serialPort1.Write("rx.txt=\"103\"");
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

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           message = serialPort1.ReadExisting();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
 
            if (message == "101")
            {
                button1.BackgroundImage = Properties.Resources.btn2green;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2;
            }

            if (message == "102")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2green;
                button3.BackgroundImage = Properties.Resources.btn2;
            }
            if (message == "103")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2green;
            }

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("rx.txt=\"101\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("rx.txt=\"102\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("rx.txt=\"103\"");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
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
    }
}
