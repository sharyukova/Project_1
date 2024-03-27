using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace Project_1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            DisplayStudData();
        }

        private void DisplayStudData()
        {
            AddingStudentsData adData = new AddingStudentsData();
            studDataGridView.DataSource = adData.GetStudentData();
        }

        private void addStudButton_Click(object sender, EventArgs e)
        {

        }
    }
}
