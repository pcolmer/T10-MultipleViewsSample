﻿using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;

namespace T10_MultipleViewsSample.ViewModels
{
    public class Page2ViewModel : ViewModelBase
    {

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            Debug.WriteLine($"{nameof(OnNavigatedToAsync)}");
            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            Debug.WriteLine($"{nameof(OnNavigatedFromAsync)}");
            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            Debug.WriteLine($"{nameof(OnNavigatingFromAsync)}");
            args.Cancel = false;
            await Task.CompletedTask;
        }

        public void NavigateToPage3() =>
            NavigationService.Navigate(typeof(Views.Page3));

        public int StackDepth
        {
            get
            {
                Debug.WriteLine($"{nameof(StackDepth)}");
                return NavigationService?.FrameFacade?.BackStackDepth ?? -1;
            }
        }
    }
}
