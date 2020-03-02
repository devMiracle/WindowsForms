using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationTest
{
    public partial class Form1 : Form
    {
        static String host = System.Net.Dns.GetHostName();
        IPAddress ip = Dns.GetHostByName(host).AddressList[1];
        

        

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = ip.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            MessageSender.SendMessage("test", "Hello World!");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
