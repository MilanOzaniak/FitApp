using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FitApp.Models
{
    public class User
    {
        [PrimaryKey]
        public string Name { get; set; }
        public string Age { get; set; }

    }
}
