using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MealsView : ContentPage
    {
        public MealsView()
        {
            InitializeComponent();
        }

        private async void WeightGainScroll(object sender, EventArgs e)
        {
            await MealsScroll.ScrollToAsync(1, Weightgain.Y, true);
        }

        private async void WeightLossScroll(object sender, EventArgs e)
        {
            await MealsScroll.ScrollToAsync(1, Weightloss.Y, true);
        }

        private async void VegetarianVeganScroll(object sender, EventArgs e)
        {
            await MealsScroll.ScrollToAsync(1, Veganvegetarian.Y, true);
        }

        private async void BreakfastScroll(object sender, EventArgs e)
        {
            await MealsScroll.ScrollToAsync(1, Breakfast.Y, true);
        }
    }
}