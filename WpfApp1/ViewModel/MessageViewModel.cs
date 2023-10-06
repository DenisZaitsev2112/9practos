using ImapX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;
using WpfApp1.ViewModel.Help;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    internal class MessageViewModel : ViewModelBase
    {
        private MessageViewModel() : base()
        {
            backCommand = new bindableCommand(_ => back());
            answerCommand = new bindableCommand(_ => answer());
        }

        private static MessageViewModel model;
        public static MessageViewModel getModel(Message element = null)
        {
            model ??= new MessageViewModel();

            if (element != null)
            {
                HtmlRtfConverter converter = new HtmlRtfConverter();

                model.theme = element.Subject;
                model.addressSender = element.From.Address;
                model.addressReciever = ImapHelper.GetCredentials().Email;
                model._textMessage = converter.ToRtf(element.Body.Text);
            }

            return model;
        }

        private string _addressSender;
        public string addressSender
        {
            get
            {
                return _addressSender;
            }
            set
            {
                _addressSender = value;
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

        private string _addressReciever;
        public string addressReciever
        {
            get
            {
                return _addressReciever;
            }
            set
            {
                _addressReciever = value;
                OnPropertyChanged();
            }
        }

        private string _textMessage;
        public string textMessage
        {
            get
            {
                return _textMessage;
            }
            set
            {
                _textMessage = value;
                OnPropertyChanged();
            }
        }

        public bindableCommand backCommand { get; set; }
        private void back()
        {
            LinkingModel.CurrentModelEmail = storyModel;
        }

        public bindableCommand answerCommand { get; set; }
        private void answer()
        {
            LinkingModel.CurrentModelEmail = WriteMessageViewModel.getModel(addressReciever);
        }
    }
}
