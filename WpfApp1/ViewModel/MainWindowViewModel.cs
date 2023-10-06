using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel.Help;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            LinkingModel.onChangeValueCurrentModel += LinkingModel_onChangeValue;
        }

        private void LinkingModel_onChangeValue()
        {
            CurrentViewModel = LinkingModel.CurrentModel;
        }

        private ViewModelBase _CurrentViewModel = new AuthorizationViewModel();
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _CurrentViewModel;
            }
            set
            {
                _CurrentViewModel = value;
                OnPropertyChanged();
            }
        }
    }
}
