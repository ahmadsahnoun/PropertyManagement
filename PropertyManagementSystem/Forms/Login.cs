using System;
using System.Linq;
using System.Windows.Forms;
using PropertyManagementSystem.Models;

namespace PropertyManagementSystem.Forms
{
    public partial class Login : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                var user = _db.Users.SingleOrDefault(u => u.UserName.Equals(txtUserName.Text));
                if (user != null)
                {
                    if (user.Password.Equals(txtPassword.Text))
                    {
                        if (user.IsActive)
                        {
                            CurrentUser.Password = user.Password;
                            CurrentUser.FullName = user.FullName;
                            CurrentUser.Id = user.Id;
                            CurrentUser.IsActive = user.IsActive;
                            CurrentUser.UserName = user.UserName;
                            CurrentUser.UserType = user.UserType;
                            new Main().Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show(@"Sorry, this user is not active
Please contact to the administration", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        MessageBox.Show(@"Sorry, wrong user name or password", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(@"Sorry, wrong user name or password", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
