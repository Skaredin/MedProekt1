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
    public partial class Dogovor_na_obsluzivanie : Form
    {
        public Dogovor_na_obsluzivanie()
        {
            InitializeComponent();
        }

        private void Dogovor_na_obsluzivanie_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Dogovor_na_Obsluzhivaniye_Vid". При необходимости она может быть перемещена или удалена.
            this.dogovor_na_Obsluzhivaniye_VidTableAdapter.Fill(this.aProektSK1DataSet.Dogovor_na_Obsluzhivaniye_Vid);

        }

        private void Oformit_dogovor_Click(object sender, EventArgs e)
        {
            Oformit_dogovor oformit_dogovor = new Oformit_dogovor();
            oformit_dogovor.Show();
        }
    }
}
