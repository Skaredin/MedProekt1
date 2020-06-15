namespace MedProekt1
{
    partial class Raspolozenie_Hospital
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
            this.label6 = new System.Windows.Forms.Label();
            this.aProektSK1DataSet = new MedProekt1.AProektSK1DataSet();
            this.priom_HospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priom_HospitalTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Priom_HospitalTableAdapter();
            this.tableAdapterManager = new MedProekt1.AProektSK1DataSetTableAdapters.TableAdapterManager();
            this.priom_HospitalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priom_HospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priom_HospitalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 81);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(286, 24);
            this.label6.TabIndex = 72;
            this.label6.Text = "Местоположение больницы";
            // 
            // aProektSK1DataSet
            // 
            this.aProektSK1DataSet.DataSetName = "AProektSK1DataSet";
            this.aProektSK1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // priom_HospitalBindingSource
            // 
            this.priom_HospitalBindingSource.DataMember = "Priom_Hospital";
            this.priom_HospitalBindingSource.DataSource = this.aProektSK1DataSet;
            // 
            // priom_HospitalTableAdapter
            // 
            this.priom_HospitalTableAdapter.ClearBeforeFill = true;
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
            // priom_HospitalDataGridView
            // 
            this.priom_HospitalDataGridView.AutoGenerateColumns = false;
            this.priom_HospitalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priom_HospitalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.priom_HospitalDataGridView.DataSource = this.priom_HospitalBindingSource;
            this.priom_HospitalDataGridView.Location = new System.Drawing.Point(16, 118);
            this.priom_HospitalDataGridView.Name = "priom_HospitalDataGridView";
            this.priom_HospitalDataGridView.RowHeadersWidth = 51;
            this.priom_HospitalDataGridView.RowTemplate.Height = 24;
            this.priom_HospitalDataGridView.Size = new System.Drawing.Size(1456, 377);
            this.priom_HospitalDataGridView.TabIndex = 73;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер больницы";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер больницы";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование больницы";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование больницы";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Страна";
            this.dataGridViewTextBoxColumn20.HeaderText = "Страна";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Город";
            this.dataGridViewTextBoxColumn21.HeaderText = "Город";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Облась";
            this.dataGridViewTextBoxColumn22.HeaderText = "Облась";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Улица";
            this.dataGridViewTextBoxColumn23.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Дом";
            this.dataGridViewTextBoxColumn24.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // Raspolozenie_Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 507);
            this.Controls.Add(this.priom_HospitalDataGridView);
            this.Controls.Add(this.label6);
            this.Name = "Raspolozenie_Hospital";
            this.Text = "Местоположение больницы";
            this.Load += new System.EventHandler(this.Raspolozenie_Hospital_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priom_HospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priom_HospitalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private AProektSK1DataSet aProektSK1DataSet;
        private System.Windows.Forms.BindingSource priom_HospitalBindingSource;
        private AProektSK1DataSetTableAdapters.Priom_HospitalTableAdapter priom_HospitalTableAdapter;
        private AProektSK1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView priom_HospitalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}