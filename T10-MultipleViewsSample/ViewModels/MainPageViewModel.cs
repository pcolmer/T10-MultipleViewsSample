using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;

namespace T10_MultipleViewsSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public void NavigateToPage2() =>
            NavigationService.Navigate(typeof(Views.Page2));

        public void Page2InNewWindow() =>
            NavigationService.OpenAsync(typeof(Views.Page2));
    }
}

