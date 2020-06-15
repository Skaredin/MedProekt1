namespace MedProekt1
{
    partial class Hospital
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.priomHospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aProektSK1DataSet = new MedProekt1.AProektSK1DataSet();
            this.priom_HospitalTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Priom_HospitalTableAdapter();
            this.Mesto_polikliniki_leibel = new System.Windows.Forms.Label();
            this.номерБольницыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кабинетПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видВрачебнойДеятельностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raspolozenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priomHospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерБольницыDataGridViewTextBoxColumn,
            this.датаПриёмаDataGridViewTextBoxColumn,
            this.времяПриёмаDataGridViewTextBoxColumn,
            this.кабинетПриёмаDataGridViewTextBoxColumn,
            this.фамилияПациентаDataGridViewTextBoxColumn,
            this.имяПациентаDataGridViewTextBoxColumn,
            this.отчествоПациентаDataGridViewTextBoxColumn,
            this.фамилияВрачаDataGridViewTextBoxColumn,
            this.имяВрачаDataGridViewTextBoxColumn,
            this.отчествоВрачаDataGridViewTextBoxColumn,
            this.видВрачебнойДеятельностиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.priomHospitalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1460, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // priomHospitalBindingSource
            // 
            this.priomHospitalBindingSource.DataMember = "Priom_Hospital";
            this.priomHospitalBindingSource.DataSource = this.aProektSK1DataSet;
            // 
            // aProektSK1DataSet
            // 
            this.aProektSK1DataSet.DataSetName = "AProektSK1DataSet";
            this.aProektSK1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priom_HospitalTableAdapter
            // 
            this.priom_HospitalTableAdapter.ClearBeforeFill = true;
            // 
            // Mesto_polikliniki_leibel
            // 
            this.Mesto_polikliniki_leibel.AutoSize = true;
            this.Mesto_polikliniki_leibel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mesto_polikliniki_leibel.Location = new System.Drawing.Point(8, 79);
            this.Mesto_polikliniki_leibel.Name = "Mesto_polikliniki_leibel";
            this.Mesto_polikliniki_leibel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mesto_polikliniki_leibel.Size = new System.Drawing.Size(127, 24);
            this.Mesto_polikliniki_leibel.TabIndex = 65;
            this.Mesto_polikliniki_leibel.Text = "Расписание";
            // 
            // номерБольницыDataGridViewTextBoxColumn
            // 
            this.номерБольницыDataGridViewTextBoxColumn.DataPropertyName = "Номер больницы";
            this.номерБольницыDataGridViewTextBoxColumn.HeaderText = "Номер больницы";
            this.номерБольницыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерБольницыDataGridViewTextBoxColumn.Name = "номерБольницыDataGridViewTextBoxColumn";
            this.номерБольницыDataGridViewTextBoxColumn.Width = 125;
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
            // кабинетПриёмаDataGridViewTextBoxColumn
            // 
            this.кабинетПриёмаDataGridViewTextBoxColumn.DataPropertyName = "Кабинет приёма";
            this.кабинетПриёмаDataGridViewTextBoxColumn.HeaderText = "Кабинет приёма";
            this.кабинетПриёмаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кабинетПриёмаDataGridViewTextBoxColumn.Name = "кабинетПриёмаDataGridViewTextBoxColumn";
            this.кабинетПриёмаDataGridViewTextBoxColumn.Width = 125;
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
            // видВрачебнойДеятельностиDataGridViewTextBoxColumn
            // 
            this.видВрачебнойДеятельностиDataGridViewTextBoxColumn.DataPropertyName = "Вид врачебной деятельности";
            this.видВрачебнойДеятельностиDataGridViewTextBoxColumn.HeaderText = "Вид врачебной деятельности";
            this.видВрачебнойДеятельностиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.видВрачебнойДеятельностиDataGridViewTextBoxColumn.Name = "видВрачебнойДеятельностиDataGridViewTextBoxColumn";
            this.видВрачебнойДеятельностиDataGridViewTextBoxColumn.Width = 125;
            // 
            // Raspolozenie
            // 
            this.Raspolozenie.Location = new System.Drawing.Point(12, 12);
            this.Raspolozenie.Name = "Raspolozenie";
            this.Raspolozenie.Size = new System.Drawing.Size(241, 35);
            this.Raspolozenie.TabIndex = 67;
            this.Raspolozenie.Text = "Местоположение больницы";
            this.Raspolozenie.UseVisualStyleBackColor = true;
            this.Raspolozenie.Click += new System.EventHandler(this.Raspolozenie_Click);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 474);
            this.Controls.Add(this.Raspolozenie);
            this.Controls.Add(this.Mesto_polikliniki_leibel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.Load += new System.EventHandler(this.Hospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priomHospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AProektSK1DataSet aProektSK1DataSet;
        private System.Windows.Forms.BindingSource priomHospitalBindingSource;
        private AProektSK1DataSetTableAdapters.Priom_HospitalTableAdapter priom_HospitalTableAdapter;
        private System.Windows.Forms.Label Mesto_polikliniki_leibel;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерБольницыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кабинетПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видВрачебнойДеятельностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Raspolozenie;
    }
}