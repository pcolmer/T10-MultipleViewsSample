using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;

namespace T10_MultipleViewsSample.ViewModels
{
    public class Page3ViewModel : ViewModelBase
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

        public void NavigateToPage2() =>
            NavigationService.Navigate(typeof(Views.Page2));

        // Declare a couple of properties to show how deep the stack is
        // and what the pages are on the stack.
        public int StackDepth
        {
            get
            {
                Debug.WriteLine($"{nameof(StackDepth)}");
                return NavigationService?.FrameFacade?.BackStackDepth ?? -1;
            }
        }

        public List<string> StackFrames
        {
            get
            {
                var framestack = NavigationService?.FrameFacade?.Frame?.BackStack;
                List<string> result = new List<string>();
                if (framestack != null)
                    foreach (var frame in framestack)
                    {
                        result.Add(frame.SourcePageType.FullName);
                    }
                return result;
            }
        }
    }
}

