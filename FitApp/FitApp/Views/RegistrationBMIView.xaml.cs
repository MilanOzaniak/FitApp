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

    public partial class RegistrationBMIView : ContentPage
    {
        public RegistrationBMIView()
        {
           //m2 = HeightSlider.Value / 100;
           //BMI = WeightSlider.Value / m2;
           //YourBMI.Text = BMI.ToString();
            InitializeComponent();
        }

    }
}