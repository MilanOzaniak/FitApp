using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using FitApp.Models;
using SQLite;
using Xamarin.Essentials;

namespace FitApp.Services
{
    public static class ReminderService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Reminders>();
        }
        public static async Task AddReminder(string name, string roaster)
        {
            await Init();
            var reminder = new Reminders
            {
                Name = name,
                Roaster = roaster,
            };
           var id = await db.InsertAsync(reminder);
        }
        public static async Task RemoveReminder(int id)
        {
            await Init();

            await db.DeleteAsync<Reminders>(id);
        }
        public static async Task<IEnumerable<Reminders>> GetReminders()
        {
           await Init();

           var reminder = await db.Table<Reminders>().ToListAsync();
           return reminder;
        }

    }
}
