using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsManagement_Dashboard
{
    public partial class Login : Form
    {

        private string _username;
        string usernameInput;
        private string _password;


        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!File.Exists("loginData.txt")) // If file does not exists
            {
                File.Create("loginData.txt").Close(); // Create file
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            _username = usernameTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            _password = passwordTextBox.Text;
        }

     

        private void testLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createAccountButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount sistema = new CreateAccount();
            sistema.ShowDialog();
            this.Close();
        }

        private void enterButton_Click_1(object sender, EventArgs e)
        {
            //Initialize line reader
            StreamReader sr = new StreamReader(File.OpenRead("loginData.txt"));

            //Get all lines in the file
            List<string> lines = new List<string>();
            string line = "";
            Boolean isUsername = false;

            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }

            string usernameStart = "";

            for (int i = 0; i < lines.Count; i++)
            {
                try
                {
                    usernameStart = lines[i].Substring(0, 9);

                    if (usernameStart == "Username:")
                    {
                        isUsername = true;
                        usernameInput = lines[i].Substring(9);
                    }
                }
                catch (Exception ex) { isUsername = false; };
               
                if (isUsername && usernameInput == _username)
                {
                    if (lines[i + 1] == _password)
                    {
                        this.Hide();
                        Form1 sistema = new Form1();
                        sistema.ShowDialog();
                        this.Close();
                    }

                }
            }
            MessageBox.Show("Invalid Username or Password");
            sr.Close();
        }

        private void usernameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            _username = usernameTextBox.Text;   
        }

        private void passwordTextBox_TextChanged_1(object sender, EventArgs e)
        {
            _password = passwordTextBox.Text;
        }
    }
}
