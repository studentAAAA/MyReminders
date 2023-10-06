namespace MyReminders
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            titleLabel = new Label();
            titleTextBox = new TextBox();
            descriptionLabel = new Label();
            descriptionTextBox = new TextBox();
            dateLabel = new Label();
            timeLabel = new Label();
            yearComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            dayComboBox = new ComboBox();
            hourComboBox = new ComboBox();
            minuteComboBox = new ComboBox();
            secondComboBox = new ComboBox();
            addButton = new Button();
            cancelButton = new Button();
            pmCheckBox = new CheckBox();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(36, 34);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(42, 21);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(125, 34);
            titleTextBox.MaxLength = 75;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(414, 23);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(12, 149);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(92, 21);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(125, 127);
            descriptionTextBox.MaxLength = 200;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(414, 23);
            descriptionTextBox.TabIndex = 3;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(33, 287);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(45, 21);
            dateLabel.TabIndex = 4;
            dateLabel.Text = "Date:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(31, 342);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(47, 21);
            timeLabel.TabIndex = 5;
            timeLabel.Text = "Time:";
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(125, 285);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(121, 23);
            yearComboBox.TabIndex = 6;
            yearComboBox.Text = "Year";
            yearComboBox.SelectedIndexChanged += yearComboBox_SelectedIndexChanged;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(288, 285);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(121, 23);
            monthComboBox.TabIndex = 7;
            monthComboBox.Text = "Month";
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            monthComboBox.TextUpdate += monthComboBox_TextUpdate;
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Location = new Point(451, 285);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(121, 23);
            dayComboBox.TabIndex = 8;
            dayComboBox.Text = "Day";
            // 
            // hourComboBox
            // 
            hourComboBox.FormattingEnabled = true;
            hourComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            hourComboBox.Location = new Point(125, 340);
            hourComboBox.Name = "hourComboBox";
            hourComboBox.Size = new Size(121, 23);
            hourComboBox.TabIndex = 9;
            hourComboBox.Text = "Hour";
            // 
            // minuteComboBox
            // 
            minuteComboBox.FormattingEnabled = true;
            minuteComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            minuteComboBox.Location = new Point(288, 340);
            minuteComboBox.Name = "minuteComboBox";
            minuteComboBox.Size = new Size(121, 23);
            minuteComboBox.TabIndex = 10;
            minuteComboBox.Text = "Minute";
            // 
            // secondComboBox
            // 
            secondComboBox.FormattingEnabled = true;
            secondComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            secondComboBox.Location = new Point(451, 340);
            secondComboBox.Name = "secondComboBox";
            secondComboBox.Size = new Size(121, 23);
            secondComboBox.TabIndex = 11;
            secondComboBox.Text = "Second";
            // 
            // addButton
            // 
            addButton.Location = new Point(220, 387);
            addButton.Name = "addButton";
            addButton.Size = new Size(96, 51);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(349, 387);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(96, 51);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // pmCheckBox
            // 
            pmCheckBox.AutoSize = true;
            pmCheckBox.Location = new Point(51, 404);
            pmCheckBox.Name = "pmCheckBox";
            pmCheckBox.Size = new Size(44, 19);
            pmCheckBox.TabIndex = 14;
            pmCheckBox.Text = "PM";
            pmCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(242, 456);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(141, 15);
            errorLabel.TabIndex = 15;
            errorLabel.Text = "Please fill out all columns";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 491);
            Controls.Add(errorLabel);
            Controls.Add(pmCheckBox);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(secondComboBox);
            Controls.Add(minuteComboBox);
            Controls.Add(hourComboBox);
            Controls.Add(dayComboBox);
            Controls.Add(monthComboBox);
            Controls.Add(yearComboBox);
            Controls.Add(timeLabel);
            Controls.Add(dateLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(titleTextBox);
            Controls.Add(titleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(663, 530);
            MinimumSize = new Size(663, 530);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox titleTextBox;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private Label dateLabel;
        private Label timeLabel;
        private ComboBox yearComboBox;
        private ComboBox monthComboBox;
        private ComboBox dayComboBox;
        private ComboBox hourComboBox;
        private ComboBox minuteComboBox;
        private ComboBox secondComboBox;
        private Button addButton;
        private Button cancelButton;
        private CheckBox pmCheckBox;
        private Label errorLabel;
    }
}