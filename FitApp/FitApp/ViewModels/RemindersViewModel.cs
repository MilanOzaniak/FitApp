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

namespace FitApp.ViewModels
{
    public class RemindersViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableRangeCollection<Reminders> Reminders { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Reminders> RemoveCommand { get; }

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
            LoadData();

        }
        public async void LoadData()
        {
            var reminders = await ReminderService.GetReminders();
            Reminders.AddRange(reminders);
        }
        async Task Add()
        {
            var name = await App.Current.MainPage.DisplayPromptAsync("Name", "Name of my reminder");
            var roaster = await App.Current.MainPage.DisplayPromptAsync("Roaster", "Roaster of reminder");
            await ReminderService.AddReminder(name, roaster);
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

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}