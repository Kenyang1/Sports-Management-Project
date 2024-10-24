using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsManagement_Dashboard
{
    public partial class Settings : Form
    {
        private string _username;
        private string _name;
        private string _orgName;
        private string _profilePicturePath;

        // Constructor
        public Settings(string username)
        {
            InitializeComponent();
            _username = username;
        }

        // Event handler for when the form loads
        private void Settings_Load(object sender, EventArgs e)
        {
            LoadUserInfo(); // Load user information when the form loads
        }

        // Method to load user information from the LoginData.txt file
        private void LoadUserInfo()
        {
            try
            {
                string[] lines = File.ReadAllLines("LoginData.txt");
                bool isUsernameFound = false;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("Username: ") && lines[i].Substring(9).Trim() == _username)
                    {
                        isUsernameFound = true;

                        _name = lines[i + 2].Substring(5).Trim();
                        _orgName = lines[i + 3].Substring(12).Trim();
                        _profilePicturePath = lines[i + 4].Substring(18).Trim();

                        nameTextBox.Text = _name;
                        orgNameTextBox.Text = _orgName;

                        if (File.Exists(_profilePicturePath))
                        {
                            profilePictureBox.Image = Image.FromFile(_profilePicturePath);
                        }
                        break;
                    }
                }

                if (!isUsernameFound)
                {
                    MessageBox.Show("User not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user information: {ex.Message}");
            }
        }

        // Save button click event
        private void saveButton_Click(object sender, EventArgs e)
        {
            _name = nameTextBox.Text;
            _orgName = orgNameTextBox.Text;

            try
            {
                string[] lines = File.ReadAllLines("LoginData.txt");

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("Username: ") && lines[i].Substring(9).Trim() == _username)
                    {
                        lines[i + 2] = $"Name: {_name}";
                        lines[i + 3] = $"Organization: {_orgName}";
                        lines[i + 4] = $"Profile Picture Path: {_profilePicturePath}";

                        break;
                    }
                }

                File.WriteAllLines("LoginData.txt", lines);

                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }

        // Upload profile picture button
        private void uploadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _profilePicturePath = openFileDialog.FileName;
                profilePictureBox.Image = Image.FromFile(_profilePicturePath);
            }
        }

        // Change picture button click event
        private void changePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _profilePicturePath = openFileDialog.FileName;
                profilePictureBox.Image = Image.FromFile(_profilePicturePath);
            }
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
