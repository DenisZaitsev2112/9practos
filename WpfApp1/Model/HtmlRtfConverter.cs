using Spire.Doc;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Documents;
using System.Windows.Controls;

namespace WpfApp1.Model
{
    internal class HtmlRtfConverter
    {
        public HtmlRtfConverter(RichTextBox rtb = null)
        {
            this.rtb = rtb?? new RichTextBox();
        }

        private RichTextBox rtb;

        public string ToRtf(string html)
        {
            _ToRtf(html);

            TextRange text = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            FileStream fs = new FileStream("msg.rtf", FileMode.Open);
            text.Load(fs, DataFormats.Rtf);
            fs.Close();

            File.Delete("msg.rtf");

            return text.Text;
        }
        public string ToHtml()
        {
            rtb.Foreground = Brushes.Black;

            _ToHtml(new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd));
            string text = File.ReadAllText("send.html");

            File.Delete("send.html");

            return text;
        }
        private void _ToRtf(string html)
        {
            File.WriteAllText("msg.html", html);
            var d = new Document("msg.html", FileFormat.Html);
            d.SaveToFile("msg.rtf", FileFormat.Rtf);
            d.Close();
            File.Delete("msg.html");
        }

        private void _ToHtml(TextRange rtf)
        {
            var fs = new FileStream("send.rtf", FileMode.Create);
            rtf.Save(fs, DataFormats.Rtf);
            fs.Close();
            var d = new Document("send.rtf", FileFormat.Rtf);
            d.SaveToFile("send.html", FileFormat.Html);
            d.Close();
            File.Delete("send.rtf");
        }
    }
}
