using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ApplicationTest
{
    public static class MessageSender
    {
        //TODO: допилить
        public static void SendMessage(string _subject, string _message)
        {
            SmtpClient _smtp = new SmtpClient("smtp.gmail.com", 587);

            _smtp.Credentials = new NetworkCredential("username", "password");

            _smtp.EnableSsl = true;

            MailMessage _mail = new MailMessage();

            _mail.From = new MailAddress("mail");

            _mail.To.Add(new MailAddress("mail"));

            _mail.SubjectEncoding = Encoding.UTF8;

            _mail.BodyEncoding = Encoding.UTF8;

            _mail.Subject = _subject;

            _mail.Body = _message;

            try
            {
                _smtp.Send(_mail);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



    }

}
