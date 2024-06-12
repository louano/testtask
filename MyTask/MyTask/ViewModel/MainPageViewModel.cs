using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask.ViewModel
{
    public partial class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {
            SecondButtonEnabled = true;
            Counter = 0;
        }

        [ObservableProperty]
        int counter;

        [ObservableProperty]
        Boolean secondButtonEnabled;

        [RelayCommand]
        void ToggleBooleanVar()
        {
            SecondButtonEnabled = !SecondButtonEnabled;

        }

        [RelayCommand]
        void IncrementVar()
        {
            Counter++;
        }
    }
}
