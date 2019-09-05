using System;
using System.Windows.Forms;
using PropertyManagementSystem.Models;

namespace PropertyManagementSystem.Forms
{
    public partial class ChangePassword : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOldPassword.Text) && !string.IsNullOrEmpty(txtNewPassword.Text) &&
                !string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                if (txtOldPassword.Text.Equals(CurrentUser.Password))
                {
                    if (txtConfirmPassword.Text.Equals(txtNewPassword.Text))
                    {
                        var user = _db.Users.Find(CurrentUser.Id);
                        if (user != null) user.Password = txtNewPassword.Text;
                        _db.SaveChanges();
                        CurrentUser.Password = txtNewPassword.Text;
                        MessageBox.Show(@"Password Changed Successfully", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Clear();
                        
                    }
                    else
                    {
                        MessageBox.Show(@"Sorry, new password doesn't match the confirmation", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(@"Sorry, Old password is not correct", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtOldPassword.Text = txtNewPassword.Text = txtConfirmPassword.Text = "";
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtFullName.Text = CurrentUser.FullName;
            txtUserName.Text = CurrentUser.UserName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtOldPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtOldPassword.isPassword = true;
        }

        private void txtNewPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtNewPassword.isPassword = true;
        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.isPassword = true;
        }
    }
}
