using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ViewModel.Help;

namespace WpfApp1.Model
{
    internal static class LinkingModel
    {
        // Делегат для события
        public delegate void ChangeValue();

        // Создание события изменения VideModel
        public static event ChangeValue onChangeValueCurrentModel = delegate { };

        public static event ChangeValue onChangeStoryModel = delegate { };

        public static event ChangeValue onChangeCurrentModelEmail = delegate { };
        // Подключение переменных для передачи между ViewModel

        private static ViewModelBase _CurrentModel;
        public static ViewModelBase CurrentModel
        {
            get => _CurrentModel;
            set
            {
                if(value != _CurrentModel)
                {
                    _CurrentModel = value;

                    onChangeValueCurrentModel();
                }
            }
        }

        private static ViewModelBase _CurrentModelEmail;
        public static ViewModelBase CurrentModelEmail
        {
            get
            {
                return _CurrentModelEmail;
            }
            set
            {
                StoryModel = _CurrentModelEmail;

                _CurrentModelEmail = value;

                onChangeCurrentModelEmail();
            }
        }

        private static ViewModelBase _StoryModel;
        public static ViewModelBase StoryModel
        {
            get => _StoryModel;
            set
            {
                _StoryModel = value;

                onChangeStoryModel();
            }
        }
    }
}
