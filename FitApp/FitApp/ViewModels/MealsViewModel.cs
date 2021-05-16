using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitApp.Views;
using MvvmHelpers.Commands;
using Xamarin.Forms;

namespace FitApp.ViewModels
{
    public class MealsViewModel : ContentPage
    {
        public AsyncCommand FirstMealCommand { get; set; }
        public AsyncCommand SecondMealCommand { get; set; }
        public MealsViewModel()
        {
            FirstMealCommand = new AsyncCommand(FirstMeal);
            SecondMealCommand = new AsyncCommand(SecondMeal);
        }

        async Task FirstMeal()
        {
            App.ms.SetRecipe("Meal1.jpg", "Fit Kuracie Prsia",
                "-  800 g kuracích pŕs " + "\n" + "-  1 PL oleja" + "\n" + "-  1 cibuľa" + "\n" + "-  400 ml kokosového mlieka"  + "\n" + "-  500 g brokolice" + "\n" + 
                "-  2-3 PL sójovej omáčky" + "\n" + "-  30 g slnečnicových semienok" + "\n" + "-  1 ČL soli" + "\n" + "-  1/2 ČL mletého čierneho korenia" + "\n" + 
                "-  čerstvá petržlenová vňať" + "\n" + "-  1/4 ČL kurkumy", "1", "2", "3", "4", "5", "6");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }
        async Task SecondMeal()
        {
            App.ms.SetRecipe("Meal2.jpg", "SecondMeal", "ajsdjkasdjkans","1", "2", "3", "4", "5", "6");
            await Application.Current.MainPage.Navigation.PushAsync(new Recipe1View());
        }

    }
}