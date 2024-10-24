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
    public partial class InfoCard : UserControl
    {
        public InfoCard()
        {
            InitializeComponent();
        }

        public void SetAthleteDetails(string athleteName, string nationality, string position, string team, string height, string weight, string age) // You can expand this to include more details
        {
            // Assuming you have a label to display the name
            lblAthleteName.Text = athleteName;
            lblAthleteNationality.Text = nationality;
            lblAthletePosition.Text = position;
            lblAthleteTeam.Text = team;
            lblAthleteHeight.Text = height;
            lblAthleteWeight.Text = weight;
            lblAthleteAge.Text = age;
        }



private void InfoCard_Load(object sender, EventArgs e)
        {

        }
    }
}
