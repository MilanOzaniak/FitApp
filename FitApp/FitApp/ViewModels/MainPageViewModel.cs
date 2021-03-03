using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FitApp.Views;
using Prism.Mvvm;
using Xamarin.Forms;

namespace FitApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public ICommand Recipe { get; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty( ref _title, value); }
        }
    }
}