using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using FitApp.Views;
using FitApp.Models;
using System.ComponentModel;

namespace FitApp.ViewModels
{
    public class RegistrationInfoViewModel : ContentPage, INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public RegistrationInfoViewModel()
        {

        }


    }
}