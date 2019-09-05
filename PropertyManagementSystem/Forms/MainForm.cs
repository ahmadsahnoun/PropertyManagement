using System;
using System.Windows.Forms;

namespace PropertyManagementSystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Size = Screen.PrimaryScreen.Bounds.Size;
            CenterToScreen();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button4_Click(sender,e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ManageWarehouses().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManageCommercialBuildings().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ManageResidentialBuildings().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ManageFarms().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ManageClients().ShowDialog();
        }
    }
}
