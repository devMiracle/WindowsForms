using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
        }

        private void okButton_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Кнопка Ok";
        }

        private void okButton_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
        }

        private void cancelButton_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Кнопка Cancel";
        }

        private void cancelButton_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void okButton_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "Click!";
        }

        private void cancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "Click!";
        }

        private void okButton_MouseUp(object sender, MouseEventArgs e)
        {
            okButton_MouseEnter(sender, e);
        }

        private void cancelButton_MouseUp(object sender, MouseEventArgs e)
        {
            cancelButton_MouseEnter(sender, e);
        }

        private void okButton_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
        }

        private void cancelButton_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
        }

        private void okButton_MouseHover(object sender, EventArgs e)
        {
            label3.Text = "test";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
