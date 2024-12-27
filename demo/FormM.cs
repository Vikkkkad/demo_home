using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace demo
{
    public partial class FormM : Form
    {

        private DataBase dataBase = new DataBase();
        private int currentUserId;
        private int userId;

        public FormM()
        {
            InitializeComponent();

            this.userId = userId;

            this.currentUserId = userId; // Сохраняем Id текущего специалиста
            LoadAllRequests();// Загружаем заявки на ремонт

            LoadSpecialists(); // Загружаем специалистов
        }

             //  Просмотреть все заявки
        private void LoadAllRequests()
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "SELECT RequestId, Equipment, IssueType, Description, DateAdded, Deadline, Status, AssignedTo FROM RepairRequests";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable requestsTable = new DataTable();
                    adapter.Fill(requestsTable);

                    dataGridViewRequests.DataSource = requestsTable; // Отображаем заявки в DataGridView
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

        private void LoadSpecialists()
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "SELECT Id, Username FROM Users WHERE Role = 'Специалист'";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable specialistsTable = new DataTable();
                    adapter.Fill(specialistsTable);

                    comboBoxSpecialists.DataSource = specialistsTable;
                    comboBoxSpecialists.DisplayMember = "Username"; // Отображаем имя специалиста
                    comboBoxSpecialists.ValueMember = "Id"; // Значение, которое будет передаваться
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке специалистов: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }


        // Назначить исполнителя
        private void AssignSpecialist(int requestId, int specialistId)
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "UPDATE RepairRequests SET AssignedTo = @SpecialistId, Status = 'В работе' WHERE RequestId = @RequestId";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.Parameters.AddWithValue("@SpecialistId", specialistId);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Исполнитель назначен успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при назначении исполнителя: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }


        // Продлить срок выполнения заявки
        private void ExtendDeadline(int requestId, DateTime newDeadline)
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "UPDATE RepairRequests SET Deadline = @NewDeadline WHERE RequestId = @RequestId";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.Parameters.AddWithValue("@NewDeadline", newDeadline);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Срок выполнения заявки продлен успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при продлении срока выполнения заявки: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }

        private void btnAssignSpecialist_Click(object sender, EventArgs e)
        {

            int requestId;
            int specialistId;

            // Здесь нужно получить requestId и specialistId из соответствующих текстовых полей или комбобоксов

            if (!int.TryParse(textBoxRequestId.Text, out requestId))
            {
                MessageBox.Show("Недействительный номер заявки.");
                return;
            }

            if (!int.TryParse(comboBoxSpecialists.SelectedValue.ToString(), out specialistId))
            {
                MessageBox.Show("Пожалуйста, выберите специалиста.");
                return;
            }

            AssignSpecialist(requestId, specialistId);

            textBoxRequestId.Clear();
            comboBoxSpecialists.SelectedIndex = -1;
        }

        private void btnExtendDeadline_Click(object sender, EventArgs e)
        {
            int requestId;
            DateTime newDeadline;

            if (!int.TryParse(textBoxRequestId.Text, out requestId))
            {
                MessageBox.Show("Недействительный номер заявки.");
                return;
            }

            newDeadline = dateTimePickerNewDeadline.Value; // Получаем новую дату из DateTimePicker

            ExtendDeadline(requestId, newDeadline);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllRequests();
        }
    }
}

