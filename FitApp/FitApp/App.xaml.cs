using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FitApp.Views;
using FitApp.Services;
using System.Collections.ObjectModel;

namespace FitApp
{
    public partial class App : Application
    {
        public static WorkoutService ws { get; } = new WorkoutService();
        public static MealsService ms { get; } = new MealsService();

        public static ObservableCollection<WorkoutService> ListOfWorkouts { get; set; } = new ObservableCollection<WorkoutService>();
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
