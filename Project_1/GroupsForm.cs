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
    public partial class GroupsForm : Form
    {
        public GroupsForm()
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

        private void openSchedButton_Click(object sender, EventArgs e)
        {
            AdminScheduleForm adminScheduleForm = new AdminScheduleForm();
            adminScheduleForm.Show();
            this.Hide();
        }

        private void openGroupsButton_MouseEnter(object sender, EventArgs e)
        {
            groupsPic.BackColor = SystemColors.ControlLight;
        }

        private void openGroupsButton_MouseLeave(object sender, EventArgs e)
        {
            groupsPic.BackColor = Color.Transparent;
        }

        private void openGroupsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void openScoresButton_MouseEnter(object sender, EventArgs e)
        {
            scoresPic.BackColor = SystemColors.ControlLight;
        }

        private void openScoresButton_MouseLeave(object sender, EventArgs e)
        {
            scoresPic.BackColor = Color.Transparent;
        }

        private void openScoresButton_Click(object sender, EventArgs e)
        {
            AdminScoresForm scoresForm = new AdminScoresForm();
            scoresForm.Show();
            this.Hide();
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

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
