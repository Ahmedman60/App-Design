using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Task_Design_APP
{
    public partial class Closing_Pccs : Form
    {
        string shutdown;
        //int age = 0;
        public Closing_Pccs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
            Process.Start("shutdown", shutdown + "-t" + textBox1.Text);
            timer1.Start();
            lbltime.Text = textBox1.Text;
            }
           

            //int.TryParse(textBox2.Text, out age);
            //MessageBox.Show(age.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
            timer1.Stop();
            textBox1.Text = "0";
            lbltime.Text = "00";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    shutdown = "-s";
                    break;
                case 1:
                    shutdown = "-r";
                    break;
                case 2:
                    shutdown = "-l";
                        break;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = (int.Parse(lbltime.Text) - 1).ToString();
        }

       
    }
}
