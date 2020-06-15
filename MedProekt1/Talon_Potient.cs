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

namespace MedProekt1
{
    public partial class Talon_Potient : Form
    {
        public Talon_Potient()
        {
            InitializeComponent();
        }
        string con = @"Data Source=SBD\MSSQL;Initial Catalog=AProektSK1;Integrated Security=True";
        private void Talon_Potient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Priem_Patienta_Vid". При необходимости она может быть перемещена или удалена.
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Grafik_Prioma_Poleklinika". При необходимости она может быть перемещена или удалена.
            this.grafik_Prioma_PoleklinikaTableAdapter.Fill(this.aProektSK1DataSet.Grafik_Prioma_Poleklinika);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.grafik_Prioma_PoleklinikaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aProektSK1DataSet);
              
            }
            catch
            { 
            
            
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            grafik_Prioma_PoleklinikaBindingSource.AddNew();
        }
    }
}
