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

        public Form1()
        {
            InitializeComponent();
        }
        private void serial_send(int val)
        {
            serialPort1.Open();
            var message = "rx.val=" + val;
            serialPort1.Write(message);
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Write("execute_rx.en=1");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);
            serialPort1.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            serial_send(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serial_send(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            serial_send(3);
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
            serial_send(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serial_send(6);
        }
    }
}
