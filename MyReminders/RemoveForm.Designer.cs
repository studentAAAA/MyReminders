namespace MyReminders
{
    partial class RemoveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveForm));
            enterTitleLabel = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // enterTitleLabel
            // 
            enterTitleLabel.AutoSize = true;
            enterTitleLabel.Location = new Point(38, 57);
            enterTitleLabel.Name = "enterTitleLabel";
            enterTitleLabel.Size = new Size(144, 15);
            enterTitleLabel.TabIndex = 0;
            enterTitleLabel.Text = "Enter Title (case sensitive):";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(62, 83);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(72, 117);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(54, 157);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(114, 15);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "Reminder not found";
            // 
            // RemoveForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(errorLabel);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(enterTitleLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(250, 250);
            MinimumSize = new Size(250, 250);
            Name = "RemoveForm";
            Text = "RemoveForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterTitleLabel;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label errorLabel;
    }
}