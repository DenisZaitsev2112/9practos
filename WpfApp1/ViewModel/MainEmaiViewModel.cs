using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel.Help;
using WpfApp1.Model;
using System.Windows;
using ImapX.Collections;

namespace WpfApp1.ViewModel
{
    internal class MainEmaiViewModel : ViewModelBase
    {
        private MainEmaiViewModel() : base()
        {
            emailCommands = new bindableCommand(pathName => email((string)pathName));

            LinkingModel.onChangeCurrentModelEmail += LinkingModel_onChangeCurrentModelEmail;

            LinkingModel.CurrentModelEmail = ListMessagesViewModel.getModel();

            _ = (CurrentViewModel as ListMessagesViewModel).getMessage(folders[0].Name);
        }

        private void LinkingModel_onChangeCurrentModelEmail()
        {
            CurrentViewModel = LinkingModel.CurrentModelEmail;
        }

        private static MainEmaiViewModel model;
        public static MainEmaiViewModel getModel()
        {
            if (model == null)
                model = new MainEmaiViewModel();
            return model;
        }

        private CommonFolderCollection folders = ImapHelper.GetFolders();

        private ViewModelBase _CurrentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _CurrentViewModel;
            set
            {
                _CurrentViewModel = value;
                OnPropertyChanged();
            }
        }

        public bindableCommand emailCommands { get; set; }
        private void email(string pathName)
        {
            LinkingModel.CurrentModelEmail = ListMessagesViewModel.getModel();

            switch (pathName)
            {
                case "Входящие":
                    _ = (CurrentViewModel as ListMessagesViewModel).getMessage(folders[0].Name);
                    break;
                case "Спам":
                    _ =  (CurrentViewModel as ListMessagesViewModel).getMessage(folders[1].Name);
                    break;
                case "Отправленные":
                    _ =  (CurrentViewModel as ListMessagesViewModel).getMessage(folders[2].Name);
                    break;
                case "Черновик":
                    _ =  (CurrentViewModel as ListMessagesViewModel).getMessage(folders[3].Name);
                    break;
                case "Корзина":
                    _ =  (CurrentViewModel as ListMessagesViewModel).getMessage(folders[4].Name);
                    break;
                case "Написать":
                    LinkingModel.CurrentModelEmail = WriteMessageViewModel.getModel();
                    break;
            }
        }
    }
}
