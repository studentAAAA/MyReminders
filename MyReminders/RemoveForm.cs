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
    public partial class RemoveForm : Form
    {
        List<Reminder> importedReminders;
        public List<Reminder> ChangedReminders { get; set; }
        public RemoveForm(List<Reminder> reminders)
        {
            InitializeComponent();
            errorLabel.Hide();
            importedReminders = reminders;
            ChangedReminders = reminders;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < importedReminders.Count; i++)
            {
                if (importedReminders[i].Title == searchTextBox.Text)
                {
                    ChangedReminders.Remove(importedReminders[i]);
                    DialogResult = DialogResult.OK;
                }
            }
            errorLabel.Show();
        }
    }
}
