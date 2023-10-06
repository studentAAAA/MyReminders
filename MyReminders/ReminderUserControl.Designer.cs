namespace MyReminders
{
    partial class ReminderUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            descriptionLabel = new Label();
            dateLabel = new Label();
            timeLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(3, 5);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(22, 12);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(3, 42);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(76, 57);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(3, 99);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(24, 12);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(3, 122);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(25, 12);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "Time";
            // 
            // ReminderUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeLabel);
            Controls.Add(dateLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Name = "ReminderUserControl";
            Size = new Size(82, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private Label dateLabel;
        private Label timeLabel;
    }
}
