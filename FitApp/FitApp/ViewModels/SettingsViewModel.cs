﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FitApp.ViewModels
{
    public class SettingsViewModel : ContentPage
    {
        public string Name { get; set; }
        public SettingsViewModel()
        {
            if (Name == null)
            {
                Name = "mas maly dick";
            }
        }
    }
}