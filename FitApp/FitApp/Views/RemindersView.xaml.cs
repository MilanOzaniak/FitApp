﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RemindersView : ContentPage
    {
        public RemindersView()
        {
            InitializeComponent();
            BindingContext = new RemindersViewModel();
        }
    }
}