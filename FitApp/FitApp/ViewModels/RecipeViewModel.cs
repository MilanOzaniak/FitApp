using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FitApp.Services;
using Xamarin.Forms;

namespace FitApp.ViewModels
{
    public class RecipeViewModel : ContentPage
    {
        public MealsService mealsService;
        public RecipeViewModel()
        {
            mealsService = App.ms;
            setValues();
        }

        //  I1 --> Image1
        //  T1 --> Title1
        //  R1 --> Recipe1
        //  S1 --> Step1 - 6

        //Image

        public string _i1;
        public string I1
        {
            get
            {
                return _i1;
            }
            set
            {
                _i1 = value;
                OnPropertyChanged();
            }
        }

        //title

        public string _t1;
        public string T1
        {
            get
            {
                return _t1;
            }
            set
            {
                _t1 = value;
                OnPropertyChanged();
            }
        }

        //ingredients

        public string _ing1;
        public string Ing1
        {
            get
            {
                return _ing1;
            }
            set
            {
                _ing1 = value;
                OnPropertyChanged();
            }
        }

        //STEPS, RECIPE

        public string s1;
        public string S1
        {
            get
            {
                return s1;
            }
            set
            {
                s1 = value;
                OnPropertyChanged();
            }
        } 

        public string s2;
        public string S2
        {
            get
            {
                return s2;
            }
            set
            {
                s2 = value;
                OnPropertyChanged();
            }
        }

        public string s3;
        public string S3
        {
            get
            {
                return s3;
            }
            set
            {
                s3 = value;
                OnPropertyChanged();
            }
        }
        
        public string s4;
        public string S4
        {
            get
            {
                return s4;
            }
            set
            {
                s4 = value;
                OnPropertyChanged();
            }
        }
        
        public string s5;
        public string S5
        {
            get
            {
                return s5;
            }
            set
            {
                s5 = value;
                OnPropertyChanged();
            }
        } 
        
        public string s6;
        public string S6
        {
            get
            {
                return s6;
            }
            set
            {
                s6 = value;
                OnPropertyChanged();
            }
        }

        //


        private void setValues()
        {
            I1 = mealsService.Image;
            T1 = mealsService.Titile;
            Ing1 = mealsService.Ingredients;
            S1 = mealsService.Step1;
            S2 = mealsService.Step2;
            S3 = mealsService.Step3;
            S4 = mealsService.Step4;
            S5 = mealsService.Step5;
            S6 = mealsService.Step6;
        }
    }
}