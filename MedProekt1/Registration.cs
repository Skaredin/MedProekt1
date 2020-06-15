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


namespace MedProekt1
{
    public partial class Registration : Form
    {
        string con = @"Data Source=SBD\MSSQL;Initial Catalog=AProektSK1;Integrated Security=True";

        public Registration()
        {
            InitializeComponent();
        }

        private void VoitiButton_Click(object sender, EventArgs e)
        {
            // Метод если будут не предвиденные ошибки при выполнение
            try
            {
                //if (textBox4.Text == "create mask" && textBox5.Text == "create mask" && textBox5.Text == "create mask" != create mask )
                //{
                //    MessageBox.Show("В полях (фамилия, имя, отчество) не должны содержаться цифры ");
                //}
                //else

                // Проверка на заполнение полей

                if (LoginTextBox.Text == "" || PassvordTextBox.Text == "" || PassvordTextBox2.Text == "" || Familia.Text == ""|| Ima.Text == "" || Otcestvo.Text == "")
                {
                    MessageBox.Show("Незаполнены поля проверти и повторите попытку");
                }
                // на схожесть паролей
                else if (PassvordTextBox.Text != PassvordTextBox2.Text)
                {
                    MessageBox.Show("Неправильно был ведён пароль (Повтор пароля)");
                }
                else
                {

                    using (SqlConnection sqlCon = new SqlConnection(con))
                    {
                        // Открываем соединение
                        sqlCon.Open();
                        //Соотношение полей в базе
                        SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id_Patients", " ");
                        sqlCmd.Parameters.AddWithValue("@Login", LoginTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Passvord", PassvordTextBox.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Surname", Familia.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Name", Ima.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Middle_name", Otcestvo.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        //Если всё было введено правильно вы водит MessageBox текст "ВЫ зарегистрировались" 
                        MessageBox.Show("ВЫ зарегистрировались");
                        clar();
                        //Переходит на форму Avtorizacia
                        Avtarizacia mainWindow = new Avtarizacia();
                        mainWindow.Show();
                        Hide();
                    }
                }

            }
            catch
            {
                // Если в системе есть ошибка выводить в ошибку 
                MessageBox.Show("Не получены данные");

            }

            void clar()
            {
                LoginTextBox.Text = PassvordTextBox.Text = Familia.Text = Ima.Text = Otcestvo.Text;
            }

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            Avtarizacia mainWindow = new Avtarizacia();
            mainWindow.Show();
            Hide();
        }
    }
}
