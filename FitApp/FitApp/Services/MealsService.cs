using System;
using System.Collections.Generic;
using System.Text;

namespace FitApp.Services
{
    public class MealsService
    {

            public string Image { get; set; }
            public string Titile { get; set; }
            public string Ingredients { get; set; }
            public string Step1 { get; set; }
            public string Step2 { get; set; }
            public string Step3 { get; set; }
            public string Step4 { get; set; }
            public string Step5 { get; set; }
            public string Step6 { get; set; }

            public void SetRecipe(string image, string title, string ingredients, string s1, string s2, string s3, string s4, string s5, string s6)
            {
                Image = image;
                Titile = title;
                Ingredients = ingredients;
                Step1 = s1;
                Step2 = s2;
                Step3 = s3;
                Step4 = s4;
                Step5 = s5;
                Step6 = s6;
            }
    }
}
