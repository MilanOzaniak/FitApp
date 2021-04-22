using System;
using System.Collections.Generic;
using System.Text;
using FitApp.Services;
using SQLite;

namespace FitApp.Models
{
    public class Reminders
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Roaster { get; set; }
        public string Name { get; set; }
    }
}
