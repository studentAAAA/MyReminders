using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyReminders
{
    public partial class AddForm : Form
    {
        List<int> yearList = new List<int>();
        List<string> monthList = new List<string>();
        BindingList<int> dayList = new BindingList<int>();
        bool leapYear;
        List<Reminder> importedReminders;
        bool titleError = false;

        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public bool PM { get; set; }

        public AddForm(List<Reminder> reminders)
        {
            InitializeComponent();
            errorLabel.Hide();
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
        private void monthComboBox_TextUpdate(object sender, EventArgs e)
        {
            /*
            if (monthComboBox.SelectedIndex == 0)
            {
                for (int i = 1; i < 30; i++)
                {
                    dayList.Add(i);
                }
            }
            */
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDays();
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

        private void dayComboBox_Click(object sender, EventArgs e)
        {
            //
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

        private void dayComboBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dayComboBox_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            titleError = false;
            foreach (Reminder reminder in importedReminders)
            {
                if (titleTextBox.Text == reminder.Title)
                {
                    titleError = true;
                }
            }
            if (titleTextBox.Text == "" || descriptionTextBox.Text == "" || yearComboBox.SelectedIndex == null || monthComboBox.SelectedIndex == null || dayComboBox.SelectedIndex == null || hourComboBox.SelectedIndex == null || minuteComboBox.SelectedIndex == null || secondComboBox.SelectedIndex == null)
            {
                errorLabel.Text = "Please fill out all columns";
                errorLabel.Show();
            }
            if (titleError == true)
            {
                errorLabel.Text = "Title shares the name of another title";
                errorLabel.Show();
            }
            else
            {
                Title = titleTextBox.Text;
                Description = descriptionTextBox.Text;
                Year = (int)yearComboBox.SelectedItem;
                Month = monthComboBox.SelectedIndex;
                Day = (int)dayComboBox.SelectedItem;
                Hour = int.Parse(hourComboBox.SelectedItem.ToString());
                Minute = int.Parse(minuteComboBox.SelectedItem.ToString());
                Second = int.Parse(secondComboBox.SelectedItem.ToString());
                PM = pmCheckBox.Checked;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
