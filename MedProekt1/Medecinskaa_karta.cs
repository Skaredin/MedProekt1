using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedProekt1
{
    public partial class Medecinskaa_karta : Form
    {
        public Medecinskaa_karta()
        {
            InitializeComponent();
        }

        private void patient_Lab_CardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void patient_Lab_CardBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
       

        }

        private void Medecinskaa_karta_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Laboratornaa_Kartochka_Hacienta_Vid". При необходимости она может быть перемещена или удалена.
            this.laboratornaa_Kartochka_Hacienta_VidTableAdapter.Fill(this.aProektSK1DataSet.Laboratornaa_Kartochka_Hacienta_Vid);

        }

        private void Perva_Click(object sender, EventArgs e)
        {
            laboratornaa_Kartochka_Hacienta_VidBindingSource.MoveFirst();
        }

        private void Pred_Click(object sender, EventArgs e)
        {
            laboratornaa_Kartochka_Hacienta_VidBindingSource.MovePrevious();
        }

        private void sledy_Click(object sender, EventArgs e)
        {

            laboratornaa_Kartochka_Hacienta_VidBindingSource.MoveNext();
        }

      

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.laboratornaa_Kartochka_Hacienta_VidBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aProektSK1DataSet);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            laboratornaa_Kartochka_Hacienta_VidBindingSource.AddNew();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            laboratornaa_Kartochka_Hacienta_VidBindingSource.MoveLast();
        }
    }
}
