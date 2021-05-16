using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitApp.Models;
using FitApp.Views;
using GalaSoft.MvvmLight;
using MvvmHelpers;
using MvvmHelpers.Commands;
using FitApp.Services;
using Xamarin.Forms;
using Command = MvvmHelpers.Commands.Command;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace FitApp.ViewModels
{
    public class RemindersViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableRangeCollection<Reminders> Reminders { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Reminders> RemoveCommand { get; }
        public AsyncCommand SaveCommand { get; set; }

        public INavigation Navigation { get; set; }

        public string _reminderName;
        public string ReminderName
        {
            get
            {
                return _reminderName;
            }
            set
            {
                _reminderName = value;
                OnPropertyChanged();
            }
        }
        public TimeSpan _reminderTime;
        public TimeSpan ReminderTime
        {
            get
            {
                return _reminderTime;
            }
            set
            {
                _reminderTime = value;
                OnPropertyChanged();
            }
        }

        bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public RemindersViewModel()
        {
            Reminders = new ObservableRangeCollection<Reminders>();

            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RemoveCommand = new AsyncCommand<Reminders>(Remove);
            SaveCommand = new AsyncCommand(Save);

            LoadData();

        }
        public async void LoadData()
        {
            var reminders = await ReminderService.GetReminders();
            Reminders.AddRange(reminders);
        }
        async Task Add()
        {

            await Application.Current.MainPage.Navigation.PushAsync(new ReminderCreateView());
            await Refresh();
        }


        async Task Remove(Reminders reminders)
        {
            await ReminderService.RemoveReminder(reminders.Id);
            await Refresh();
        }

        async Task Refresh()
        {
            IsBusy = true;      
            await Task.Delay(1000);
            Reminders.Clear();
            LoadData();
            IsBusy = false;
        }


        public async Task Save()
        {
            string Time = ReminderTime.ToString(@"hh\:mm");
            await ReminderService.AddReminder(ReminderName, Time);
            await Application.Current.MainPage.Navigation.PopToRootAsync();
        }



        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}