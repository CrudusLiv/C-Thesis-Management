using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP101_Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // Get the username and password from the textboxes.
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate the username and password.
            if (username == "admin" && password == "password")
            {
                // Open the home screen.
                Home homeScreen = new Home();
                homeScreen.Show();

                // Hide the login screen.
                this.Hide();
            }
            else
            {
                // Show an error message.
                MessageBox.Show("Invalid username or password.");
                txtPassword.Text = "";
                txtUsername.Text = "";
                txtUsername.Focus();
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
