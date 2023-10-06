using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModel.Help;

namespace WpfApp1.View.Component
{
    /// <summary>
    /// Логика взаимодействия для bindablePasswordBox.xaml
    /// </summary>
    public partial class bindablePasswordBox : UserControl
    {
        public static readonly DependencyProperty passwordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(bindablePasswordBox), new PropertyMetadata(string.Empty));

        public string Password
        {
            get
            {
                return (string)GetValue(passwordProperty);
            }
            set
            {
                SetValue(passwordProperty, value);
            }
        }
        public bindablePasswordBox()
        {
            InitializeComponent();
        }
        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = passwordBox.Password;
        }
    }
}
