using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace WpfApp1.Model
{
    internal class SmptClientModel
    {
        public SmptClientModel(LoggedUser credentials)
        {
            this.credentials = credentials;
        }

        private LoggedUser credentials;

        public void sendMessage(RichTextBox MessageRtb, string address, string theme)
        {

            SmtpClient smtp = new SmtpClient(credentials.SmtpHost);

            smtp.Credentials = new NetworkCredential(credentials.Email, credentials.Pass);
            smtp.EnableSsl = true;

            smtp.Send(createMessage(MessageRtb, address, theme));
        }

        private MailMessage createMessage(RichTextBox MessageRtb, string address, string theme)
        {
            HtmlRtfConverter converter = new HtmlRtfConverter(MessageRtb);

            string text = converter.ToHtml();

            MailMessage mailMessage = new MailMessage(credentials.Email, address, theme, text);
            mailMessage.IsBodyHtml = true;

            return mailMessage;
        }
    }
}
