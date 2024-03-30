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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.BackColor = SystemColors.Window;
                ;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor= SystemColors.Control;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openSchedButton_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.Show();
            this.Hide();
        }

        private void openInfoButton_Click(object sender, EventArgs e)
        {
            InfoUserForm infoUserForm = new InfoUserForm();
            infoUserForm.Show();
            this.Hide();
        }

        private void openSchoreButton_Click(object sender, EventArgs e)
        {
            ScoresForm scoreForm = new ScoresForm();
            scoreForm.Show();
            this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            SetInForm setInForm = new SetInForm();
            setInForm.Show();
            this.Hide();
        }

        private void returnButton_MouseEnter(object sender, EventArgs e)
        {
            returnButton.BackColor = SystemColors.Control;
        }

        private void returnButton_MouseLeave(object sender, EventArgs e)
        {
            returnButton.BackColor= Color.Transparent;
        }
    }
}
