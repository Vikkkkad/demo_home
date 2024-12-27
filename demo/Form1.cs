using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo
{
    public partial class Form1 : Form
    {
        private DataBase database; // Объявляем переменную для соединения с БД
        private int currentUserId;

        public Form1()
        {
            InitializeComponent();
            database = new DataBase();

            // Добавляем роли в ComboBox
            cbRole.Items.Add("Клиент");
            cbRole.Items.Add("Менеджер");
            cbRole.Items.Add("Специалист");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверяем, выбрана ли роль
            if (cbRole.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите роль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = cbRole.SelectedItem.ToString();

            if (ValidateUser(username, password, role))
            {
                // Открываем соответствующую форму в зависимости от роли
                Form nextForm;
                switch (role)
                {
                    case "Клиент":
                        nextForm = new FormC(currentUserId); // Форма для клиента
                        break;
                    case "Менеджер":
                        nextForm = new FormM(); // Форма для менеджера
                        break;
                    case "Специалист":
                        nextForm = new FormS(currentUserId); // Форма для специалиста
                        break;
                    default:
                        MessageBox.Show("Неизвестная роль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                this.Hide(); // Скрываем форму входа
                nextForm.Show(); // Открываем соответствующую форму
            }
            else
            {
                MessageBox.Show("Неправильный логин, пароль или роль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUser(string username, string password, string role)
        {
            bool isValid = false;

            // Открываем соединение с базой данных
            database.openConnection();

            // SQL-запрос для проверки учетных данных
            string query = "SELECT Id FROM Users WHERE Username = @username AND Password = @password AND Role = @role";
            SqlCommand command = new SqlCommand(query, database.getConnection());
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@role", role);

            try
            {
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    currentUserId = Convert.ToInt32(result); // Получаем UserId
                    isValid = true;
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Закрываем соединение
                database.closeConnection();
            }

            return isValid;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы Reg
            Reg registrationForm = new Reg();

            // Скрываем текущую форму, если необходимо
            this.Hide();

            // Показываем форму Reg
            registrationForm.Show();
        }
    }
}

