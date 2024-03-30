using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Gray;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.FromArgb(104, 100, 252);
        }

        private void setInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetInForm setInForm = new SetInForm();
            setInForm.Show();
        }

        private void setUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetInAdminForm setUpForm = new SetInAdminForm();
            setUpForm.Show();
        }


    }
}
