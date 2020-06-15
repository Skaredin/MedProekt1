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
    public partial class Zapis_Hospital : Form
    {
        public Zapis_Hospital()
        {
            InitializeComponent();
        }

        private void Zapis_Hospital_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Priom_Hospital". При необходимости она может быть перемещена или удалена.
            this.priom_HospitalTableAdapter.Fill(this.aProektSK1DataSet.Priom_Hospital);

        }

        private void Perva_Click(object sender, EventArgs e)
        {
            priom_HospitalBindingSource.MoveFirst();
        }

        private void Pred_Click(object sender, EventArgs e)
        {
            priom_HospitalBindingSource.MovePrevious();
        }

        private void sledy_Click(object sender, EventArgs e)
        {

            priom_HospitalBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priom_HospitalBindingSource.MoveLast();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.priom_HospitalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aProektSK1DataSet);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            priom_HospitalBindingSource.AddNew();
        }

       
    }
}
