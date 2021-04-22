using System;
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
    public partial class WorkoutsView : ContentPage
    {

        public WorkoutsView()
        {
            InitializeComponent();
        }
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkoutArmsView());
        }
        private async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkoutsPlanView());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await WorkoutsScroll.ScrollToAsync(1, Beginner.Y, true);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await WorkoutsScroll.ScrollToAsync(1, Intermediate.Y, true);
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await WorkoutsScroll.ScrollToAsync(1, Advanced.Y, true);
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await WorkoutsScroll.ScrollToAsync(1, WorkoutsScroll.Y, true);
        }

    }
}