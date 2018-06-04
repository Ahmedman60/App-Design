using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

using System.IO;
namespace Task_Design_APP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //do submit
                MailMessage emailMessage = new MailMessage();
                emailMessage.From = new MailAddress("mohamedman60@yahoo.com", "01210930010");
                emailMessage.To.Add(new MailAddress("mohamedx_x2015@yahoo.com", "01206312998"));
                emailMessage.Subject = "SUBJECT";
                emailMessage.Body = "BODY";
                emailMessage.Priority = MailPriority.Normal;
                SmtpClient MailClient = new SmtpClient("smtp.mail.yahoo.com",587);
                MailClient.Credentials = new System.Net.NetworkCredential("mohamedx_x2015@yahoo.com", "01206312998");
                MailClient.Send(emailMessage);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




            //try
            //{
            //    string smtpAddress = "smtp.mail.yahoo.com";
            //    int portNumber = 587;
            //    bool enableSSL = true;

            //    string emailFrom = "mohamedman60@yahoo.com";
            //    string password = "01210930040";
            //    string emailTo = "mohamedx_x2015@yahoo.com";
            //    string subject = "Hello";
            //    string body = "Hello, I'm just writing this to say Hi!";

            //    using (MailMessage mail = new MailMessage())
            //    {
            //        mail.From = new MailAddress(emailFrom);
            //        mail.To.Add(emailTo);
            //        mail.Subject = subject;
            //        mail.Body = body;
            //        mail.IsBodyHtml = false;
            //        //Can set to false, if you are sending pure text.

            //        mail.Attachments.Add(new Attachment("C:\\SomeFile.txt"));
            //        mail.Attachments.Add(new Attachment("C:\\SomeZip.zip"));

            //        using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
            //        {
            //            smtp.Credentials = new NetworkCredential(emailFrom, password);
            //            smtp.EnableSsl = enableSSL;
            //            smtp.Send(mail);
            //        }
            //    }

            //}
            //catch (Exception z)
            //{
            //    MessageBox.Show(z.Message);
            //}

            //try
            //{
            //    SmtpClient c = new SmtpClient("smtp.mail.yahoo.com", 587);
            //    c.EnableSsl = true;
            //    c.Timeout = 10000;
                
            //    c.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    c.UseDefaultCredentials = false;
            //    c.Credentials = new NetworkCredential("mohamedman60@yahoo.com", "01210930040");

               

            //    MailMessage msg = new MailMessage();
            //    msg.Priority = MailPriority.Normal;
            //    msg.To.Add("Mohamedx_x2015@yahoo.com");
            //    msg.From = new MailAddress("mohamedman60@yahoo.com");
            //    msg.Subject = textBox2.Text;
            //    msg.Body = textBox3.Text;
            //    msg.IsBodyHtml = false;
            //    c.Send(msg);
            //    MessageBox.Show("Message Send Succesfully");

            //}
            //catch (Exception z)
            //{
            //    MessageBox.Show(z.Message);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Text File|*.txt";
            if(s.ShowDialog() == DialogResult.OK)
            {
                string path = s.FileName;
                BinaryWriter w = new BinaryWriter(File.Create(path));
                w.Write(textBox3.Text);
                w.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter="Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                textBox3.Text = ofd.SafeFileName; //get the name of file itself not path.
                 textBox2.Text=File.ReadAllText(ofd.FileName);

            }
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
