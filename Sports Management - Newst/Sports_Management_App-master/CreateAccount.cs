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
    public partial class CreateAccount : Form
    {

        private string _username;
        private string _password;
        private string _teamName;

        //Streamwriter Create
        StreamWriter sw = File.AppendText("loginData.txt");

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            _username = usernameTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            _password = passwordTextBox.Text;
        }

        private void teamNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _teamName = teamNameTextBox.Text;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            sw.WriteLine("Username:" + _username);
            sw.WriteLine(_password);
            sw.WriteLine(_teamName);

            sw.Close();

            this.Hide();
            Login sistema = new Login();
            sistema.ShowDialog();
            this.Close();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
