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
    public partial class Oformit_dogovor : Form
    {
        public Oformit_dogovor()
        {
            InitializeComponent();
        }

        private void Oformit_dogovor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aProektSK1DataSet.Dogovor_na_Obsluzhivaniye_Vid". При необходимости она может быть перемещена или удалена.
            this.dogovor_na_Obsluzhivaniye_VidTableAdapter.Fill(this.aProektSK1DataSet.Dogovor_na_Obsluzhivaniye_Vid);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dogovor_na_Obsluzhivaniye_VidBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aProektSK1DataSet);
                MessageBox.Show("Успешно сохранено");
            }
            catch
            {
                MessageBox.Show("Что то пошло не так");

            }
        }
    }
}
