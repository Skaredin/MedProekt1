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
    public partial class Administracia_Poleklinika : Form
    {
        public Administracia_Poleklinika()
        {
            InitializeComponent();
        }

        private void Zapisatsa_Click(object sender, EventArgs e)
        {
            Zapis_Polikliniki zapis_Polikliniki = new Zapis_Polikliniki();
            zapis_Polikliniki.Show();

        }

        private void Raspolozenie_Click(object sender, EventArgs e)
        {
            Raspolozenie_Polekliniki raspolozenie_Polekliniki = new Raspolozenie_Polekliniki();
            raspolozenie_Polekliniki.Show();
        }

        private void Administracia_Poleklinika_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Grafik_Prioma_Poleklinika". При необходимости она может быть перемещена или удалена.
            this.grafik_Prioma_PoleklinikaTableAdapter.Fill(this.aProektSK1DataSet.Grafik_Prioma_Poleklinika);


          


        }

       
    }
}
