using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel.Help
{
    internal class ViewModelBase : propertyChanged
    {
        public ViewModelBase()
        {
            LinkingModel.onChangeStoryModel += LinkingModel_onChangeStoryModel;
        }

        protected void LinkingModel_onChangeStoryModel()
        {
            storyModel = LinkingModel.StoryModel;
        }

        protected ViewModelBase storyModel;
    }
}
