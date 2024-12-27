using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QRCoder;
using System.Net.NetworkInformation;


namespace demo
{
    public partial class FormS : Form
    {
        private DataBase dataBase = new DataBase();
        private int specialistId;

        public FormS(int userId)
        {
            InitializeComponent();

            specialistId = userId;

            LoadAssignedRequests();

            comboBoxStatus.Items.Add("Выполнено");
            comboBoxStatus.Items.Add("В работе");
            comboBoxStatus.Items.Add("Не выполнено");
        }


        private void LoadAssignedRequests()
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "SELECT RequestId, Equipment, IssueType, Description, Status FROM RepairRequests WHERE AssignedTo = @SpecialistId";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@SpecialistId", specialistId);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable requestsTable = new DataTable();
                    adapter.Fill(requestsTable);

                    dataGridViewRequests.DataSource = requestsTable; // Отображаем назначенные заявки в DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке назначенных заявок: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }


        private void UpdateRequestStatus(int requestId, string status)
        {
            try
            {
                dataBase.openConnection(); // Открываем соединение с базой данных

                string query = "UPDATE RepairRequests SET Status = @Status WHERE RequestId = @RequestId AND AssignedTo = @SpecialistId";
                using (SqlCommand command = new SqlCommand(query, dataBase.getConnection()))
                {
                    command.Parameters.AddWithValue("@RequestId", requestId);
                    command.Parameters.AddWithValue("@Status", status);
                    command.Parameters.AddWithValue("@SpecialistId", specialistId);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Статус заявки обновлен успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении статуса заявки: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection(); // Закрываем соединение
            }
        }


        

        private void GenerateQRCode(int requestId)
        {
            // Используйте библиотеку ZXing.Net или другую для генерации QR-кодов
            var qrCodeWriter = new ZXing.BarcodeWriter
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 200,
                    Height = 200
                }
            };

            string qrCodeText = $"https://docs.google.com/forms/d/1tCyVszTVUUWCLpfoN1j1rcMmIfg2tQE2ZIMDXGSkqYY/edit"; 
            var qrCodeImage = qrCodeWriter.Write(qrCodeText);

            // Отображение QR-кода в PictureBox
            pictureBoxQRCode.Image = qrCodeImage;
            MessageBox.Show("QR-код сгенерирован успешно!");
        }

        private void buttonUpdateStatus_Click(object sender, EventArgs e)
        {
            int requestId;
            string status = comboBoxStatus.SelectedItem?.ToString(); // Получаем выбранный статус

            if (!int.TryParse(textBoxRequestId.Text, out requestId))
            {
                MessageBox.Show("Недействительный номер заявки.");
                return;
            }

            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Пожалуйста, выберите статус.");
                return;
            }

            UpdateRequestStatus(requestId, status);
        }

        private void buttonOrderParts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запчасти успешно заказаны!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadAssignedRequests();
        }

        private void buttonGenerateQRCode_Click(object sender, EventArgs e)
        {
            int requestId;
            if (int.TryParse(textBoxRequestId.Text, out requestId))
            {
                GenerateQRCode(requestId);
            }
            else
            {
                MessageBox.Show("Недействительный номер заявки для QR-кода.");
            }
        }
    }
}