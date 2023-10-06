namespace MyReminders
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            addButton = new Button();
            editButton = new Button();
            removeButton = new Button();
            labelDay1 = new Label();
            labelDay7 = new Label();
            labelDay2 = new Label();
            labelDay3 = new Label();
            labelDay4 = new Label();
            labelDay5 = new Label();
            labelDay6 = new Label();
            dateLabel1 = new Label();
            dateLabel2 = new Label();
            dateLabel3 = new Label();
            dateLabel4 = new Label();
            dateLabel5 = new Label();
            dateLabel6 = new Label();
            dateLabel7 = new Label();
            backwardButton = new Button();
            forwardButton = new Button();
            day1FlowLayoutPanel = new FlowLayoutPanel();
            day2FlowLayoutPanel = new FlowLayoutPanel();
            day3FlowLayoutPanel = new FlowLayoutPanel();
            day4FlowLayoutPanel = new FlowLayoutPanel();
            day5FlowLayoutPanel = new FlowLayoutPanel();
            day6FlowLayoutPanel = new FlowLayoutPanel();
            day7FlowLayoutPanel = new FlowLayoutPanel();
            reminderIcon = new NotifyIcon(components);
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(-1, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(85, 144);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Left;
            editButton.Location = new Point(-1, 140);
            editButton.Name = "editButton";
            editButton.Size = new Size(85, 144);
            editButton.TabIndex = 1;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(-1, 278);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(85, 144);
            removeButton.TabIndex = 2;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // labelDay1
            // 
            labelDay1.AutoSize = true;
            labelDay1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDay1.Location = new Point(100, 15);
            labelDay1.Name = "labelDay1";
            labelDay1.Size = new Size(47, 20);
            labelDay1.TabIndex = 3;
            labelDay1.Text = "Day 1";
            // 
            // labelDay7
            // 
            labelDay7.AutoSize = true;
            labelDay7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDay7.Location = new Point(630, 15);
            labelDay7.Name = "labelDay7";
            labelDay7.Size = new Size(47, 20);
            labelDay7.TabIndex = 4;
            labelDay7.Text = "Day 7";
            // 
            // labelDay2
            // 
            labelDay2.AutoSize = true;
            labelDay2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDay2.Location = new Point(189, 14);
            labelDay2.Name = "labelDay2";
            labelDay2.Size = new Size(47, 20);
            labelDay2.TabIndex = 5;
            labelDay2.Text = "Day 2";
            labelDay2.Click += labelDay2_Click;
            // 
            // labelDay3
            // 
            labelDay3.AutoSize = true;
            labelDay3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDay3.Location = new Point(278, 14);
            labelDay3.Name = "labelDay3";
            labelDay3.Size = new Size(47, 20);
            labelDay3.TabIndex = 6;
            labelDay3.Text = "Day 3";
            // 
            // labelDay4
            // 
            labelDay4.AutoSize = true;
            labelDay4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDay4.Location = new Point(365, 15);
            labelDay4.Name = "labelDay4";
            labelDay4.Size = new Size(47, 20);
            labelDay4.TabIndex = 7;
            labelDay4.Text = "Day 4";
            // 
            // labelDay5
            // 
            labelDay5.AutoSize = true;
            labelDay5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDay5.Location = new Point(455, 14);
            labelDay5.Name = "labelDay5";
            labelDay5.Size = new Size(47, 20);
            labelDay5.TabIndex = 8;
            labelDay5.Text = "Day 5";
            labelDay5.Click += labelDay5_Click;
            // 
            // labelDay6
            // 
            labelDay6.AutoSize = true;
            labelDay6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDay6.Location = new Point(544, 15);
            labelDay6.Name = "labelDay6";
            labelDay6.Size = new Size(47, 20);
            labelDay6.TabIndex = 9;
            labelDay6.Text = "Day 6";
            // 
            // dateLabel1
            // 
            dateLabel1.AutoSize = true;
            dateLabel1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel1.Location = new Point(111, 34);
            dateLabel1.Name = "dateLabel1";
            dateLabel1.Size = new Size(36, 13);
            dateLabel1.TabIndex = 10;
            dateLabel1.Text = "date1";
            // 
            // dateLabel2
            // 
            dateLabel2.AutoSize = true;
            dateLabel2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel2.Location = new Point(200, 34);
            dateLabel2.Name = "dateLabel2";
            dateLabel2.Size = new Size(36, 13);
            dateLabel2.TabIndex = 11;
            dateLabel2.Text = "date2";
            // 
            // dateLabel3
            // 
            dateLabel3.AutoSize = true;
            dateLabel3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel3.Location = new Point(289, 34);
            dateLabel3.Name = "dateLabel3";
            dateLabel3.Size = new Size(36, 13);
            dateLabel3.TabIndex = 12;
            dateLabel3.Text = "date3";
            // 
            // dateLabel4
            // 
            dateLabel4.AutoSize = true;
            dateLabel4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel4.Location = new Point(376, 34);
            dateLabel4.Name = "dateLabel4";
            dateLabel4.Size = new Size(36, 13);
            dateLabel4.TabIndex = 13;
            dateLabel4.Text = "date4";
            // 
            // dateLabel5
            // 
            dateLabel5.AutoSize = true;
            dateLabel5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel5.Location = new Point(466, 34);
            dateLabel5.Name = "dateLabel5";
            dateLabel5.Size = new Size(36, 13);
            dateLabel5.TabIndex = 14;
            dateLabel5.Text = "date5";
            // 
            // dateLabel6
            // 
            dateLabel6.AutoSize = true;
            dateLabel6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel6.Location = new Point(555, 34);
            dateLabel6.Name = "dateLabel6";
            dateLabel6.Size = new Size(36, 13);
            dateLabel6.TabIndex = 15;
            dateLabel6.Text = "date6";
            // 
            // dateLabel7
            // 
            dateLabel7.AutoSize = true;
            dateLabel7.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel7.Location = new Point(641, 34);
            dateLabel7.Name = "dateLabel7";
            dateLabel7.Size = new Size(36, 13);
            dateLabel7.TabIndex = 16;
            dateLabel7.Text = "date7";
            // 
            // backwardButton
            // 
            backwardButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            backwardButton.Location = new Point(718, 0);
            backwardButton.Name = "backwardButton";
            backwardButton.Size = new Size(75, 221);
            backwardButton.TabIndex = 17;
            backwardButton.Text = "Back";
            backwardButton.UseVisualStyleBackColor = true;
            backwardButton.Click += backwardButton_Click;
            // 
            // forwardButton
            // 
            forwardButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            forwardButton.Location = new Point(718, 218);
            forwardButton.Name = "forwardButton";
            forwardButton.Size = new Size(75, 204);
            forwardButton.TabIndex = 18;
            forwardButton.Text = "Forward";
            forwardButton.UseVisualStyleBackColor = true;
            forwardButton.Click += forwardButton_Click;
            // 
            // day1FlowLayoutPanel
            // 
            day1FlowLayoutPanel.AutoScroll = true;
            day1FlowLayoutPanel.Location = new Point(90, 50);
            day1FlowLayoutPanel.Name = "day1FlowLayoutPanel";
            day1FlowLayoutPanel.Size = new Size(82, 359);
            day1FlowLayoutPanel.TabIndex = 19;
            // 
            // day2FlowLayoutPanel
            // 
            day2FlowLayoutPanel.AutoScroll = true;
            day2FlowLayoutPanel.Location = new Point(178, 50);
            day2FlowLayoutPanel.Name = "day2FlowLayoutPanel";
            day2FlowLayoutPanel.Size = new Size(82, 359);
            day2FlowLayoutPanel.TabIndex = 20;
            // 
            // day3FlowLayoutPanel
            // 
            day3FlowLayoutPanel.AutoScroll = true;
            day3FlowLayoutPanel.Location = new Point(267, 50);
            day3FlowLayoutPanel.Name = "day3FlowLayoutPanel";
            day3FlowLayoutPanel.Size = new Size(82, 359);
            day3FlowLayoutPanel.TabIndex = 21;
            // 
            // day4FlowLayoutPanel
            // 
            day4FlowLayoutPanel.AutoScroll = true;
            day4FlowLayoutPanel.Location = new Point(355, 50);
            day4FlowLayoutPanel.Name = "day4FlowLayoutPanel";
            day4FlowLayoutPanel.Size = new Size(82, 359);
            day4FlowLayoutPanel.TabIndex = 22;
            // 
            // day5FlowLayoutPanel
            // 
            day5FlowLayoutPanel.AutoScroll = true;
            day5FlowLayoutPanel.Location = new Point(443, 50);
            day5FlowLayoutPanel.Name = "day5FlowLayoutPanel";
            day5FlowLayoutPanel.Size = new Size(82, 359);
            day5FlowLayoutPanel.TabIndex = 23;
            // 
            // day6FlowLayoutPanel
            // 
            day6FlowLayoutPanel.AutoScroll = true;
            day6FlowLayoutPanel.Location = new Point(531, 50);
            day6FlowLayoutPanel.Name = "day6FlowLayoutPanel";
            day6FlowLayoutPanel.Size = new Size(82, 359);
            day6FlowLayoutPanel.TabIndex = 24;
            // 
            // day7FlowLayoutPanel
            // 
            day7FlowLayoutPanel.AutoScroll = true;
            day7FlowLayoutPanel.Location = new Point(619, 50);
            day7FlowLayoutPanel.Name = "day7FlowLayoutPanel";
            day7FlowLayoutPanel.Size = new Size(82, 359);
            day7FlowLayoutPanel.TabIndex = 25;
            // 
            // reminderIcon
            // 
            reminderIcon.Icon = (Icon)resources.GetObject("reminderIcon.Icon");
            reminderIcon.Text = "Reminder";
            reminderIcon.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(day7FlowLayoutPanel);
            Controls.Add(day6FlowLayoutPanel);
            Controls.Add(day5FlowLayoutPanel);
            Controls.Add(day4FlowLayoutPanel);
            Controls.Add(day3FlowLayoutPanel);
            Controls.Add(day2FlowLayoutPanel);
            Controls.Add(day1FlowLayoutPanel);
            Controls.Add(forwardButton);
            Controls.Add(backwardButton);
            Controls.Add(dateLabel7);
            Controls.Add(dateLabel6);
            Controls.Add(dateLabel5);
            Controls.Add(dateLabel4);
            Controls.Add(dateLabel3);
            Controls.Add(dateLabel2);
            Controls.Add(dateLabel1);
            Controls.Add(labelDay6);
            Controls.Add(labelDay5);
            Controls.Add(labelDay4);
            Controls.Add(labelDay3);
            Controls.Add(labelDay2);
            Controls.Add(labelDay7);
            Controls.Add(labelDay1);
            Controls.Add(removeButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 460);
            MinimumSize = new Size(816, 460);
            Name = "Form1";
            Text = "MyReminders";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button editButton;
        private Button removeButton;
        private Label labelDay1;
        private Label labelDay7;
        private Label labelDay2;
        private Label labelDay3;
        private Label labelDay4;
        private Label labelDay5;
        private Label labelDay6;
        private Label dateLabel1;
        private Label dateLabel2;
        private Label dateLabel3;
        private Label dateLabel4;
        private Label dateLabel5;
        private Label dateLabel6;
        private Label dateLabel7;
        private Button backwardButton;
        private Button forwardButton;
        private FlowLayoutPanel day1FlowLayoutPanel;
        private FlowLayoutPanel day2FlowLayoutPanel;
        private FlowLayoutPanel day3FlowLayoutPanel;
        private FlowLayoutPanel day4FlowLayoutPanel;
        private FlowLayoutPanel day5FlowLayoutPanel;
        private FlowLayoutPanel day6FlowLayoutPanel;
        private FlowLayoutPanel day7FlowLayoutPanel;
        private NotifyIcon reminderIcon;
    }
}