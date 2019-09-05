using System.Linq;
using System.Windows.Forms;
using PropertyManagementSystem.Models;

namespace PropertyManagementSystem.Forms
{
    public partial class AddUser : Form
    {
        MyDbContext db = new MyDbContext();
        public AddUser()
        {
            InitializeComponent();
        }

        private void pbClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConfirmPassword.Text) && !string.IsNullOrWhiteSpace(txtFullName.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                !string.IsNullOrWhiteSpace(txtUserName.Text) && cbUserType.selectedIndex > -1)
            {
                var sameUser = db.Users.Where(u => u.UserName.Equals(txtUserName.Text));
                if (sameUser.Any())
                    MessageBox.Show(@"Sorry, this user name is already taken
Please choose an other user name", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (txtConfirmPassword.Text.Equals(txtPassword.Text))
                    {
                        db.Users.Add(new User()
                        {
                            FullName = txtFullName.Text,
                            IsActive = chbIsActive.Checked,
                            Password = txtPassword.Text,
                            UserName = txtUserName.Text,
                            UserType = cbUserType.selectedValue == @"Administrator"
                                ? UserType.Administrator
                                : UserType.Marketing
                        });
                        db.SaveChanges();
                        MessageBox.Show(@"Saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show(@"Sorry, password doesn't match the confirmation", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Please fill all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtFullName.Text = "";
            txtUserName.Text = "";
            cbUserType.selectedIndex = -1;
            chbIsActive.Checked = false;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void AddUser_Load(object sender, System.EventArgs e)
        {
        }

        private void txtPassword_OnValueChanged(object sender, System.EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtConfirmPassword_OnValueChanged(object sender, System.EventArgs e)
        {
            txtConfirmPassword.isPassword = true;
        }
    }
}
