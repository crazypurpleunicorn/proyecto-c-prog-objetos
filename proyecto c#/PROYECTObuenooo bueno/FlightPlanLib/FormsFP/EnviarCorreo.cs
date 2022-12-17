using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsFP
{
    public partial class EnviarCorreo : Form
    {
        public EnviarCorreo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(textBox1.Text);
            msg.Subject = textBox2.Text;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Bcc.Add(textBox4.Text);

            msg.Body = textBox3.Text;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("correopruebainfo2@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("correopruebainfo2@gmail.com", "PRUEBAinfo2");

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(msg);
                MessageBox.Show("Mensaje enviado! revise su correo.");
                Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
