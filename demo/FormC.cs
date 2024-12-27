using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace demo
{
    public partial class FormC : Form
    {
        DataBase dataBase = new DataBase();
        private int userId;

        public FormC(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Сохраняем Id текущего пользователя

            comboBox1.Items.Add("Шум");
            comboBox1.Items.Add("Ошибка");
            comboBox1.Items.Add("Не включается");

            LoadMyRequests();

        }

        private bool DoesRequestIdExist(int requestId)
        {
            try
            {
                dataBase.openConnection(); 

                string query = "SELECT COUNT(*) FROM RepairRequests WHERE RequestId = @RequestId AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке номера заявки: " + ex.Message);
                return false;
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Сбор данных из текстовых полей и комбобокса
            int requestId;
            DateTime requestDate;

            // Проверка корректности ввода для RequestId и Date
            if (!int.TryParse(textBox1.Text, out requestId))
            {
                MessageBox.Show("Недействительный номер заявки. Пожалуйста, введите корректный номер.");
                return;
            }

            if (DoesRequestIdExist(requestId))
            {
                MessageBox.Show("Заявка с таким номером уже существует. Пожалуйста, введите другой номер заявки.");
                return;
            }

            if (!DateTime.TryParse(textBox2.Text, out requestDate))
            {
                MessageBox.Show("Недействительная дата. Пожалуйста, введите корректную дату.");
                return;
            }

            string equipment = textBox3.Text.Trim();
            string description = textBox4.Text.Trim();
            string contactInfo = textBox5.Text.Trim();
            string issueType = comboBox1.SelectedItem?.ToString(); // Получаем выбранный тип неисправности

            if (string.IsNullOrEmpty(equipment) ||
                string.IsNullOrEmpty(description) ||
                string.IsNullOrEmpty(contactInfo) ||
                string.IsNullOrEmpty(issueType))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            // Вставка данных в базу данных
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                // SQL-запрос для вставки
                string query = "INSERT INTO RepairRequests (UserId, RequestId, Equipment, IssueType, Description, ContactInfo, DateAdded) " +
                            "VALUES (@UserId, @RequestId, @Equipment, @IssueType, @Description, @ContactInfo, @DateAdded)";

                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@UserId", userId); // Используем сохраненный UserId
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.Parameters.AddWithValue("@Equipment", equipment);
                    command.Parameters.AddWithValue("@IssueType", issueType);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@ContactInfo", contactInfo);
                    command.Parameters.AddWithValue("@DateAdded", requestDate);

                    // Выполняем команду
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запрос успешно добавлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении запроса: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
        }


        private void LoadMyRequests()
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "SELECT RequestId, Equipment, IssueType, Description, DateAdded, Status FROM RepairRequests WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable requestsTable = new DataTable();
                    adapter.Fill(requestsTable);

                    dataGridView1.DataSource = requestsTable; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке заявок: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }

        private void CheckRequestStatus(int requestId)
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "SELECT Status FROM RepairRequests WHERE RequestId = @RequestId AND UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    var status = command.ExecuteScalar();

                    if (status != null)
                    {
                        MessageBox.Show($"Статус заявки {requestId}: {status}");
                    }
                    else
                    {
                        MessageBox.Show("Заявка не найдена или вы не имеете доступа к ней.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при проверке статуса заявки: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }

        private void SubmitFeedback(int requestId, string feedback)
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "INSERT INTO Feedback (RequestId, UserId, FeedbackText) VALUES (@RequestId, @UserId, @FeedbackText)";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.Parameters.AddWithValue("@FeedbackText", feedback);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Отзыв успешно оставлен!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при оставлении отзыва: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }

        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            string feedback = textBoxFeedback.Text.Trim(); // Получаем текст отзыва из текстового поля

            // Проверяем, что отзыв не пустой
            if (string.IsNullOrEmpty(feedback))
            {
                MessageBox.Show("Пожалуйста, введите ваш отзыв.");
                return;
            }

            
            int requestId;

            if (!int.TryParse(textBoxRequestId.Text, out requestId))
            {
                MessageBox.Show("Недействительный номер заявки. Пожалуйста, введите корректный номер.");
                return;
            }

            // Теперь вызываем метод SubmitFeedback
            SubmitFeedback(requestId, feedback);

            textBoxFeedback.Clear();
            textBoxRequestId.Clear();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            // Получаем номер заявки из текстового поля
            int requestId;

            // Проверяем, является ли введенное значение корректным числом
            if (!int.TryParse(textBoxRequestId.Text, out requestId))
            {
                MessageBox.Show("Пожалуйста, введите корректный номер заявки.");
                return;
            }

            // Вызываем метод для проверки статуса заявки
            CheckRequestStatus(requestId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadMyRequests();
        }
    }
}

