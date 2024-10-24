namespace SportsManagement_Dashboard
{
    partial class InfoCard
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
            this.lblAthleteName = new System.Windows.Forms.Label();
            this.lblAthleteNationality = new System.Windows.Forms.Label();
            this.lblAthletePosition = new System.Windows.Forms.Label();
            this.lblAthleteTeam = new System.Windows.Forms.Label();
            this.lblAthleteHeight = new System.Windows.Forms.Label();
            this.lblAthleteWeight = new System.Windows.Forms.Label();
            this.lblAthleteAge = new System.Windows.Forms.Label();
            this.pictureBoxAthlete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAthlete)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAthleteName
            // 
            this.lblAthleteName.AutoSize = true;
            this.lblAthleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAthleteName.Location = new System.Drawing.Point(84, 77);
            this.lblAthleteName.MinimumSize = new System.Drawing.Size(160, 30);
            this.lblAthleteName.Name = "lblAthleteName";
            this.lblAthleteName.Size = new System.Drawing.Size(184, 30);
            this.lblAthleteName.TabIndex = 0;
            this.lblAthleteName.Text = " lblAthleteName";
            // 
            // lblAthleteNationality
            // 
            this.lblAthleteNationality.AutoSize = true;
            this.lblAthleteNationality.Location = new System.Drawing.Point(13, 247);
            this.lblAthleteNationality.Name = "lblAthleteNationality";
            this.lblAthleteNationality.Size = new System.Drawing.Size(44, 16);
            this.lblAthleteNationality.TabIndex = 1;
            this.lblAthleteNationality.Text = "label1";
            // 
            // lblAthletePosition
            // 
            this.lblAthletePosition.AutoSize = true;
            this.lblAthletePosition.BackColor = System.Drawing.SystemColors.Control;
            this.lblAthletePosition.Location = new System.Drawing.Point(13, 132);
            this.lblAthletePosition.Name = "lblAthletePosition";
            this.lblAthletePosition.Size = new System.Drawing.Size(44, 16);
            this.lblAthletePosition.TabIndex = 2;
            this.lblAthletePosition.Text = "label1";
            // 
            // lblAthleteTeam
            // 
            this.lblAthleteTeam.AutoSize = true;
            this.lblAthleteTeam.Location = new System.Drawing.Point(13, 189);
            this.lblAthleteTeam.Name = "lblAthleteTeam";
            this.lblAthleteTeam.Size = new System.Drawing.Size(44, 16);
            this.lblAthleteTeam.TabIndex = 3;
            this.lblAthleteTeam.Text = "label1";
            // 
            // lblAthleteHeight
            // 
            this.lblAthleteHeight.AutoSize = true;
            this.lblAthleteHeight.Location = new System.Drawing.Point(243, 132);
            this.lblAthleteHeight.Name = "lblAthleteHeight";
            this.lblAthleteHeight.Size = new System.Drawing.Size(44, 16);
            this.lblAthleteHeight.TabIndex = 4;
            this.lblAthleteHeight.Text = "label1";
            // 
            // lblAthleteWeight
            // 
            this.lblAthleteWeight.AutoSize = true;
            this.lblAthleteWeight.Location = new System.Drawing.Point(243, 189);
            this.lblAthleteWeight.Name = "lblAthleteWeight";
            this.lblAthleteWeight.Size = new System.Drawing.Size(44, 16);
            this.lblAthleteWeight.TabIndex = 5;
            this.lblAthleteWeight.Text = "label1";
            // 
            // lblAthleteAge
            // 
            this.lblAthleteAge.AutoSize = true;
            this.lblAthleteAge.Location = new System.Drawing.Point(243, 247);
            this.lblAthleteAge.Name = "lblAthleteAge";
            this.lblAthleteAge.Size = new System.Drawing.Size(44, 16);
            this.lblAthleteAge.TabIndex = 6;
            this.lblAthleteAge.Text = "label1";
            // 
            // pictureBoxAthlete
            // 
            this.pictureBoxAthlete.Image = global::SportsManagement_Dashboard.Properties.Resources.user;
            this.pictureBoxAthlete.Location = new System.Drawing.Point(114, 3);
            this.pictureBoxAthlete.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBoxAthlete.Name = "pictureBoxAthlete";
            this.pictureBoxAthlete.Size = new System.Drawing.Size(95, 71);
            this.pictureBoxAthlete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAthlete.TabIndex = 7;
            this.pictureBoxAthlete.TabStop = false;
            // 
            // InfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxAthlete);
            this.Controls.Add(this.lblAthleteAge);
            this.Controls.Add(this.lblAthleteWeight);
            this.Controls.Add(this.lblAthleteHeight);
            this.Controls.Add(this.lblAthleteTeam);
            this.Controls.Add(this.lblAthletePosition);
            this.Controls.Add(this.lblAthleteNationality);
            this.Controls.Add(this.lblAthleteName);
            this.Name = "InfoCard";
            this.Size = new System.Drawing.Size(322, 312);
            this.Load += new System.EventHandler(this.InfoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAthlete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAthleteName;
        private System.Windows.Forms.Label lblAthleteNationality;
        private System.Windows.Forms.Label lblAthletePosition;
        private System.Windows.Forms.Label lblAthleteTeam;
        private System.Windows.Forms.Label lblAthleteHeight;
        private System.Windows.Forms.Label lblAthleteWeight;
        private System.Windows.Forms.Label lblAthleteAge;
        private System.Windows.Forms.PictureBox pictureBoxAthlete;
    }
}
