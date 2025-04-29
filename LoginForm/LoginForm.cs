using System;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input data
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Please enter a username");
                errorProvider1.SetError(txtPassword, "Please enter a password");
                return;
            }

            // Check if credentials are valid
            if (txtUsername.Text == "admin" && txtPassword.Text == "password")
            {
                // Login successful
                MessageBox.Show("Login successful!");
            }
            else
            {
                // Login failed
                errorProvider1.SetError(txtUsername, "Invalid username or password");
                errorProvider1.SetError(txtPassword, "Invalid username or password");
            }
        }
    }
}