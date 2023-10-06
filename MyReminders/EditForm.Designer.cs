namespace MyReminders
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            errorLabel = new Label();
            pmCheckBox = new CheckBox();
            cancelButton = new Button();
            addButton = new Button();
            secondComboBox = new ComboBox();
            minuteComboBox = new ComboBox();
            hourComboBox = new ComboBox();
            dayComboBox = new ComboBox();
            monthComboBox = new ComboBox();
            yearComboBox = new ComboBox();
            timeLabel = new Label();
            dateLabel = new Label();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            titleTextBox = new TextBox();
            titleLabel = new Label();
            enterTitleLabel = new Label();
            enterTitleTextBox = new TextBox();
            searchButton = new Button();
            enterTitleLabelError = new Label();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(242, 448);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(141, 15);
            errorLabel.TabIndex = 31;
            errorLabel.Text = "Please fill out all columns";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pmCheckBox
            // 
            pmCheckBox.AutoSize = true;
            pmCheckBox.Location = new Point(82, 397);
            pmCheckBox.Name = "pmCheckBox";
            pmCheckBox.Size = new Size(44, 19);
            pmCheckBox.TabIndex = 30;
            pmCheckBox.Text = "PM";
            pmCheckBox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(333, 380);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(96, 51);
            cancelButton.TabIndex = 29;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(204, 380);
            addButton.Name = "addButton";
            addButton.Size = new Size(96, 51);
            addButton.TabIndex = 28;
            addButton.Text = "Edit";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // secondComboBox
            // 
            secondComboBox.FormattingEnabled = true;
            secondComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            secondComboBox.Location = new Point(482, 333);
            secondComboBox.Name = "secondComboBox";
            secondComboBox.Size = new Size(121, 23);
            secondComboBox.TabIndex = 27;
            secondComboBox.Text = "Second";
            // 
            // minuteComboBox
            // 
            minuteComboBox.FormattingEnabled = true;
            minuteComboBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59" });
            minuteComboBox.Location = new Point(319, 333);
            minuteComboBox.Name = "minuteComboBox";
            minuteComboBox.Size = new Size(121, 23);
            minuteComboBox.TabIndex = 26;
            minuteComboBox.Text = "Minute";
            // 
            // hourComboBox
            // 
            hourComboBox.FormattingEnabled = true;
            hourComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            hourComboBox.Location = new Point(156, 333);
            hourComboBox.Name = "hourComboBox";
            hourComboBox.Size = new Size(121, 23);
            hourComboBox.TabIndex = 25;
            hourComboBox.Text = "Hour";
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.Location = new Point(482, 278);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.Size = new Size(121, 23);
            dayComboBox.TabIndex = 24;
            dayComboBox.Text = "Day";
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthComboBox.Location = new Point(319, 278);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(121, 23);
            monthComboBox.TabIndex = 23;
            monthComboBox.Text = "Month";
            monthComboBox.SelectedIndexChanged += monthComboBox_SelectedIndexChanged;
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(156, 278);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(121, 23);
            yearComboBox.TabIndex = 22;
            yearComboBox.Text = "Year";
            yearComboBox.SelectedIndexChanged += yearComboBox_SelectedIndexChanged;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(62, 335);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(47, 21);
            timeLabel.TabIndex = 21;
            timeLabel.Text = "Time:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(64, 280);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(45, 21);
            dateLabel.TabIndex = 20;
            dateLabel.Text = "Date:";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(156, 120);
            descriptionTextBox.MaxLength = 200;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(414, 23);
            descriptionTextBox.TabIndex = 19;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(43, 142);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(92, 21);
            descriptionLabel.TabIndex = 18;
            descriptionLabel.Text = "Description:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(156, 27);
            titleTextBox.MaxLength = 75;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(414, 23);
            titleTextBox.TabIndex = 17;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(67, 27);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(42, 21);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "Title:";
            // 
            // enterTitleLabel
            // 
            enterTitleLabel.AutoSize = true;
            enterTitleLabel.Location = new Point(180, 178);
            enterTitleLabel.Name = "enterTitleLabel";
            enterTitleLabel.Size = new Size(144, 15);
            enterTitleLabel.TabIndex = 32;
            enterTitleLabel.Text = "Enter Title (case sensitive):";
            // 
            // enterTitleTextBox
            // 
            enterTitleTextBox.Location = new Point(340, 175);
            enterTitleTextBox.Name = "enterTitleTextBox";
            enterTitleTextBox.Size = new Size(100, 23);
            enterTitleTextBox.TabIndex = 33;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(272, 204);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 34;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // enterTitleLabelError
            // 
            enterTitleLabelError.AutoSize = true;
            enterTitleLabelError.ForeColor = Color.Red;
            enterTitleLabelError.Location = new Point(257, 239);
            enterTitleLabelError.Name = "enterTitleLabelError";
            enterTitleLabelError.Size = new Size(114, 15);
            enterTitleLabelError.TabIndex = 35;
            enterTitleLabelError.Text = "Reminder not found";
            enterTitleLabelError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 491);
            Controls.Add(enterTitleLabelError);
            Controls.Add(searchButton);
            Controls.Add(enterTitleTextBox);
            Controls.Add(enterTitleLabel);
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
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
        private CheckBox pmCheckBox;
        private Button cancelButton;
        private Button addButton;
        private ComboBox secondComboBox;
        private ComboBox minuteComboBox;
        private ComboBox hourComboBox;
        private ComboBox dayComboBox;
        private ComboBox monthComboBox;
        private ComboBox yearComboBox;
        private Label timeLabel;
        private Label dateLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox titleTextBox;
        private Label titleLabel;
        private Label enterTitleLabel;
        private TextBox enterTitleTextBox;
        private Button searchButton;
        private Label enterTitleLabelError;
    }
}