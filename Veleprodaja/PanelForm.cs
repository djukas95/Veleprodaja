using System;
using System.Windows.Forms;

namespace Veleprodaja
{
    public partial class PanelForm : Form
    {
        private void login()
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();

            if (result.Equals(DialogResult.Yes))
            {
                pictureBox1.Image = Properties.Resources.blue_boa;

            }
            else if(result.Equals(DialogResult.No))
            {
                btnNalog.Enabled = false;
            }
            else
            {
                Application.Exit();
            }
        }
        public PanelForm()
        {
            InitializeComponent();
            login();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnRobniPromet_Click(object sender, EventArgs e)
        {
            RobniPrometForm prometForm = new RobniPrometForm();
            prometForm.Show();
        }

        private void btnOdjaviSe_Click(object sender, EventArgs e)
        {
            int countForms = Application.OpenForms.Count;
            if (countForms > 1)
            {
                MessageBox.Show("Imate otvorenih formi, molimo Vas da sačuvate izmjene!");
            }
            else
            {
                this.Hide();
                login();
                this.Show();
            }
        }
    }
}
