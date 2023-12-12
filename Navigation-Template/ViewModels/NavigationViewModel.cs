using Navigation_Template.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Navigation_Template.ViewModels
{
    internal class NavigationViewModel : ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand Page1Command { get; set; }
        public ICommand Page2Command { get; set; }

        private void Page1(object obj) => CurrentView = new Page1ViewModel();
        private void Page2(object obj) => CurrentView = new Page2ViewModel();

        public NavigationViewModel()
        {
            Page1Command = new RelayCommand(Page1);
            Page2Command = new RelayCommand(Page2);

            CurrentView = new Page1ViewModel();
        }

    }
}
