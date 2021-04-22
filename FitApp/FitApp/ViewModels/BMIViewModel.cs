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
        int _weight;
        int _height;
        int m = 10000;
        double BmiNum;
        double Square;
        string _Bmi;
        string _BmiText;
        Color _color;

        public event PropertyChangedEventHandler PropertyChanged;
        public int Weight 
        {
          get => _weight;
          set
          {
                _weight = value;
                OnPropertyChanged();
          }
        }   
        public int Height 
        {
          get => _height;
          set
          {
                _height = value;
                OnPropertyChanged();
          }
        }
        public string BMI
        {
            get
            {
                return _Bmi;
            }

            set
            {
                _Bmi = value;
                OnPropertyChanged();
            }
        }
        public string BMIText
        {
            get
            {
                return _BmiText;
            }
            set
            {
                _BmiText = value;
                OnPropertyChanged();
            }
        }
        public Color BMIColor
        {
            get => _color;
            set
            {
                _color = value;
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
            Square = _height * _height;
            Square = Square / m;
            BmiNum = _weight / Square;
            BMI = Math.Round(BmiNum, 2, MidpointRounding.AwayFromZero).ToString();

            if (BmiNum < 18.5)
            {
                BMIText = "You are underweight";
                BMIColor = Color.Orange;
            }
            else if ( BmiNum > 18.6 )
            {
                if (BmiNum < 24.9)
                {
                    BMIText = "Your weight is normal";
                    BMIColor = Color.Green;
                }
                else if (BmiNum > 25)
                {
                    if (BmiNum < 29.9)
                    {
                        BMIText = "You are overweight";
                        BMIColor = Color.Orange;
                    }
                    else if (BmiNum > 30)
                    {
                        BMIText = "You are obese";
                        BMIColor = Color.Red;
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