using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_1
{
    public partial class AdminScheduleForm : Form
    {
        public AdminScheduleForm()
        {
            InitializeComponent();
        }

        private void openSchedButton_MouseEnter(object sender, EventArgs e)
        {
            schedulePic.BackColor = SystemColors.ControlLight;
        }

        private void openSchedButton_MouseLeave(object sender, EventArgs e)
        {
            schedulePic.BackColor = Color.Transparent;
        }

        private void openGroupsButton_MouseEnter(object sender, EventArgs e)
        {
            groupsPic.BackColor = SystemColors.ControlLight;
        }

        private void openGroupsButton_MouseLeave(object sender, EventArgs e)
        {
            groupsPic.BackColor = Color.Transparent;
        }

        private void openScoresButton_MouseEnter(object sender, EventArgs e)
        {
            scoresPic.BackColor = SystemColors.ControlLight;
        }

        private void openScoresButton_MouseLeave(object sender, EventArgs e)
        {
            scoresPic.BackColor = Color.Transparent;
        }

        private void returnButton_MouseEnter(object sender, EventArgs e)
        {
            enterPic.BackColor = SystemColors.ControlLight;
        }

        private void returnButton_MouseLeave(object sender, EventArgs e)
        {
            enterPic.BackColor = Color.Transparent;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            AdminForm returnForm = new AdminForm();
            returnForm.Show();
            this.Hide();
        }

        private void openSchedButton_Click(object sender, EventArgs e)
        {
            
        }

        private void openGroupsButton_Click(object sender, EventArgs e)
        {
            GroupsForm groupsForm = new GroupsForm();
            groupsForm.Show();
            this.Hide();
        }

        private void openScoresButton_Click(object sender, EventArgs e)
        {
            AdminScoresForm scoresForm = new AdminScoresForm();
            scoresForm.Show();
            this.Hide();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.BackColor = SystemColors.ControlLight;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor = Color.Transparent;
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
