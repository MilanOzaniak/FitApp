using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FitApp.Views;
using Xamarin.Forms;
using FitApp.Services;
using System.Collections.ObjectModel;

namespace FitApp.ViewModels
{
    public class WorkoutsPlanViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<WorkoutService> ListOfWorkouts { get; set; }

        public WorkoutService workoutService;

        // W1 -> Workout1
        // T1 -> Time1


        // 
        public string _w1;
        public string W1
        {
            get
            {
                return _w1;
            }
            set
            {
                _w1 = value;
                OnPropertyChanged();
            }
        }
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

        public string _et;
        public string ET
        {
            get
            {
                return _et;
            }
            set
            {
                _et = value;
                OnPropertyChanged();
            }
        }

        public WorkoutsPlanViewModel()
        {
            workoutService = App.ws;
            ListOfWorkouts = App.ListOfWorkouts;
           
        }


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}