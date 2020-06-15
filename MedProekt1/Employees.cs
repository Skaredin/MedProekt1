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
    public partial class Employees : Form
    {
        string con = @"Data Source=SBD\MSSQL;Initial Catalog=AProektSK1;Integrated Security=True";
        public Employees()
        {
            InitializeComponent();
        }

        private void ukfdyfzToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            //Properties.Settings.Default.Polzovatel = ;
            //Properties.Settings.Default.Save();
        }

        private void больницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital();
             hospital.Show();

        }

        private void поликлиникаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Poliklinika poliklinika = new Poliklinika();
            poliklinika.Show();
        }

        private void медецинскаяКарточкаПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medecinskaa_karta medecinskaa_Karta = new Medecinskaa_karta();
            medecinskaa_Karta.Show();
        }
    }
}
