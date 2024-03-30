using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class SetInAdminForm : Form
    {
        public SetInAdminForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\universityDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void showPaswBox_CheckedChanged(object sender, EventArgs e)
        {
            passwField.PasswordChar = showPaswBox.Checked ? '\0' : '*';
        }

        private void setUpLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetInForm setUpForm = new SetInForm();
            setUpForm.Show();
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
                    string selectData = "SELECT * FROM admins WHERE username = @username AND password = @password";
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
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неправильно введен логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось подключиться к базе данных" + ex, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
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

        private void SetInAdminForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("логин: admin; пароль: admin123");
        }
    }
}
