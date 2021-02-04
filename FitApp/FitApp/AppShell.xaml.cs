using System;
using System.Collections.Generic;
using FitApp.Views;
using Xamarin.Forms;

namespace FitApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            Shell.SetTabBarIsVisible(this, false);
            InitializeComponent();
        }

    }
}
