using System;
using System.Windows.Forms;

namespace Veleprodaja
{
    public partial class PanelForm : Form
    {
        public PanelForm(Boolean admin)
        {
            InitializeComponent();
            if (admin)
            {
                pictureBox1.Image = Veleprodaja.Properties.Resources.

            }
            else
            {
                btnNalog.Enabled = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
