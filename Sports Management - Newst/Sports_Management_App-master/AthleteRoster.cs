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
        private InfoCard InfoCardControl;
        public AthleteRoster()
        {
            InitializeComponent();
            InfoCardControl = new InfoCard();
            InfoCardControl.Location = new Point(50, 50);
            InfoCardControl.Size = new Size(200, 200);
            InfoCardControl.Visible = false;
            this.Controls.Add(InfoCardControl);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAthlete = listBox1.SelectedItem.ToString();
            if (selectedAthlete == "John Lansing")
            {
                InfoCardControl.Visible = true;
            }
            else
            {
                InfoCardControl.Visible = false;
                MessageBox.Show("ListBox item selected");
            }
            }

        }
    }

