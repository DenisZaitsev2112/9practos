using ImapX;
using ImapX.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using WpfApp1.Model;
using WpfApp1.ViewModel.Help;

namespace WpfApp1.ViewModel
{
    class ListMessagesViewModel : ViewModelBase
    {
        private ListMessagesViewModel() : base()
        {
            selectItemCommand = new bindableCommand(item => selectItem(item));
            writeMessageCommand = new bindableCommand(item => writeMessage(item));
        }

        private static ListMessagesViewModel model;
        public static ListMessagesViewModel getModel()
        {
            if (model == null)
                model = new ListMessagesViewModel();
            return model;
        }

        private CancellationTokenSource cts = new CancellationTokenSource();

        public async Task getMessage(string folderName)
        {
            isEnable = true;

            isEnableListBox = false;

            await Task.Run(() =>
            {
                ItemsSource = ImapHelper.GetMessagesForFolder(folderName);
                isEnable = false;
                isEnableListBox = true;
            });
        }

        private bool _isEnable;
        public bool isEnable
        {
            get
            {
                return _isEnable;
            }
            set
            {
                _isEnable = value;
                OnPropertyChanged();
            }
        }

        private bool _isEnableListBox;
        public bool isEnableListBox
        {
            get
            {
                return _isEnableListBox;
            }
            set
            {
                _isEnableListBox = value;
                OnPropertyChanged();
            }
        }

        private MessageCollection _ItemsSource;
        public MessageCollection ItemsSource
        {
            get
            {
                return _ItemsSource;
            }
            set
            {
                _ItemsSource = value;
                OnPropertyChanged();
            }
        }

        public bindableCommand selectItemCommand { get; set; }
        private void selectItem(object item)
        {
            LinkingModel.CurrentModelEmail = MessageViewModel.getModel(item as Message);
        }
        public bindableCommand writeMessageCommand { get; set; }
        private void writeMessage(object item)
        {
            LinkingModel.CurrentModelEmail = WriteMessageViewModel.getModel((item as Message).From.Address);
        }
    }
}