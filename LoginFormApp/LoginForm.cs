using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var message = string.Empty;
            var username = "user1";
            var password = "password1";
            var error = false;
            if (UsernameInput.Text != username)
            {
                message += "Please input a registered account. \n";
                error = true;
            }
            if (PasswordInput.Text != password)
            {
                message += "Please input a valid password. \n";
                error = true;
            }

            if (!error)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                const string title = "Error";
                MessageBox.Show(message, title);
            }
        }
    }
}
