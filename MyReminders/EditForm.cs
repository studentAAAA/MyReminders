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
    public partial class EditForm : Form
    {
        List<int> yearList = new List<int>();
        List<string> monthList = new List<string>();
        BindingList<int> dayList = new BindingList<int>();
        bool leapYear;
        List<Reminder> importedReminders;
        string searchTitle;
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public bool PM { get; set; }
        public List<Reminder> changedReminders { get; set; }
        public EditForm(List<Reminder> reminders)
        {
            InitializeComponent();
            errorLabel.Hide();
            titleLabel.Hide();
            titleTextBox.Hide();
            descriptionLabel.Hide();
            descriptionTextBox.Hide();
            dateLabel.Hide();
            yearComboBox.Hide();
            monthComboBox.Hide();
            dayComboBox.Hide();
            timeLabel.Hide();
            hourComboBox.Hide();
            minuteComboBox.Hide();
            secondComboBox.Hide();
            pmCheckBox.Hide();
            addButton.Hide();
            cancelButton.Hide();
            enterTitleLabelError.Hide();
            descriptionTextBox.AutoSize = false;
            descriptionTextBox.Size = new System.Drawing.Size(descriptionTextBox.Size.Width, 65);
            List<int> yearList = new List<int>();
            List<int> dayList = new List<int>();
            importedReminders = reminders;
            for (int i = 0; i < 122; i++)
            {
                yearList.Add(DateTime.Today.Year + i);
            }
            yearComboBox.DataSource = yearList;
            if (DateTime.Today.Year % 4 == 0)
            {
                leapYear = true;
            }
            else
            {
                leapYear = false;
            }
        }

        private void UpdateDays()
        {
            dayList.Clear();

            if (monthComboBox.SelectedIndex == 0) //31 days for January
            {
                for (int i = 1; i < 32; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 1)//28 days for Feburary (unless its a leap year, then its 29)
            {
                int selectedYear = (int)yearComboBox.SelectedValue;
                for (int i = 1; i < 29; i++)
                {
                    dayList.Add(i);
                }
                if (leapYear == true)
                {
                    dayList.Add(29);
                }
            }
            else if (monthComboBox.SelectedIndex == 2) //31 days for March
            {
                for (int i = 1; i < 32; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 3) //30 days for April
            {
                for (int i = 1; i < 31; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 4) //31 days for May
            {
                for (int i = 1; i < 32; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 5) //30 days for June
            {
                for (int i = 1; i < 31; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 6) //31 days for July
            {
                for (int i = 1; i < 32; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 7) //31 days for August
            {
                for (int i = 1; i < 32; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 8) //30 days for September
            {
                for (int i = 1; i < 31; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 9) //31 days for October
            {
                for (int i = 1; i < 32; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 10) //30 days for November
            {
                for (int i = 1; i < 31; i++)
                {
                    dayList.Add(i);
                }
            }
            else if (monthComboBox.SelectedIndex == 11) //31 days for December
            {
                for (int i = 1; i < 32; i++)
                {
                    dayList.Add(i);
                }
            }
            // Set the updated dayList as the data source for dayComboBox
            dayComboBox.DataSource = dayList;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDays();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "" || descriptionTextBox.Text == "" || yearComboBox.SelectedIndex == null || monthComboBox.SelectedIndex == null || dayComboBox.SelectedIndex == null || hourComboBox.SelectedIndex == null || minuteComboBox.SelectedIndex == null || secondComboBox.SelectedIndex == null)
            {
                errorLabel.Show();
            }
            else
            {
                Title = titleTextBox.Text;
                Description = descriptionTextBox.Text;
                Year = (int)yearComboBox.SelectedItem;
                Month = monthComboBox.SelectedIndex;
                Day = int.Parse(dayComboBox.SelectedItem.ToString());
                Hour = int.Parse(hourComboBox.SelectedItem.ToString());
                Minute = int.Parse(minuteComboBox.SelectedItem.ToString());
                Second = int.Parse(secondComboBox.SelectedItem.ToString());
                PM = pmCheckBox.Checked;
                foreach (Reminder reminder in importedReminders)
                {
                    if (reminder.Title == searchTitle)
                    {
                        reminder.Title = Title;
                        reminder.Description = Description;
                        reminder.DateTime = new DateTime(Year, Month+1, Day, Hour, Minute, Second);
                        if (PM == true)
                        {
                            reminder.DateTime = reminder.DateTime.AddHours(12);
                        }
                        changedReminders = importedReminders;
                    }
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedYear = (int)yearComboBox.SelectedValue;
            if (selectedYear % 4 == 0)
            {
                leapYear = true;
            }
            else
            {
                leapYear = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (importedReminders == null)
            {
                return;
            }
            else
            {
                foreach (Reminder reminder in importedReminders)
                {
                    if (reminder.Title == enterTitleTextBox.Text.ToString())
                    {
                        searchTitle = reminder.Title;
                        enterTitleLabelError.Hide();
                        enterTitleLabel.Hide();
                        enterTitleTextBox.Hide();
                        searchButton.Hide();
                        titleLabel.Show();
                        titleTextBox.Show();
                        descriptionLabel.Show();
                        descriptionTextBox.Show();
                        dateLabel.Show();
                        yearComboBox.Show();
                        monthComboBox.Show();
                        dayComboBox.Show();
                        timeLabel.Show();
                        hourComboBox.Show();
                        minuteComboBox.Show();
                        secondComboBox.Show();
                        pmCheckBox.Show();
                        addButton.Show();
                        cancelButton.Show();
                        titleTextBox.Text = reminder.Title;
                        descriptionTextBox.Text = reminder.Description;
                        yearComboBox.Text = reminder.DateTime.Year.ToString();
                        monthComboBox.SelectedIndex = int.Parse(reminder.DateTime.Month.ToString())-1;
                        dayComboBox.Text = reminder.DateTime.Day.ToString();
                        if (reminder.DateTime.Hour > 12)
                        {
                            pmCheckBox.Checked = true;
                            hourComboBox.Text = reminder.DateTime.AddHours(-12).Hour.ToString();
                        }
                        else
                        {
                            pmCheckBox.Checked = false;
                            hourComboBox.Text = reminder.DateTime.Hour.ToString();
                        }
                        minuteComboBox.Text = reminder.DateTime.Minute.ToString();
                        secondComboBox.Text = reminder.DateTime.Second.ToString();
                        return;
                    }
                }
                enterTitleLabelError.Show();
            }
        }
    }
}
