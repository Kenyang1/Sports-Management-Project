using System.Windows.Forms;
using System;

namespace SportsManagement_Dashboard
{
    partial class Settings
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextBox; // Box for name
        private TextBox orgNameTextBox; // Box for organization
        private PictureBox profilePictureBox; // Picture box for profile picture
        private Button saveButton; // Button to save changes
        private Button changePictureButton; // Button to change picture

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // This method adds all the boxes and buttons to the page
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.orgNameTextBox = new System.Windows.Forms.TextBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.changePictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(50, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // orgNameTextBox
            // 
            this.orgNameTextBox.Location = new System.Drawing.Point(50, 70);
            this.orgNameTextBox.Name = "orgNameTextBox";
            this.orgNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.orgNameTextBox.TabIndex = 1;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Location = new System.Drawing.Point(50, 110);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePictureBox.TabIndex = 2;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(50, 230);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // changePictureButton
            // 
            this.changePictureButton.Location = new System.Drawing.Point(160, 110);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(90, 25);
            this.changePictureButton.TabIndex = 3;
            this.changePictureButton.Text = "Change Picture";
            this.changePictureButton.Click += new System.EventHandler(this.changePictureButton_Click);
            // 
            // Settings
            // 
            this.ClientSize = new System.Drawing.Size(578, 357);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.orgNameTextBox);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.changePictureButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
