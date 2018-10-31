using ScrollControl.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrollControl.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        private INavigation _navigation;

        public ICommand OpenHorizontalCmd { get; set; }
        public ICommand OpenVerticalCmd { get; set; }
        public ICommand OpenFlexCmd { get; set; }
        public ICommand OpenTemplaceSelectorCmd { get; set; }

        public StartViewModel(INavigation navigation)
        {
            _navigation = navigation;
            OpenHorizontalCmd = new Command(OpenHorizontalPage);
            OpenVerticalCmd = new Command(OpenVerticalPage);
            OpenFlexCmd = new Command(OpenFlexPage);
            OpenTemplaceSelectorCmd = new Command(OpenTemplateSelectorPage);
        }

        private async void OpenTemplateSelectorPage(object obj)
        {
            await _navigation.PushAsync(new TemplateSelectorPage());
        }

        private async void OpenFlexPage(object obj)
        {
            await _navigation.PushAsync(new FlexPage());
        }

        private async void OpenVerticalPage(object obj)
        {
            await _navigation.PushAsync(new VerticalPage());
        }

        private async void OpenHorizontalPage(object obj)
        {
            await _navigation.PushAsync(new HorizontalPage());
        }

        
    }
}
