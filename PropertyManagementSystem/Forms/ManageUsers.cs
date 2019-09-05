using System;
using System.Linq;
using System.Windows.Forms;
using PropertyManagementSystem.Models;

namespace PropertyManagementSystem.Forms
{
    public partial class ManageUsers : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddUser().ShowDialog();
            dgvUsers.Rows.Clear();
            FillDgv();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillDgv()
        {
            if(dgvUsers.Rows.Count > 0) dgvUsers.Rows.Clear();
            var users = _db.Users.ToList();
            foreach (var user in users)
            {
                dgvUsers.Rows.Add(user.Id, user.FullName, user.UserName, user.UserType.ToString(),
                    user.IsActive ? "Active" : "Not Active");
            }
            dgvUsers.ClearSelection();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            FillDgv();
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            dgvUsers.Rows.Clear();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                var users = _db.Users.Where(u =>
                    u.FullName.Contains(txtSearch.Text) || u.UserName.Contains(txtSearch.Text) ||
                    u.UserType.ToString().Contains(txtSearch.Text));
                foreach (var user in users)
                {
                    dgvUsers.Rows.Add(user.Id, user.FullName, user.UserName, user.UserType.ToString(),
                        user.IsActive ? "Active" : "Not Active");
                }
                dgvUsers.ClearSelection();
            }
            else
            {
                FillDgv();
            }
        }

        private void Clear()
        {
            dgvUsers.ClearSelection();
            txtFullName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtUserName.Text = "";
            chbIsActive.Checked = false;
            cbUserType.selectedIndex = -1;
            txtFullName.Enabled = txtPassword.Enabled = txtConfirmPassword.Enabled = txtUserName.Enabled =
                chbIsActive.Enabled = cbUserType.Enabled = btnEdit.Enabled = btnDelete.Enabled = false;
            FillDgv();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFullName.Enabled = txtPassword.Enabled = txtConfirmPassword.Enabled = txtUserName.Enabled =
                chbIsActive.Enabled = cbUserType.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            var userId = int.Parse(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
            var user = _db.Users.Find(userId);
            if (user == null) return;
            txtPassword.Text = user.Password;
            txtConfirmPassword.Text = user.Password;
            txtFullName.Text = user.FullName;
            txtUserName.Text = user.UserName;
            chbIsActive.Checked = user.IsActive;
            cbUserType.selectedIndex = user.UserType.ToString().Equals("Administrator") ? 0 : 1;
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
        }

        private void txtConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.isPassword = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count <= 0) return;
            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
                MessageBox.Show(@"Sorry, password doesn't match the confirmation", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                var userId = int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
                var user = _db.Users.Find(userId);
                if (user == null) return;
                user.UserName = txtUserName.Text;
                user.FullName = txtFullName.Text;
                user.Password = txtPassword.Text;
                user.UserType = cbUserType.selectedValue == @"Administrator"
                    ? UserType.Administrator
                    : UserType.Marketing;
                user.IsActive = chbIsActive.Checked;
                _db.SaveChanges();
                MessageBox.Show(@"User Data Edited Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count <= 0) return;
            var result = MessageBox.Show(@"Are you sure you want to delete this user?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;
            var userId = int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString());
            var user = _db.Users.Find(userId);
            if (user != null) _db.Users.Remove(user);
            _db.SaveChanges();
            MessageBox.Show(@"User Data Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
