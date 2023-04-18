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
            toolStripComboBox1.Items.AddRange((object[])ports);
            toolStripComboBox1.Text = "None";
            comboBox1.Items.AddRange((object[])ports);
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
            Shit(message.ToString());
               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

         private void Shit(string cacat)
        {

            Form1.CheckForIllegalCrossThreadCalls = false;
            textBox1.Text = cacat;
            if (cacat == "49")
            {
                button1.BackgroundImage = Properties.Resources.btn2green;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2;
                button4.BackgroundImage = Properties.Resources.btn2;
                button5.BackgroundImage = Properties.Resources.btn2;
                button6.BackgroundImage = Properties.Resources.btn2;
            }

            if (cacat == "50")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2green;
                button3.BackgroundImage = Properties.Resources.btn2;
                button4.BackgroundImage = Properties.Resources.btn2;
                button5.BackgroundImage = Properties.Resources.btn2;
                button6.BackgroundImage = Properties.Resources.btn2;

            }
            if (cacat == "51")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2green;
                button4.BackgroundImage = Properties.Resources.btn2;
                button5.BackgroundImage = Properties.Resources.btn2;
                button6.BackgroundImage = Properties.Resources.btn2;
            }
            if (cacat == "52")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2;
                button4.BackgroundImage = Properties.Resources.btn2green;
                button5.BackgroundImage = Properties.Resources.btn2;
                button6.BackgroundImage = Properties.Resources.btn2;
            }
            if (cacat == "53")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2;
                button4.BackgroundImage = Properties.Resources.btn2;
                button5.BackgroundImage = Properties.Resources.btn2green;
                button6.BackgroundImage = Properties.Resources.btn2;
            }
            if (cacat == "54")
            {
                button1.BackgroundImage = Properties.Resources.btn2;
                button2.BackgroundImage = Properties.Resources.btn2;
                button3.BackgroundImage = Properties.Resources.btn2;
                button4.BackgroundImage = Properties.Resources.btn2;
                button5.BackgroundImage = Properties.Resources.btn2;
                button6.BackgroundImage = Properties.Resources.btn2green;
            }

            if (cacat == "114")
            {
                button8.BackColor = Color.Green;
            }

            if (cacat == "116")
            {
                button8.BackColor = Color.Red;
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
            textBox1.Text = System.Configuration.ConfigurationManager.AppSettings["port"];
       
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
               }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void nameEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.ReadOnly == false)
            {
                enableToolStripMenuItem.Text = "Enable";
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox2.ForeColor = Color.Yellow;
                textBox3.ForeColor = Color.Yellow;
                textBox4.ForeColor = Color.Yellow;
                textBox5.ForeColor = Color.Yellow;
                textBox6.ForeColor = Color.Yellow;
                textBox7.ForeColor = Color.Yellow;
            }
            else
            {
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox6.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox2.ForeColor = Color.White;
                textBox3.ForeColor = Color.White;
                textBox4.ForeColor = Color.White;
                textBox5.ForeColor = Color.White;
                textBox6.ForeColor = Color.White;
                textBox7.ForeColor = Color.White;
                enableToolStripMenuItem.Text = "Save";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("wepo " + "\"" + textBox2.Text + "\"," + "100");
            serialPort1.Write(new byte[] { 0xFF, 0xFF, 0xFF }, 0, 3);

            System.Configuration.ConfigurationManager.AppSettings.Add("port", "plm");
           
      
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    
    }

       
}
