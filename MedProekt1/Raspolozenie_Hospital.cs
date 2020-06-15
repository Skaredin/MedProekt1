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
    public partial class Raspolozenie_Hospital : Form
    {
        public Raspolozenie_Hospital()
        {
            InitializeComponent();
        }

        private void Raspolozenie_Hospital_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Priom_Hospital". При необходимости она может быть перемещена или удалена.
            this.priom_HospitalTableAdapter.Fill(this.aProektSK1DataSet.Priom_Hospital);

        }
    }
}
