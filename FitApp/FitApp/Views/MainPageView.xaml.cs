using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FitApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageView : ContentPage
    {
        public MainPageView()
        {
            InitializeComponent();
        }


        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recipe1View());
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WorkoutArmsView());
        }
    }
}