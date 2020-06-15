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
    public partial class Zapis_Polikliniki : Form
    {
        public Zapis_Polikliniki()
        {
            InitializeComponent();

           
           
           
           
        }

        private void Zapis_Polikliniki_Load(object sender, EventArgs e)
        {
       
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Grafik_Prioma_Poleklinika". При необходимости она может быть перемещена или удалена.
            this.grafik_Prioma_PoleklinikaTableAdapter.Fill(this.aProektSK1DataSet.Grafik_Prioma_Poleklinika);
            
        }

      

        private void Perva_Click(object sender, EventArgs e)
        {
            grafik_Prioma_PoleklinikaBindingSource.MoveFirst();
        }

        private void Pred_Click(object sender, EventArgs e)
        {
            grafik_Prioma_PoleklinikaBindingSource.MovePrevious();
        }

        private void sledy_Click(object sender, EventArgs e)
        {
           
            grafik_Prioma_PoleklinikaBindingSource.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grafik_Prioma_PoleklinikaBindingSource.MoveLast();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grafik_Prioma_PoleklinikaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aProektSK1DataSet);
            
        }

        public void Kolvo__ne_zanatix_palat_TextChanged(object sender, EventArgs e)
        {
           
        }

        //int second = 0;
        //int n = 0;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
            
        //    for (int i = 1; i == n; i++)
        //    {
        //        second++;
        //        if (second == 1)
        //        {
        //            Kol_vo1_Click(null, null);
        //        }
        //    }

        //}
        private void Kol_vo1_Click(object sender, EventArgs e)
        {

          

        }

        private void Add_Click(object sender, EventArgs e)
        {
            grafik_Prioma_PoleklinikaBindingSource.AddNew();
        }
    }
}
