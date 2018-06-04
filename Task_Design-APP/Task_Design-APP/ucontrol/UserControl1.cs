using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Design_APP.ucontrol
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public  Image PersonImage {
            get{ return pictureBox1.Image; }
                

            set { pictureBox1.Image = value; } }
        public string PersonName
        {
            get { return labName.Text; }
            set { labName.Text = value; }
        }
        public string PersonStatus
        {
            get { return labstat.Text; }
            set {
                if (value == "Online")
                {
                    labstat.ForeColor = Color.Green;
                }
                if (value == "Offline")
                {
                    labstat.ForeColor = Color.Gray;
                }
                labstat.Text = value; }
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        
        private void UserControl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It's Just Design ^^");
        }
    }
}
