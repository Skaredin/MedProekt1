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
using System.Data;

namespace MedProekt1
{
    public partial class Avtarizacia : Form
    {
        public Avtarizacia()
        {
            InitializeComponent();
        }

        private void Avtarizacia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Grafik_Prioma_Poleklinika". При необходимости она может быть перемещена или удалена.
            this.grafik_Prioma_PoleklinikaTableAdapter.Fill(this.aProektSK1DataSet.Grafik_Prioma_Poleklinika);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Prikreplenniye_k_Hospital". При необходимости она может быть перемещена или удалена.
            this.prikreplenniye_k_HospitalTableAdapter.Fill(this.aProektSK1DataSet.Prikreplenniye_k_Hospital);

        }

        private void VoitiButton_Click(object sender, EventArgs e)
        {
            // Метод если будут не предвиденные ошибки при выполнение
            try
            {




                // Подключение к базе
                string con = @"Data Source=SBD\MSSQL;Initial Catalog=AProektSK1;Integrated Security=True";

                string com = " Select * From Employees Where login='" + LoginTextBox.Text.Trim() + "' and passvord = '" + PassvordTextBox.Text.Trim() + "'";

                string com1 = " Select * From Patients Where login='" + LoginTextBox.Text.Trim() + "' and passvord = '" + PassvordTextBox.Text.Trim() + "'";

                string com2 = " Select * From Administrator Where login='" + LoginTextBox.Text.Trim() + "' and passvord = '" + PassvordTextBox.Text.Trim() + "'";


                if (Login.Text == "" || Passvord.Text == "")
                {
                    MessageBox.Show("Незаполнены поля проверти и повторите попытку");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(con))
                    {
                        // Открываем соединение
                        connection.Open();
                        //Задаем переменные
                        SqlDataAdapter adapter = new SqlDataAdapter(com, connection);
                        SqlDataAdapter adapter1 = new SqlDataAdapter(com1, connection);
                        SqlDataAdapter adapter2 = new SqlDataAdapter(com2, connection);
                        DataTable table = new DataTable();
                        DataTable table1 = new DataTable();
                        DataTable table2 = new DataTable();
                        adapter.Fill(table);
                        adapter1.Fill(table1);
                        adapter2.Fill(table2);


                        // Проверка на Executor
                        if (table.Rows.Count == 1)
                        {

                            Employees employees = new Employees();
                            employees.Show();
                           
                            Hide();
                            MessageBox.Show("Хорошей работы");

                        }
                        // Проверка на Patients

                        else if (table1.Rows.Count == 1)
                        {
                            Patients patients = new Patients();
                            patients.Show();

                            Hide();
                            MessageBox.Show("Вход прошол успешно");
                        }

                        else if (table2.Rows.Count == 1)
                        {
                            Administrator administrator = new Administrator();
                            administrator.Show();

                            Hide();
                            MessageBox.Show("Хорошей работы администратор ");
                        }
                        else
                        {
                            MessageBox.Show("Неправельный логин или пароль");
                        }
                    }
                }

            }
            catch
            {// Если в системе есть ошибка выводить в ошибку 
                MessageBox.Show("Не получены данные");

            }
        }

        private void RegistraciaButton_Click(object sender, EventArgs e)
        {

            Registration registration = new Registration();
            registration.Show();
            Hide();
        }
    }
}
