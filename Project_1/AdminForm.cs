using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Project_1
{
    public partial class AdminForm : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\universityDB.mdf;Integrated Security=True;Connect Timeout=30");
        private SqlConnection sqlConnection = null;
        
        private SqlCommandBuilder sqlCommandBuilder = null;
        
        private SqlDataAdapter sqlDataAdapter = null;
        
        private DataSet dataSet = null;

        private bool newRowAdding = false;


        public AdminForm()
        {
            InitializeComponent();
            
        }

        




        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM students", sqlConnection);

                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "students");
                studDataGridView.DataSource = dataSet.Tables["students"];
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                
                DataTable dataTable = (DataTable)studDataGridView.DataSource;

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM students", sqlConnection))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dataTable);
                }

                //dataSet.Tables.Clear();

                //sqlDataAdapter.Fill(dataSet, "students");
                //studDataGridView.DataSource = dataSet.Tables["students"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["universityDB"].ConnectionString);

            sqlConnection.Open();

            LoadData();
        }

        /// 
        /// обновление, удаление, изменение и тд
        ///         
        private void updateStudButton_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void deleteStudButton_Click(object sender, EventArgs e)
        {
            if (studDataGridView.SelectedCells.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                    {
                        int rowIndex = studDataGridView.SelectedCells[0].RowIndex;
                        int columnIndex = studDataGridView.SelectedCells[0].ColumnIndex;

                        studDataGridView.Rows.RemoveAt(rowIndex);

                        dataSet.Tables["students"].Rows[rowIndex].Delete();

                        sqlDataAdapter.Update(dataSet, "students");

                        ReloadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void insertStudButton_Click(object sender, EventArgs e)
        {
            int rowIndex = studDataGridView.Rows.Count - 2;

            DataRow row = dataSet.Tables["students"].NewRow();

            row["username"] = studDataGridView.Rows[rowIndex].Cells["username"].Value;
            row["passw"] = studDataGridView.Rows[rowIndex].Cells["passw"].Value;
            row["firstName"] = studDataGridView.Rows[rowIndex].Cells["firstName"].Value;
            row["secondName"] = studDataGridView.Rows[rowIndex].Cells["secondName"].Value;
            row["patronymic"] = studDataGridView.Rows[rowIndex].Cells["patronymic"].Value;
            row["gender"] = studDataGridView.Rows[rowIndex].Cells["gender"].Value;
            row["address"] = studDataGridView.Rows[rowIndex].Cells["address"].Value;
            row["phoneNum"] = studDataGridView.Rows[rowIndex].Cells["phoneNum"].Value;

            dataSet.Tables["students"].Rows.Add(row);

            
            dataSet.Tables["students"].Rows.RemoveAt(dataSet.Tables["students"].Rows.Count - 1);

            studDataGridView.Rows.RemoveAt(studDataGridView.Rows.Count - 2);
            
            sqlDataAdapter.Update(dataSet, "students");

            newRowAdding = false;

            ReloadData();
        }

        private void editStudButton_Click(object sender, EventArgs e)
        {
            if (studDataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = studDataGridView.SelectedCells[0].RowIndex;

                dataSet.Tables["students"].Rows[rowIndex]["username"] = studDataGridView.Rows[rowIndex].Cells["username"].Value;
                dataSet.Tables["students"].Rows[rowIndex]["passw"] = studDataGridView.Rows[rowIndex].Cells["passw"].Value;
                dataSet.Tables["students"].Rows[rowIndex]["firstName"] = studDataGridView.Rows[rowIndex].Cells["firstName"].Value;
                dataSet.Tables["students"].Rows[rowIndex]["secondName"] = studDataGridView.Rows[rowIndex].Cells["secondName"].Value;
                dataSet.Tables["students"].Rows[rowIndex]["patronymic"] = studDataGridView.Rows[rowIndex].Cells["patronymic"].Value;
                dataSet.Tables["students"].Rows[rowIndex]["gender"] = studDataGridView.Rows[rowIndex].Cells["gender"].Value;
                dataSet.Tables["students"].Rows[rowIndex]["address"] = studDataGridView.Rows[rowIndex].Cells["address"].Value;
                dataSet.Tables["students"].Rows[rowIndex]["phoneNum"] = studDataGridView.Rows[rowIndex].Cells["phoneNum"].Value;

                sqlDataAdapter.Update(dataSet, "students");

                ReloadData();
            }
        }

        private void studDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// 
        /// 
        /// 
        private void openSchedButton_Click(object sender, EventArgs e)
        {
            AdminScheduleForm adminScheduleForm = new AdminScheduleForm();
            adminScheduleForm.Show();
            //this.Hide();
        }

        private void opemGroupsButton_Click(object sender, EventArgs e)
        {
            GroupsForm groupsForm = new GroupsForm();   
            groupsForm.Show();
            //this.Hide();
        }

        private void openScoresButton_Click(object sender, EventArgs e)
        {
            AdminScoresForm scoresForm = new AdminScoresForm();
            scoresForm.Show();
            //this.Hide();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.BackColor = SystemColors.ControlLight;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.BackColor= Color.White;
        }


        private void openSchedButton_MouseEnter(object sender, EventArgs e)
        {
            schedulePic.BackColor = SystemColors.ControlLight;
        }
        private void openSchedButton_MouseLeave(object sender, EventArgs e)
        {
            schedulePic.BackColor= Color.Transparent;
        }


        private void openGroupsButton_MouseEnter(object sender, EventArgs e)
        {
            groupsPic.BackColor = SystemColors.ControlLight;
        }

        private void openGroupsButton_MouseLeave(object sender, EventArgs e)
        {
            groupsPic.BackColor= Color.Transparent;
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

        private void closeLabel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
