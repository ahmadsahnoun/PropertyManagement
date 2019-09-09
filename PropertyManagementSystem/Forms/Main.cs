using System;
using System.Globalization;
using System.Windows.Forms;
using PropertyManagementSystem.Models;

namespace PropertyManagementSystem.Forms
{
    public partial class Main : Form
    {
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
