using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Model;
using WpfApp1.ViewModel.Help;

namespace WpfApp1.ViewModel
{
    internal class WriteMessageViewModel : ViewModelBase
    {
        private WriteMessageViewModel() : base()
        {
            sendCommand = new bindableCommand(RichTextBox => send(RichTextBox));
            backCommand = new bindableCommand(_ => back());
        }

        private static WriteMessageViewModel model;
        public static WriteMessageViewModel getModel(string reciever = null)
        {
            model ??= new WriteMessageViewModel();

            model.address = reciever;

            return model;
        }

        private string _address;
        public string address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }

        private string _theme;
        public string theme
        {
            get
            {
                return _theme;
            }
            set
            {
                _theme = value;
                OnPropertyChanged();
            }
        }

        public bindableCommand sendCommand { get; set; }
        private void send(object RichTextBox)
        {
            var user = ImapHelper.GetCredentials();

            SmptClientModel smptModel = new SmptClientModel(user);

            try
            {
                smptModel.sendMessage(RichTextBox as RichTextBox, address, theme);
            }
            catch
            {
                MessageBox.Show("Ошибка: не удалось отправить письмо");
                return;
            }

            (RichTextBox as RichTextBox).Document.Blocks.Clear();

            address = null;

            theme = null;
        }

        public bindableCommand backCommand { get; set; }
        private void back()
        {
            LinkingModel.CurrentModelEmail = storyModel;
        }
    }
}
