using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor=Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var surname=textBox2.Text;

            MessageBox.Show(name + " " + surname);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BackColor = Color.Violet;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sira = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(sira);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxyeniad.Text != "")
            {
            
            string vergul = ",";
            bool netice = textBoxyeniad.Text.Contains(vergul);

                if (netice)
                {
                    listBox1.Items.Add(textBoxyeniad.Text.Replace(vergul, " "));
                }
                else
                {
                    listBox1.Items.Add(textBoxyeniad.Text);
                    textBoxyeniad.Text = "";
                    textBoxyeniad.Focus();
                }

            }
           
        }
    }
}
