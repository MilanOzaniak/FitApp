using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using FitApp.Views;
using Xamarin.Forms;

namespace FitApp.ViewModels
{
    public class BMIViewModel : INotifyPropertyChanged
    {
        int weight;
        int height;
        int m = 10000;
        double BmiNum;
        double Square;
        string Bmi;
        string BmiText;

        public event PropertyChangedEventHandler PropertyChanged;
        public int Weight 
        {
          get => weight;
          set
          {
                weight = value;
                OnPropertyChanged();
          }
        }   
        public int Height 
        {
          get => height;
          set
          {
                height = value;
                OnPropertyChanged();
          }
        }
        public string BMI
        {
            get
            {
                return Bmi;
            }

            set
            {
                Bmi = value;
                OnPropertyChanged();
            }
        }
        public string BMIText
        {
            get
            {
                return BmiText;
            }
            set
            {
                BmiText = value;
                OnPropertyChanged();
            }
        }
        public ICommand CalculateBMI { private set; get; }


        public BMIViewModel()
        {
            CalculateBMI = new Command(Calculate);
        }


        void Calculate()
        {
            Square = height * height;
            Square = Square / m;
            BmiNum = weight / Square;
            BMI = Math.Round(BmiNum, 2, MidpointRounding.AwayFromZero).ToString();

            if (BmiNum < 18.5)
            {
                BMIText = "You are underweight";
            }
            else if ( BmiNum > 18.6 )
            {
                if (BmiNum < 24.9)
                {
                    BMIText = "Your weight is normal";
                }
                else if (BmiNum > 25)
                {
                    if (BmiNum < 29.9)
                    {
                        BMIText = "You are overweight";
                    }
                    else if (BmiNum > 30)
                    {
                        BMIText = "You are obese";
                    }
                }
            }
               
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}