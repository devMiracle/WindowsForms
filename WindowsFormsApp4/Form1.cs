using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputTextBox.Select();
            //comboBox.Items.AddRange(new string[] { "Украина", "Россия" });

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "") return;
            listText.Items.Add(inputTextBox.Text);
            comboBox.Items.Add(inputTextBox.Text);
            inputTextBox.Clear();
            //inputTextBox.Select();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listText.SelectedIndex == -1) return;
            comboBox.SelectedIndex = listText.SelectedIndex;
            listText.Items.RemoveAt(listText.SelectedIndex);
            comboBox.Items.RemoveAt(comboBox.SelectedIndex);
        }

        

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                addButton_Click(sender, e);
                inputTextBox.Clear();
                //inputTextBox.Select();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
