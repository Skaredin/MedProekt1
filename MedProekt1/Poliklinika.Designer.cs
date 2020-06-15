namespace MedProekt1
{
    partial class Poliklinika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.aProektSK1DataSet = new MedProekt1.AProektSK1DataSet();
            this.grafikPriomaPoleklinikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafik_Prioma_PoleklinikaTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Grafik_Prioma_PoleklinikaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.полеклиникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кабинетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видВрачебнойДеятельности1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вспомогательныйПерсоналDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grafikPriomaPoleklinikaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aProektSK1DataSet1 = new MedProekt1.AProektSK1DataSet();
            this.Mesto_polikliniki_leibel = new System.Windows.Forms.Label();
            this.Raspolozenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikPriomaPoleklinikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikPriomaPoleklinikaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // aProektSK1DataSet
            // 
            this.aProektSK1DataSet.DataSetName = "AProektSK1DataSet";
            this.aProektSK1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grafikPriomaPoleklinikaBindingSource
            // 
            this.grafikPriomaPoleklinikaBindingSource.DataMember = "Grafik_Prioma_Poleklinika";
            this.grafikPriomaPoleklinikaBindingSource.DataSource = this.aProektSK1DataSet;
            // 
            // grafik_Prioma_PoleklinikaTableAdapter
            // 
            this.grafik_Prioma_PoleklinikaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.полеклиникаDataGridViewTextBoxColumn,
            this.датаПриёмаDataGridViewTextBoxColumn,
            this.времяПриёмаDataGridViewTextBoxColumn,
            this.кабинетDataGridViewTextBoxColumn,
            this.фамилияПациентаDataGridViewTextBoxColumn,
            this.имяПациентаDataGridViewTextBoxColumn,
            this.отчествоПациентаDataGridViewTextBoxColumn,
            this.фамилияВрачаDataGridViewTextBoxColumn,
            this.имяВрачаDataGridViewTextBoxColumn,
            this.отчествоВрачаDataGridViewTextBoxColumn,
            this.видВрачебнойДеятельности1DataGridViewTextBoxColumn,
            this.вспомогательныйПерсоналDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.grafikPriomaPoleklinikaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1450, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // полеклиникаDataGridViewTextBoxColumn
            // 
            this.полеклиникаDataGridViewTextBoxColumn.DataPropertyName = "Полеклиника";
            this.полеклиникаDataGridViewTextBoxColumn.HeaderText = "Полеклиника №";
            this.полеклиникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.полеклиникаDataGridViewTextBoxColumn.Name = "полеклиникаDataGridViewTextBoxColumn";
            this.полеклиникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаПриёмаDataGridViewTextBoxColumn
            // 
            this.датаПриёмаDataGridViewTextBoxColumn.DataPropertyName = "Дата приёма";
            this.датаПриёмаDataGridViewTextBoxColumn.HeaderText = "Дата приёма";
            this.датаПриёмаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПриёмаDataGridViewTextBoxColumn.Name = "датаПриёмаDataGridViewTextBoxColumn";
            this.датаПриёмаDataGridViewTextBoxColumn.Width = 125;
            // 
            // времяПриёмаDataGridViewTextBoxColumn
            // 
            this.времяПриёмаDataGridViewTextBoxColumn.DataPropertyName = "Время приёма";
            this.времяПриёмаDataGridViewTextBoxColumn.HeaderText = "Время приёма";
            this.времяПриёмаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяПриёмаDataGridViewTextBoxColumn.Name = "времяПриёмаDataGridViewTextBoxColumn";
            this.времяПриёмаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кабинетDataGridViewTextBoxColumn
            // 
            this.кабинетDataGridViewTextBoxColumn.DataPropertyName = "Кабинет";
            this.кабинетDataGridViewTextBoxColumn.HeaderText = "Кабинет";
            this.кабинетDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кабинетDataGridViewTextBoxColumn.Name = "кабинетDataGridViewTextBoxColumn";
            this.кабинетDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияПациентаDataGridViewTextBoxColumn
            // 
            this.фамилияПациентаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия пациента";
            this.фамилияПациентаDataGridViewTextBoxColumn.HeaderText = "Фамилия пациента";
            this.фамилияПациентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияПациентаDataGridViewTextBoxColumn.Name = "фамилияПациентаDataGridViewTextBoxColumn";
            this.фамилияПациентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяПациентаDataGridViewTextBoxColumn
            // 
            this.имяПациентаDataGridViewTextBoxColumn.DataPropertyName = "Имя пациента";
            this.имяПациентаDataGridViewTextBoxColumn.HeaderText = "Имя пациента";
            this.имяПациентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяПациентаDataGridViewTextBoxColumn.Name = "имяПациентаDataGridViewTextBoxColumn";
            this.имяПациентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоПациентаDataGridViewTextBoxColumn
            // 
            this.отчествоПациентаDataGridViewTextBoxColumn.DataPropertyName = "Отчество пациента";
            this.отчествоПациентаDataGridViewTextBoxColumn.HeaderText = "Отчество пациента";
            this.отчествоПациентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоПациентаDataGridViewTextBoxColumn.Name = "отчествоПациентаDataGridViewTextBoxColumn";
            this.отчествоПациентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияВрачаDataGridViewTextBoxColumn
            // 
            this.фамилияВрачаDataGridViewTextBoxColumn.DataPropertyName = "Фамилия врача";
            this.фамилияВрачаDataGridViewTextBoxColumn.HeaderText = "Фамилия врача";
            this.фамилияВрачаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияВрачаDataGridViewTextBoxColumn.Name = "фамилияВрачаDataGridViewTextBoxColumn";
            this.фамилияВрачаDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяВрачаDataGridViewTextBoxColumn
            // 
            this.имяВрачаDataGridViewTextBoxColumn.DataPropertyName = "Имя врача";
            this.имяВрачаDataGridViewTextBoxColumn.HeaderText = "Имя врача";
            this.имяВрачаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяВрачаDataGridViewTextBoxColumn.Name = "имяВрачаDataGridViewTextBoxColumn";
            this.имяВрачаDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоВрачаDataGridViewTextBoxColumn
            // 
            this.отчествоВрачаDataGridViewTextBoxColumn.DataPropertyName = "Отчество врача";
            this.отчествоВрачаDataGridViewTextBoxColumn.HeaderText = "Отчество врача";
            this.отчествоВрачаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоВрачаDataGridViewTextBoxColumn.Name = "отчествоВрачаDataGridViewTextBoxColumn";
            this.отчествоВрачаDataGridViewTextBoxColumn.Width = 125;
            // 
            // видВрачебнойДеятельности1DataGridViewTextBoxColumn
            // 
            this.видВрачебнойДеятельности1DataGridViewTextBoxColumn.DataPropertyName = "Вид врачебной деятельности1";
            this.видВрачебнойДеятельности1DataGridViewTextBoxColumn.HeaderText = "Вид врачебной деятельности";
            this.видВрачебнойДеятельности1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.видВрачебнойДеятельности1DataGridViewTextBoxColumn.Name = "видВрачебнойДеятельности1DataGridViewTextBoxColumn";
            this.видВрачебнойДеятельности1DataGridViewTextBoxColumn.Width = 125;
            // 
            // вспомогательныйПерсоналDataGridViewTextBoxColumn
            // 
            this.вспомогательныйПерсоналDataGridViewTextBoxColumn.DataPropertyName = "Вспомогательный персонал";
            this.вспомогательныйПерсоналDataGridViewTextBoxColumn.HeaderText = "Вспомогательный персонал";
            this.вспомогательныйПерсоналDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.вспомогательныйПерсоналDataGridViewTextBoxColumn.Name = "вспомогательныйПерсоналDataGridViewTextBoxColumn";
            this.вспомогательныйПерсоналDataGridViewTextBoxColumn.Width = 125;
            // 
            // grafikPriomaPoleklinikaBindingSource1
            // 
            this.grafikPriomaPoleklinikaBindingSource1.DataMember = "Grafik_Prioma_Poleklinika";
            this.grafikPriomaPoleklinikaBindingSource1.DataSource = this.aProektSK1DataSet1;
            // 
            // aProektSK1DataSet1
            // 
            this.aProektSK1DataSet1.DataSetName = "AProektSK1DataSet";
            this.aProektSK1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Mesto_polikliniki_leibel
            // 
            this.Mesto_polikliniki_leibel.AutoSize = true;
            this.Mesto_polikliniki_leibel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mesto_polikliniki_leibel.Location = new System.Drawing.Point(12, 60);
            this.Mesto_polikliniki_leibel.Name = "Mesto_polikliniki_leibel";
            this.Mesto_polikliniki_leibel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mesto_polikliniki_leibel.Size = new System.Drawing.Size(127, 24);
            this.Mesto_polikliniki_leibel.TabIndex = 64;
            this.Mesto_polikliniki_leibel.Text = "Расписание";
            // 
            // Raspolozenie
            // 
            this.Raspolozenie.Location = new System.Drawing.Point(12, 12);
            this.Raspolozenie.Name = "Raspolozenie";
            this.Raspolozenie.Size = new System.Drawing.Size(241, 35);
            this.Raspolozenie.TabIndex = 65;
            this.Raspolozenie.Text = "Место положение поликлиники";
            this.Raspolozenie.UseVisualStyleBackColor = true;
            this.Raspolozenie.Click += new System.EventHandler(this.Raspolozenie_Click);
            // 
            // Poliklinika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 474);
            this.Controls.Add(this.Raspolozenie);
            this.Controls.Add(this.Mesto_polikliniki_leibel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Poliklinika";
            this.Text = "Поликлиника";
            this.Load += new System.EventHandler(this.Poliklinika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikPriomaPoleklinikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikPriomaPoleklinikaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AProektSK1DataSet aProektSK1DataSet;
        private System.Windows.Forms.BindingSource grafikPriomaPoleklinikaBindingSource;
        private AProektSK1DataSetTableAdapters.Grafik_Prioma_PoleklinikaTableAdapter grafik_Prioma_PoleklinikaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AProektSK1DataSet aProektSK1DataSet1;
        private System.Windows.Forms.BindingSource grafikPriomaPoleklinikaBindingSource1;
        private System.Windows.Forms.Label Mesto_polikliniki_leibel;
        private System.Windows.Forms.DataGridViewTextBoxColumn полеклиникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кабинетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видВрачебнойДеятельности1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn вспомогательныйПерсоналDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Raspolozenie;
    }
}