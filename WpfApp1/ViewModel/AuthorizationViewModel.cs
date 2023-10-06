using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp1.Model;
using WpfApp1.ViewModel.Help;

namespace WpfApp1.ViewModel
{
    internal class AuthorizationViewModel : ViewModelBase
    {
        public AuthorizationViewModel()
        {
            logInCommand = new bindableCommand(_ => logIn());
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

        private string _password;
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private ComboBoxItem _selectedItem;
        public ComboBoxItem selectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
            }
        }

        public bindableCommand logInCommand { get; set; }
        private void logIn()
        {
            try
            {
                AuthorizationModel authorization = new AuthorizationModel(password, address, selectedItem?.Tag.ToString());

                if (authorization.isConnect())
                {
                    LinkingModel.CurrentModel = MainEmaiViewModel.getModel();
                    return;
                }
                else
                {
                    MessageBox.Show("Ошибка: Неверный адресс или пароль");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка: Выберите почту");
            }
        }
    }
}
