using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SportsManagement_Dashboard
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private string _username;
        public Form1()
        {
            InitializeComponent();

            
            // Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userName_Label_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = coachbutton1.Height;
            pnlNav.Top = coachbutton1.Top;
            pnlNav.Left = coachbutton1.Left;
            coachbutton1.BackColor = Color.FromArgb(46, 51, 73);
            CoachRoster coachRoster = new CoachRoster();
            coachRoster.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void teambutton1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = teambutton1.Height;
            pnlNav.Top = teambutton1.Top;
            pnlNav.Left = teambutton1.Left;
            teambutton1.BackColor = Color.FromArgb(46, 51, 73);
            AthleteRoster athleteRoster = new AthleteRoster();
            athleteRoster.Show();
        }

        private void matchesbutton3_Click(object sender, EventArgs e)
        {
            pnlNav.Height = matchesbutton3.Height;
            pnlNav.Top = matchesbutton3.Top;
            pnlNav.Left = matchesbutton3.Left;
            matchesbutton3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void statsbutton1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = statsbutton1.Height;
            pnlNav.Top = statsbutton1.Top;
            pnlNav.Left = statsbutton1.Left;
            statsbutton1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void settingsbutton1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = settingsbutton1.Height;
            pnlNav.Top = settingsbutton1.Top;
            pnlNav.Left = settingsbutton1.Left;
            settingsbutton1.BackColor = Color.FromArgb(46, 51, 73);

            // Show Settings Form
            Settings settingsPage = new Settings(_username); // Pass the current username
            settingsPage.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void teambutton1_Leave(object sender, EventArgs e)
        {
            teambutton1.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void coachbutton1_Leave(object sender, EventArgs e)
        {
            coachbutton1.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void matchesbutton3_Leave(object sender, EventArgs e)
        {
            matchesbutton3.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void statsbutton1_Leave(object sender, EventArgs e)
        {
            statsbutton1.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void settingsbutton1_Leave(object sender, EventArgs e)
        {
            settingsbutton1.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
