using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using System.Reactive;
using Visual_RGR.Models;
    
namespace Visual_RGR.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {

        public FirstViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
        }

        public ReactiveCommand<Tabs, Unit> ButtonDeleteTab { get; }

        public MainWindowViewModel? MainContext { get; set; }


    }
}
