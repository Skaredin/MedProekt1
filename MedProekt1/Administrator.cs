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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void поликлиникаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Administracia_Poleklinika administracia_Poleklinika = new Administracia_Poleklinika();
            administracia_Poleklinika.Show();
            
        }

        private void записатьПациентаНаПриёмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapis_Polikliniki zapis_Polikliniki = new Zapis_Polikliniki();
            zapis_Polikliniki.Show();

        }

        private void договорНаОбслуживаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dogovor_na_obsluzivanie dogovor_Na_Obsluzivanie = new Dogovor_na_obsluzivanie();
            dogovor_Na_Obsluzivanie.Show();
        }

        private void больницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zapis_Hospital zapis_Hospital = new Zapis_Hospital();
            zapis_Hospital.Show();
        }
    }
}
