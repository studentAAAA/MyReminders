using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MyReminders
{
    public class Reminder
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }

        public Reminder()
        {
            Title = "Empty";
            Description = "Empty";
        }
        public Reminder(string title)
        {
            Title = title;
            Description = "Empty";
        }

        public Reminder(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public Reminder(string title, string description, DateTime dateTime)
        {
            Title = title;
            Description = description;
            DateTime = dateTime;
        }
    }
}
