using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PropertyManagementSystem.Models;

namespace PropertyManagementSystem.Forms
{
    public partial class Main : Form
    {
        private readonly MyDbContext _db = new MyDbContext();
        public Main()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblFullName.Text = CurrentUser.FullName;
            Size = Screen.PrimaryScreen.Bounds.Size;
            CenterToScreen();
            CheckPermissions();
            CheckNewClaims();
        }

        private void CheckNewClaims()
        {
            var date = DateTime.Now.AddDays(10);
            var contracts = _db.Contracts.Where(c => date >= c.PayDate).ToList();
            foreach (var contract in contracts)
            {
                contract.PayStatus = "Pending";
                _db.SaveChanges();
            }
        }

        private void CheckPermissions()
        {
            if (CurrentUser.UserType == UserType.Administrator)
                return;
            btnClients.Enabled = btnContracts.Enabled =
                btnPaymentClaim.Enabled = btnUsers.Enabled = btnReporting.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnCommercialBuildings_Click(object sender, EventArgs e)
        {
            new ManageCommercialBuildings().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToString(CultureInfo.CurrentCulture).Split(' ')[1];
        }

        private void pbOpen_Click(object sender, EventArgs e)
        {
            lblChangePwd.Visible = pbChangePwd.Visible = lblSignOut.Visible = pbLogout.Visible = pbClose.Visible = true;
            pbOpen.Visible = false;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            lblChangePwd.Visible = pbChangePwd.Visible = lblSignOut.Visible = pbLogout.Visible = pbClose.Visible = false;
            pbOpen.Visible = true;
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void pbChangePwd_Click(object sender, EventArgs e)
        {
            new ChangePassword().ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnResidentialBuildings_Click(object sender, EventArgs e)
        {
            new ManageResidentialBuildings().ShowDialog();
        }

        private void btnFarms_Click(object sender, EventArgs e)
        {
            new ManageFarms().ShowDialog();
        }

        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            new ManageWarehouses().ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            new ManageClients().ShowDialog();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            new ManageContracts().ShowDialog();
        }

        private void btnPaymentClaim_Click(object sender, EventArgs e)
        {
            new Claims().ShowDialog();
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            new ReportingForm().ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new ManageUsers().ShowDialog();
        }
    }
}
