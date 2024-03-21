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
    public partial class SetInForm : Form
    {
        public SetInForm()
        {
            InitializeComponent();
        }
        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Gray;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.FromArgb(104, 100, 252);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lostPasswLabel_MouseEnter(object sender, EventArgs e)
        {
            lostPasswLabel.ForeColor = Color.Gray;
        }

        private void lostPasswLabel_MouseLeave(object sender, EventArgs e)
        {
            lostPasswLabel.ForeColor = Color.Black;
        }

        private void setUpLabel_MouseEnter(object sender, EventArgs e)
        {
            setUpLabel.ForeColor = Color.Gray;
        }

        private void setUpLabel_MouseLeave(object sender, EventArgs e)
        {
            setUpLabel.ForeColor= Color.FromArgb(104, 100, 252);
        }

        private void setUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetUpForm setUpForm = new SetUpForm();
            setUpForm.Show();
        }
    }
}
