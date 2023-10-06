using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
namespace MyReminders
{
    public partial class Form1 : Form
    {
        string title;
        string description;
        DateTime reminderDate = new DateTime();
        bool PM;
        List<Reminder> reminders = new List<Reminder>();
        private System.Windows.Forms.Timer reminderTimer;
        private int dayOffset = 0;
        static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string filePath = Path.Combine(documentsPath, "reminders.json");
        public Form1()
        {
            InitializeComponent();
            labelDay1.Text = DateTime.Today.DayOfWeek.ToString();
            labelDay1.Location = adjustOffset(labelDay1, 0).Location;
            dateLabel1.Text = (DateTime.Today.Month.ToString() + '/' + DateTime.Today.Day.ToString()).ToString();
            labelDay2.Text = DateTime.Today.AddDays(1).DayOfWeek.ToString();
            labelDay2.Location = adjustOffset(labelDay2, 1).Location;
            dateLabel2.Text = (DateTime.Today.AddDays(1).Month.ToString() + '/' + DateTime.Today.AddDays(1).Day.ToString()).ToString();
            labelDay3.Text = DateTime.Today.AddDays(2).DayOfWeek.ToString();
            labelDay3.Location = adjustOffset(labelDay3, 2).Location;
            dateLabel3.Text = (DateTime.Today.AddDays(2).Month.ToString() + '/' + DateTime.Today.AddDays(2).Day.ToString()).ToString();
            labelDay4.Text = DateTime.Today.AddDays(3).DayOfWeek.ToString();
            labelDay4.Location = adjustOffset(labelDay4, 3).Location;
            dateLabel4.Text = (DateTime.Today.AddDays(3).Month.ToString() + '/' + DateTime.Today.AddDays(3).Day.ToString()).ToString();
            labelDay5.Text = DateTime.Today.AddDays(4).DayOfWeek.ToString();
            labelDay5.Location = adjustOffset(labelDay5, 4).Location;
            dateLabel5.Text = (DateTime.Today.AddDays(4).Month.ToString() + '/' + DateTime.Today.AddDays(4).Day.ToString()).ToString();
            labelDay6.Text = DateTime.Today.AddDays(5).DayOfWeek.ToString();
            labelDay6.Location = adjustOffset(labelDay6, 5).Location;
            dateLabel6.Text = (DateTime.Today.AddDays(5).Month.ToString() + '/' + DateTime.Today.AddDays(5).Day.ToString()).ToString();
            labelDay7.Text = DateTime.Today.AddDays(6).DayOfWeek.ToString();
            labelDay7.Location = adjustOffset(labelDay7, 6).Location;
            dateLabel7.Text = (DateTime.Today.AddDays(6).Month.ToString() + '/' + DateTime.Today.AddDays(6).Day.ToString()).ToString();
            if (File.Exists(filePath))
            {
                string serializedData = File.ReadAllText(filePath);
                reminders = JsonConvert.DeserializeObject<List<Reminder>>(serializedData);
                populateItems();
            }
            else
            {
                // Do nothing
            }
            reminderTimer = new System.Windows.Forms.Timer();
            reminderTimer.Tick += new EventHandler(ReminderTimer_Tick);
            reminderTimer.Interval = 1000; // Interval in milliseconds (e.g., 1000ms = 1 second)
            reminderTimer.Start();
        }

        private Label adjustOffset(Label label, int daysToAdd) // dates aren't always centered and look bad, so i just arrange them in the same spot in accordance to the day label and adjust their offset based on numbers I have tested
        {
            if (DateTime.Today.AddDays(daysToAdd).DayOfWeek.ToString() == "Tuesday")
            {
                label.Location = new System.Drawing.Point(label.Location.X - 5, label.Location.Y); //-5x
                return label;
            }
            else if (DateTime.Today.AddDays(daysToAdd).DayOfWeek.ToString() == "Wednesday")
            {
                label.Location = new System.Drawing.Point(label.Location.X - 15, label.Location.Y); //-15x
                return label;
            }
            else if (DateTime.Today.AddDays(daysToAdd).DayOfWeek.ToString() == "Thursday")
            {
                label.Location = new System.Drawing.Point(label.Location.X - 5, label.Location.Y); //-5x
                return label;
            }
            else if (DateTime.Today.AddDays(daysToAdd).DayOfWeek.ToString() == "Friday")
            {
                label.Location = new System.Drawing.Point(label.Location.X + 8, label.Location.Y); //+8x
                return label;
            }
            else if (DateTime.Today.AddDays(daysToAdd).DayOfWeek.ToString() == "Saturday")
            {
                label.Location = new System.Drawing.Point(label.Location.X - 5, label.Location.Y); //-5x
                return label;
            }
            else if (DateTime.Today.AddDays(daysToAdd).DayOfWeek.ToString() == "Monday")
            {
                label.Location = new System.Drawing.Point(label.Location.X, label.Location.Y);
                return label;
            }
            else if (DateTime.Today.AddDays(daysToAdd).DayOfWeek.ToString() == "Sunday")
            {
                label.Location = new System.Drawing.Point(label.Location.X, label.Location.Y);
                return label;
            }
            else
            {
                label.Text = "Error: Invalid Day of The Week";
                return label;
            }

        }
        private void labelDay2_Click(object sender, EventArgs e)
        {

        }

        private void labelDay5_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(reminders);
            DialogResult response = addForm.ShowDialog();
            if (response == DialogResult.OK)
            {
                title = addForm.Title;
                description = addForm.Description;
                reminderDate = new DateTime(addForm.Year, addForm.Month + 1, addForm.Day, addForm.Hour, addForm.Minute, addForm.Second);
                /*
                reminderDate.AddYears(addForm.Year);
                reminderDate.AddMonths(addForm.Month+1); // +1 because the addForm month property takes an int which is the selected index of the add form, which starts at 0 yada yada
                reminderDate.AddDays(addForm.Day);
                reminderDate.AddHours(addForm.Hour);
                */
                PM = addForm.PM;
                if (PM == true)
                {
                    reminderDate = reminderDate.AddHours(12);
                }
                /*
                reminderDate.AddMinutes(addForm.Minute);
                reminderDate.AddSeconds(addForm.Second);
                */
                Reminder placeHolderReminder = new Reminder(title, description, reminderDate);
                reminders.Add(placeHolderReminder);
                populateItems();
            }
            if (response == DialogResult.Cancel)
            {

            }
        }

        /*
        void populateItems()
        {
            for (int i = 0; i < 7; i++)
            {
                if (reminderDate.Day == DateTime.Today.AddDays(i + dayOffset).Day)
                {
                    if (i == 0)
                    {
                        ReminderUserControl reminderUserControl = new ReminderUserControl();
                        reminderUserControl.Title = title;
                        reminderUserControl.Description = description;
                        reminderUserControl.DateTime = reminderDate;
                        day1FlowLayoutPanel.Controls.Add(reminderUserControl);
                    }
                    else if (i == 1)
                    {
                        ReminderUserControl reminderUserControl = new ReminderUserControl();
                        reminderUserControl.Title = title;
                        reminderUserControl.Description = description;
                        reminderUserControl.DateTime = reminderDate;
                        day2FlowLayoutPanel.Controls.Add(reminderUserControl);
                    }
                    else if (i == 2)
                    {
                        ReminderUserControl reminderUserControl = new ReminderUserControl();
                        reminderUserControl.Title = title;
                        reminderUserControl.Description = description;
                        reminderUserControl.DateTime = reminderDate;
                        day3FlowLayoutPanel.Controls.Add(reminderUserControl);
                    }
                    else if (i == 3)
                    {
                        ReminderUserControl reminderUserControl = new ReminderUserControl();
                        reminderUserControl.Title = title;
                        reminderUserControl.Description = description;
                        reminderUserControl.DateTime = reminderDate;
                        day4FlowLayoutPanel.Controls.Add(reminderUserControl);
                    }
                    else if (i == 4)
                    {
                        ReminderUserControl reminderUserControl = new ReminderUserControl();
                        reminderUserControl.Title = title;
                        reminderUserControl.Description = description;
                        reminderUserControl.DateTime = reminderDate;
                        day5FlowLayoutPanel.Controls.Add(reminderUserControl);
                    }
                    else if (i == 5)
                    {
                        ReminderUserControl reminderUserControl = new ReminderUserControl();
                        reminderUserControl.Title = title;
                        reminderUserControl.Description = description;
                        reminderUserControl.DateTime = reminderDate;
                        day6FlowLayoutPanel.Controls.Add(reminderUserControl);
                    }
                    else if (i == 6)
                    {
                        ReminderUserControl reminderUserControl = new ReminderUserControl();
                        reminderUserControl.Title = title;
                        reminderUserControl.Description = description;
                        reminderUserControl.DateTime = reminderDate;
                        day7FlowLayoutPanel.Controls.Add(reminderUserControl);
                    }
                    else
                    {
                        // Do nothing
                    }
                }
            }
        }
        */
        void populateItems()
        {
            // Clear all FlowLayoutPanel controls
            day1FlowLayoutPanel.Controls.Clear();
            day2FlowLayoutPanel.Controls.Clear();
            day3FlowLayoutPanel.Controls.Clear();
            day4FlowLayoutPanel.Controls.Clear();
            day5FlowLayoutPanel.Controls.Clear();
            day6FlowLayoutPanel.Controls.Clear();
            day7FlowLayoutPanel.Controls.Clear();

            DateTime startDate = DateTime.Today.AddDays(dayOffset);
            DateTime endDate = DateTime.Today.AddDays(dayOffset + 6).AddHours(23).AddMinutes(59).AddSeconds(59);

            foreach (var reminder in reminders)
            {
                if (reminder.DateTime >= startDate && reminder.DateTime <= endDate)
                {
                    int dayIndex = (int)(reminder.DateTime - startDate).TotalDays;
                    if (dayIndex >= 0 && dayIndex < 7)
                    {
                        ReminderUserControl reminderUserControl = new ReminderUserControl();
                        reminderUserControl.Title = reminder.Title;
                        reminderUserControl.Description = reminder.Description;
                        reminderUserControl.DateTime = reminder.DateTime;

                        switch (dayIndex)
                        {
                            case 0:
                                day1FlowLayoutPanel.Controls.Add(reminderUserControl);
                                break;
                            case 1:
                                day2FlowLayoutPanel.Controls.Add(reminderUserControl);
                                break;
                            case 2:
                                day3FlowLayoutPanel.Controls.Add(reminderUserControl);
                                break;
                            case 3:
                                day4FlowLayoutPanel.Controls.Add(reminderUserControl);
                                break;
                            case 4:
                                day5FlowLayoutPanel.Controls.Add(reminderUserControl);
                                break;
                            case 5:
                                day6FlowLayoutPanel.Controls.Add(reminderUserControl);
                                break;
                            case 6:
                                day7FlowLayoutPanel.Controls.Add(reminderUserControl);
                                break;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // save stuff here idk

            List<Reminder> remindersToSerialize = reminders.Select(p => new Reminder
            {
                Title = p.Title,
                Description = p.Description,
                DateTime = p.DateTime,
            }).ToList();

            string serializedData = JsonConvert.SerializeObject(remindersToSerialize);
            File.WriteAllText(filePath, serializedData);
        }

        void ShowNotification(string title, string description)
        {
            reminderIcon.Text = "Reminder";
            reminderIcon.Visible = true;
            reminderIcon.BalloonTipTitle = title;
            reminderIcon.BalloonTipText = description;
            reminderIcon.ShowBalloonTip(100);
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            for (int i = reminders.Count - 1; i >= 0; i--)
            {
                Reminder reminder = reminders[i];
                if (reminder.DateTime <= DateTime.Now)
                {
                    ShowNotification(reminder.Title, reminder.Description);
                    reminders.RemoveAt(i);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(reminders);
            DialogResult response = editForm.ShowDialog();
            if (response == DialogResult.OK)
            {
                reminders = editForm.changedReminders;
                populateItems();
            }
            if (response == DialogResult.Cancel)
            {

            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            dayOffset += 7;
            dateLabel1.Text = (DateTime.Today.AddDays(dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(dayOffset).Day.ToString()).ToString();
            dateLabel2.Text = (DateTime.Today.AddDays(1 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(1 + dayOffset).Day.ToString()).ToString();
            dateLabel3.Text = (DateTime.Today.AddDays(2 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(2 + dayOffset).Day.ToString()).ToString();
            dateLabel4.Text = (DateTime.Today.AddDays(3 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(3 + dayOffset).Day.ToString()).ToString();
            dateLabel5.Text = (DateTime.Today.AddDays(4 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(4 + dayOffset).Day.ToString()).ToString();
            dateLabel6.Text = (DateTime.Today.AddDays(5 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(5 + dayOffset).Day.ToString()).ToString();
            dateLabel7.Text = (DateTime.Today.AddDays(6 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(6 + dayOffset).Day.ToString()).ToString();
            populateItems();
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            dayOffset -= 7;
            dateLabel1.Text = (DateTime.Today.AddDays(dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(dayOffset).Day.ToString()).ToString();
            dateLabel2.Text = (DateTime.Today.AddDays(1 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(1 + dayOffset).Day.ToString()).ToString();
            dateLabel3.Text = (DateTime.Today.AddDays(2 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(2 + dayOffset).Day.ToString()).ToString();
            dateLabel4.Text = (DateTime.Today.AddDays(3 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(3 + dayOffset).Day.ToString()).ToString();
            dateLabel5.Text = (DateTime.Today.AddDays(4 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(4 + dayOffset).Day.ToString()).ToString();
            dateLabel6.Text = (DateTime.Today.AddDays(5 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(5 + dayOffset).Day.ToString()).ToString();
            dateLabel7.Text = (DateTime.Today.AddDays(6 + dayOffset).Month.ToString() + '/' + DateTime.Today.AddDays(6 + dayOffset).Day.ToString()).ToString();
            populateItems();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm(reminders);
            DialogResult response = removeForm.ShowDialog();
            if (response == DialogResult.OK)
            {
                reminders = removeForm.ChangedReminders;
                populateItems();
            }
        }
    }
}