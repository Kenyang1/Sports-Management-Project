using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsManagement_Dashboard
{
    public partial class AthleteRoster : Form
    {
        public AthleteRoster()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedAthlete = listBox1.SelectedItem.ToString();
                string nationality = "Unknown";
                string position = "Unknown";
                string team = "Unknown";
                string height = "Unknown";
                string weight = "Unknown";
                string age = "Unknown";

                if (selectedAthlete == "John Lansing")
                {
                    nationality = "American";
                    position = "QuarterBack";
                    team = "American Football Team";
                    height = "6'3 (190.5 cm)";
                    weight = "225 lbs (102 kg)";
                    age = "27";

                }

             
                if (selectedAthlete == "Robert Wayne")
                {
                    nationality = "American";
                    position = "Wide Receiver";
                    team = "American Football Team";
                    height = "6'1 (185.4 cm)";
                    weight = "210 lbs (95 kg)";
                    age = "25";
                }

                if (selectedAthlete == "Bruce Papadopoulos")
                {
                    nationality = "American";
                    position = "Linebacker";
                    team = "American Football Team";
                    height = "6'2 (187.9 cm)";
                    weight = "240 lbs (109 kg)";
                    age = "30";
                }
                
                if (selectedAthlete == "Steve Hornbee")
                {
                    nationality = "American";
                    position = "Running Back";
                    team = "American Football Team";
                    height = "5'11 (180.3 cm)";
                    weight = "215 lbs (97.5 kg)";
                    age = "24";
                }

                if (selectedAthlete == "Sam McQueen")
                {
                    nationality = "American";
                    position = "Tight End";
                    team = "American Football Team";
                    height = "6'4 (193 cm)";
                    weight = "250 lbs (113.4 kg)";
                    age = "28";
                }

                if (selectedAthlete == "Butch Bunyan")
                {
                    nationality = "American";
                    position = "Defensive Tackle";
                    team = "American Football Team";
                    height = "6'5 (195.6 cm)";
                    weight = "300 lbs (136 kg)";
                    age = "31";
                }

                // Create an instance of the InfoCard user control
                InfoCard infoCard = new InfoCard();

                // Set the details for the selected athlete
                infoCard.SetAthleteDetails(selectedAthlete, nationality, position, team, height, weight, age);

               
                // Optionally, create a new form to display the InfoCard
                Form infoCardForm = new Form(); // Create a new form
                infoCardForm.Controls.Add(infoCard); // Add the InfoCard to the form
                infoCard.Dock = DockStyle.Fill; // Make the InfoCard fill the form
                infoCardForm.Text = "Athlete Info"; // Set the title for the form
                infoCardForm.StartPosition = FormStartPosition.CenterParent; // Center the form

                // Show the form as a modal dialog
                infoCardForm.ShowDialog();
            }
           
        }
    }
}
