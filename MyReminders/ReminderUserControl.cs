using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyReminders
{
    public partial class ReminderUserControl : UserControl
    {
        private string _title;
        private string _description;
        private DateTime _dateTime;
        private string pm = "am";
        public ReminderUserControl()
        {
            InitializeComponent();
            _title = "empty";
            _description = "empty";
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                titleLabel.Text = _title;
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                descriptionLabel.Text = _description;
            }
        }
        public DateTime DateTime
        {
            get { return _dateTime; }
            set
            {
                _dateTime = value;
                dateLabel.Text = (_dateTime.Month.ToString() + '/' + _dateTime.Day.ToString() + '/' + _dateTime.Year.ToString());
                /*
                if (_dateTime.Hour > 12)
                {
                    _dateTime = _dateTime.AddHours(-12);
                    pm = "pm";
                }
                */
                timeLabel.Text = _dateTime.ToString("hh:mm:ss tt");
            }
        }
    }
}
