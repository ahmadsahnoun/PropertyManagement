using System;
using System.Drawing;
using System.Windows.Forms;

namespace PropertyManagementSystem.Forms
{
    public partial class ViewDocument : Form
    {
        public ViewDocument()
        {
            InitializeComponent();
        }

        public ViewDocument(Image image)
        {
            InitializeComponent();
            try
            {
                pbImage.Image = image;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
