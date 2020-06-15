namespace MedProekt1
{
    partial class Administracia_Poleklinika
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
            this.Zapisatsa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.aProektSK1DataSet = new MedProekt1.AProektSK1DataSet();
            this.grafik_Prioma_PoleklinikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafik_Prioma_PoleklinikaTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Grafik_Prioma_PoleklinikaTableAdapter();
            this.tableAdapterManager = new MedProekt1.AProektSK1DataSetTableAdapters.TableAdapterManager();
            this.grafik_Prioma_PoleklinikaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_Prioma_PoleklinikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_Prioma_PoleklinikaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Zapisatsa
            // 
            this.Zapisatsa.Location = new System.Drawing.Point(12, 12);
            this.Zapisatsa.Name = "Zapisatsa";
            this.Zapisatsa.Size = new System.Drawing.Size(241, 35);
            this.Zapisatsa.TabIndex = 66;
            this.Zapisatsa.Text = "Записать пациента на приём";
            this.Zapisatsa.UseVisualStyleBackColor = true;
            this.Zapisatsa.Click += new System.EventHandler(this.Zapisatsa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 113);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(320, 24);
            this.label6.TabIndex = 72;
            this.label6.Text = "Полная таблица с расписанием";
            // 
            // aProektSK1DataSet
            // 
            this.aProektSK1DataSet.DataSetName = "AProektSK1DataSet";
            this.aProektSK1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grafik_Prioma_PoleklinikaBindingSource
            // 
            this.grafik_Prioma_PoleklinikaBindingSource.DataMember = "Grafik_Prioma_Poleklinika";
            this.grafik_Prioma_PoleklinikaBindingSource.DataSource = this.aProektSK1DataSet;
            // 
            // grafik_Prioma_PoleklinikaTableAdapter
            // 
            this.grafik_Prioma_PoleklinikaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorTableAdapter = null;
            this.tableAdapterManager.AdresTableAdapter = null;
            this.tableAdapterManager.Analizy_na_obsluzhivaniyeTableAdapter = null;
            this.tableAdapterManager.AnalysisTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Case_historyTableAdapter = null;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Chambers_in_the_OtdeleniiTableAdapter = null;
            this.tableAdapterManager.Composition_of_medical_institutionsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DegreesTableAdapter = null;
            this.tableAdapterManager.DiagnosesTableAdapter = null;
            this.tableAdapterManager.DirectionTableAdapter = null;
            this.tableAdapterManager.Doctors_PatientTableAdapter = null;
            this.tableAdapterManager.Dogovor_na_obsluzhivaniyeTableAdapter = null;
            this.tableAdapterManager.Employee_FeaturesTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.Graphic_artsTableAdapter = null;
            this.tableAdapterManager.Group_diseaseTableAdapter = null;
            this.tableAdapterManager.Hospital_employeesTableAdapter = null;
            this.tableAdapterManager.HospitalizationTableAdapter = null;
            this.tableAdapterManager.HospitalTableAdapter = null;
            this.tableAdapterManager.KorpusaTableAdapter = null;
            this.tableAdapterManager.Lab_ProfilesTableAdapter = null;
            this.tableAdapterManager.LabTableAdapter = null;
            this.tableAdapterManager.Meditsinskoye_ucherezhdeniyeTableAdapter = null;
            this.tableAdapterManager.Mesto_sovmestitelstvaTableAdapter = null;
            this.tableAdapterManager.Operations_historyTableAdapter = null;
            this.tableAdapterManager.OperationTableAdapter = null;
            this.tableAdapterManager.Otdeleniya_v_korpuseTableAdapter = null;
            this.tableAdapterManager.OtdeleniyaTableAdapter = null;
            this.tableAdapterManager.PalataTableAdapter = null;
            this.tableAdapterManager.Patient_Lab_CardTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.Poliklinika_employeeTableAdapter = null;
            this.tableAdapterManager.PoliklinikaTableAdapter = null;
            this.tableAdapterManager.PositionTableAdapter = null;
            this.tableAdapterManager.Prikreplenniye_k_HospitalTableAdapter = null;
            this.tableAdapterManager.ProfileTableAdapter = null;
            this.tableAdapterManager.ReceptionTableAdapter = null;
            this.tableAdapterManager.SovmestitelstvoTableAdapter = null;
            this.tableAdapterManager.StranaTableAdapter = null;
            this.tableAdapterManager.TreatmentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MedProekt1.AProektSK1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vids_of_EmployeesTableAdapter = null;
            this.tableAdapterManager.ZvaniyeTableAdapter = null;
            // 
            // grafik_Prioma_PoleklinikaDataGridView
            // 
            this.grafik_Prioma_PoleklinikaDataGridView.AutoGenerateColumns = false;
            this.grafik_Prioma_PoleklinikaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grafik_Prioma_PoleklinikaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.grafik_Prioma_PoleklinikaDataGridView.DataSource = this.grafik_Prioma_PoleklinikaBindingSource;
            this.grafik_Prioma_PoleklinikaDataGridView.Location = new System.Drawing.Point(12, 140);
            this.grafik_Prioma_PoleklinikaDataGridView.Name = "grafik_Prioma_PoleklinikaDataGridView";
            this.grafik_Prioma_PoleklinikaDataGridView.RowHeadersWidth = 51;
            this.grafik_Prioma_PoleklinikaDataGridView.RowTemplate.Height = 24;
            this.grafik_Prioma_PoleklinikaDataGridView.Size = new System.Drawing.Size(1553, 405);
            this.grafik_Prioma_PoleklinikaDataGridView.TabIndex = 73;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Полеклиника";
            this.dataGridViewTextBoxColumn1.HeaderText = "Полеклиника №";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование больницы";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование больницы";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Страна";
            this.dataGridViewTextBoxColumn21.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Город";
            this.dataGridViewTextBoxColumn22.HeaderText = "Город";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Облась";
            this.dataGridViewTextBoxColumn23.HeaderText = "Облась";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Улица";
            this.dataGridViewTextBoxColumn24.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Дом";
            this.dataGridViewTextBoxColumn25.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Вид графика";
            this.dataGridViewTextBoxColumn5.HeaderText = "Вид графика";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата приёма";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата приёма";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Время приёма";
            this.dataGridViewTextBoxColumn7.HeaderText = "Время приёма";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Кабинет";
            this.dataGridViewTextBoxColumn8.HeaderText = "Кабинет";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Фамилия пациента";
            this.dataGridViewTextBoxColumn9.HeaderText = "Фамилия пациента";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Имя пациента";
            this.dataGridViewTextBoxColumn10.HeaderText = "Имя пациента";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Отчество пациента";
            this.dataGridViewTextBoxColumn11.HeaderText = "Отчество пациента";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Рабочий стаж";
            this.dataGridViewTextBoxColumn12.HeaderText = "Рабочий стаж";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Фамилия врача";
            this.dataGridViewTextBoxColumn13.HeaderText = "Фамилия врача";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Имя врача";
            this.dataGridViewTextBoxColumn14.HeaderText = "Имя врача";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Отчество врача";
            this.dataGridViewTextBoxColumn15.HeaderText = "Отчество врача";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Вид врачебной деятельности1";
            this.dataGridViewTextBoxColumn16.HeaderText = "Вид врачебной деятельности1";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Степень";
            this.dataGridViewTextBoxColumn17.HeaderText = "Степень";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Звание";
            this.dataGridViewTextBoxColumn18.HeaderText = "Звание";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Вспомогательный персонал";
            this.dataGridViewTextBoxColumn19.HeaderText = "Вспомогательный персонал";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn20.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Количество палат";
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество палат";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество занятых палат";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество занятых палат";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Administracia_Poleklinika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 557);
            this.Controls.Add(this.grafik_Prioma_PoleklinikaDataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Zapisatsa);
            this.Name = "Administracia_Poleklinika";
            this.Text = "Administracia_Poleklinika";
            this.Load += new System.EventHandler(this.Administracia_Poleklinika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_Prioma_PoleklinikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_Prioma_PoleklinikaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Zapisatsa;
        private System.Windows.Forms.Label label6;
        private AProektSK1DataSet aProektSK1DataSet;
        private System.Windows.Forms.BindingSource grafik_Prioma_PoleklinikaBindingSource;
        private AProektSK1DataSetTableAdapters.Grafik_Prioma_PoleklinikaTableAdapter grafik_Prioma_PoleklinikaTableAdapter;
        private AProektSK1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView grafik_Prioma_PoleklinikaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}