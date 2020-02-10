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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 40);


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void CloseButtonClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginField_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassField_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButtonClick_MouseEnter(object sender, EventArgs e)
        {
            CloseButtonClick.ForeColor = Color.Green;
        }

        private void CloseButtonClick_MouseLeave(object sender, EventArgs e)
        {
            CloseButtonClick.ForeColor = Color.White;
        }

        Point lastPoint;
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
                
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
