using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
namespace Task_Design_APP
{
    public partial class Form1 : Form
    {
        int panelwidth=0;
        bool hidden=true;
        public Form1()
        {
            InitializeComponent();
            panelwidth = panel3.Width;
            hidden = false;
            panel5.Height = button1.Height;
            panel5.Top = button1.Top;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Height = button1.Height;
            panel5.Top = button1.Top;
            timer1.Start();
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                panel3.Width = panel3.Width + 10;

                if (panel3.Width >= panelwidth)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {

                panel3.Width = panel3.Width - 10;
                                 
                if (panel3.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Height = button2.Height;
            panel5.Top = button2.Top;
            Form2 z = new Form2();
            z.Show();
        //    SmtpClient s = new SmtpClient("smtp.live.com", 25);
        //    s.EnableSsl=true;
        //    s.Credentials = new NetworkCredential("mohamedx_x2015@yahoo.com", );
        //    try
        //    {
        //        s.Send("mohamedx_x2015@yahoo.com", "mohamedx_x2015@yahoo.com", "Hi", "Hello Word");
        //        MessageBox.Show("Message Sended Sucessfully");
        //    }
        //    catch(Exception z)
        //    {
        //        MessageBox.Show(z.Message);
        //    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Height = button3.Height;
            panel5.Top = button3.Top;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Height = button5.Height;
            panel5.Top = button5.Top;
        }

        int mx,my = 0;
        bool mousedown = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {

                mx = MousePosition.X-50 ;
                my = MousePosition.Y-20 ;
                this.SetDesktopLocation(mx, my);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToShortTimeString();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown==true)
            {
                
                mx = MousePosition.X-(955/2);
                my = MousePosition.Y-(484/2);
                this.SetDesktopLocation(mx,my);
            }
        }
    }
}
