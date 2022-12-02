using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        Point lastPoint;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X;
                this.Top += e.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        Boolean CheckFilds()
        {
            if (loginRegField.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return false;
            }
            if (nameRegField.Text == "")
            {
                MessageBox.Show("Введите имя!");
                return false;
            }
            if (surnameRegField.Text == "")
            {
                MessageBox.Show("Введите фамилию!");
                return false;
            }
            if (emailRegField.Text == "")
            {
                MessageBox.Show("Введите email!");
                return false;
            }
            if (addresRegField.Text == "")
            {
                MessageBox.Show("Введите адрес!");
                return false;
            }
            if (numberRegField.Text == "+7 (   )    -  -")
            {
                MessageBox.Show("Введите номер!");
                return false;
            }
            if (dataRegField.Text == "  .  .")
            {
                MessageBox.Show("Введите день рождения!");
                return false;
            }
            if ((passRegField.Text == "") || passRegField.Text.Length < 6)
            {
                MessageBox.Show("Пароль должен быть более 6 символов!");
                return false;
            }
            else
                return true;
        }

        Boolean isUserExists()
        {
            DB dB = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT* FROM club_data.users WHERE login = @uL", dB.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginRegField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return true;
            }
            else
            {
                command = new MySqlCommand($"SELECT* FROM club_data.users WHERE number = @num", dB.GetConnection());
                command.Parameters.Add("@num", MySqlDbType.VarChar).Value = numberRegField.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Пользователь с таким мобильным номером уже существует!");
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!CheckFilds())
                return;

            if (isUserExists())
                return;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `club_data`.`users` (`login`, `password`, `name`, `last_name`, `email`, `addres`, `number`, `data`) VALUES (@login, @password, @name, @last_name, @email, @addres, @number, @data)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginRegField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passRegField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameRegField.Text;
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = surnameRegField.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailRegField.Text;
            command.Parameters.Add("@addres", MySqlDbType.VarChar).Value = addresRegField.Text;
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = numberRegField.Text;
            command.Parameters.Add("@data", MySqlDbType.VarChar).Value = dataRegField.Text;

            db.openConnection();
            
            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно зарегистрирован.");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан, повторите попытку позже...");
            }
            db.closeConnection();
        }

        private void ToLoginButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
