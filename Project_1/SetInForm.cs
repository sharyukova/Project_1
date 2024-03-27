using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class SetInForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\universityDB.mdf;Integrated Security=True;Connect Timeout=30");
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
            AdminForm setUpForm = new AdminForm();
            setUpForm.Show();
        }

        private void showPaswBox_CheckedChanged(object sender, EventArgs e)
        {
            passwField.PasswordChar = showPaswBox.Checked ? '\0' : '*';
        }

        private void setInButton_Click(object sender, EventArgs e)
        {
             if (usernameField.Text == "" || passwField.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conn.Open();
                    string selectData = "SELECT * FROM students WHERE username = @username AND passw = @password";
                    using (SqlCommand command = new SqlCommand(selectData, conn))
                    { 
                        command.Parameters.AddWithValue("@username", usernameField.Text.Trim());
                        command.Parameters.AddWithValue("@password", passwField.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Вы успешно вошли в систему!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неправильно введен логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось подключиться к базе данных" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
                
            }
        }
    }
}
