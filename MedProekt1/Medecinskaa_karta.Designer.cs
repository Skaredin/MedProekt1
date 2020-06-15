namespace MedProekt1
{
    partial class Medecinskaa_karta
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
            System.Windows.Forms.Label номер_пациентаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label время_приёмаLabel;
            System.Windows.Forms.Label дата_приёма_пациентаLabel;
            System.Windows.Forms.Label дата_окончания_леченияLabel;
            System.Windows.Forms.Label назначениеLabel;
            System.Windows.Forms.Label описаниеLabel;
            this.aProektSK1DataSet = new MedProekt1.AProektSK1DataSet();
            this.tableAdapterManager = new MedProekt1.AProektSK1DataSetTableAdapters.TableAdapterManager();
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratornaa_Kartochka_Hacienta_VidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номер_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.время_приёмаMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.дата_приёма_пациентаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_окончания_леченияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.назначениеTextBox = new System.Windows.Forms.TextBox();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.Mesto_polikliniki_leibel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sledy = new System.Windows.Forms.Button();
            this.Pred = new System.Windows.Forms.Button();
            this.Perva = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.laboratornaa_Kartochka_Hacienta_VidTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Laboratornaa_Kartochka_Hacienta_VidTableAdapter();
            номер_пациентаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            время_приёмаLabel = new System.Windows.Forms.Label();
            дата_приёма_пациентаLabel = new System.Windows.Forms.Label();
            дата_окончания_леченияLabel = new System.Windows.Forms.Label();
            назначениеLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratornaa_Kartochka_Hacienta_VidDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratornaa_Kartochka_Hacienta_VidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номер_пациентаLabel
            // 
            номер_пациентаLabel.AutoSize = true;
            номер_пациентаLabel.Location = new System.Drawing.Point(492, 76);
            номер_пациентаLabel.Name = "номер_пациентаLabel";
            номер_пациентаLabel.Size = new System.Drawing.Size(122, 17);
            номер_пациентаLabel.TabIndex = 2;
            номер_пациентаLabel.Text = "Номер пациента:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(492, 104);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(74, 17);
            фамилияLabel.TabIndex = 4;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(492, 132);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(39, 17);
            имяLabel.TabIndex = 6;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(492, 160);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(75, 17);
            отчествоLabel.TabIndex = 8;
            отчествоLabel.Text = "Отчество:";
            // 
            // время_приёмаLabel
            // 
            время_приёмаLabel.AutoSize = true;
            время_приёмаLabel.Location = new System.Drawing.Point(28, 76);
            время_приёмаLabel.Name = "время_приёмаLabel";
            время_приёмаLabel.Size = new System.Drawing.Size(107, 17);
            время_приёмаLabel.TabIndex = 10;
            время_приёмаLabel.Text = "Время приёма:";
            // 
            // дата_приёма_пациентаLabel
            // 
            дата_приёма_пациентаLabel.AutoSize = true;
            дата_приёма_пациентаLabel.Location = new System.Drawing.Point(28, 105);
            дата_приёма_пациентаLabel.Name = "дата_приёма_пациентаLabel";
            дата_приёма_пациентаLabel.Size = new System.Drawing.Size(166, 17);
            дата_приёма_пациентаLabel.TabIndex = 12;
            дата_приёма_пациентаLabel.Text = "Дата приёма пациента:";
            // 
            // дата_окончания_леченияLabel
            // 
            дата_окончания_леченияLabel.AutoSize = true;
            дата_окончания_леченияLabel.Location = new System.Drawing.Point(28, 133);
            дата_окончания_леченияLabel.Name = "дата_окончания_леченияLabel";
            дата_окончания_леченияLabel.Size = new System.Drawing.Size(181, 17);
            дата_окончания_леченияLabel.TabIndex = 14;
            дата_окончания_леченияLabel.Text = "Дата окончания лечения:";
            // 
            // назначениеLabel
            // 
            назначениеLabel.AutoSize = true;
            назначениеLabel.Location = new System.Drawing.Point(28, 241);
            назначениеLabel.Name = "назначениеLabel";
            назначениеLabel.Size = new System.Drawing.Size(93, 17);
            назначениеLabel.TabIndex = 16;
            назначениеLabel.Text = "Назначение:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(28, 269);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(78, 17);
            описаниеLabel.TabIndex = 18;
            описаниеLabel.Text = "Описание:";
            // 
            // aProektSK1DataSet
            // 
            this.aProektSK1DataSet.DataSetName = "AProektSK1DataSet";
            this.aProektSK1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // laboratornaa_Kartochka_Hacienta_VidDataGridView
            // 
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.AutoGenerateColumns = false;
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.DataSource = this.laboratornaa_Kartochka_Hacienta_VidBindingSource;
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.Location = new System.Drawing.Point(12, 351);
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.Name = "laboratornaa_Kartochka_Hacienta_VidDataGridView";
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.RowHeadersWidth = 51;
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.RowTemplate.Height = 24;
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.Size = new System.Drawing.Size(1237, 176);
            this.laboratornaa_Kartochka_Hacienta_VidDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер пациента";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер пациента";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Время приёма";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время приёма";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата приёма пациента";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата приёма пациента";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Дата окончания лечения";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата окончания лечения";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Назначение";
            this.dataGridViewTextBoxColumn8.HeaderText = "Назначение";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn9.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // laboratornaa_Kartochka_Hacienta_VidBindingSource
            // 
            this.laboratornaa_Kartochka_Hacienta_VidBindingSource.DataMember = "Laboratornaa_Kartochka_Hacienta_Vid";
            this.laboratornaa_Kartochka_Hacienta_VidBindingSource.DataSource = this.aProektSK1DataSet;
            // 
            // номер_пациентаTextBox
            // 
            this.номер_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Номер пациента", true));
            this.номер_пациентаTextBox.Location = new System.Drawing.Point(679, 73);
            this.номер_пациентаTextBox.Name = "номер_пациентаTextBox";
            this.номер_пациентаTextBox.Size = new System.Drawing.Size(200, 22);
            this.номер_пациентаTextBox.TabIndex = 3;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(679, 101);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(200, 22);
            this.фамилияTextBox.TabIndex = 5;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(679, 129);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(200, 22);
            this.имяTextBox.TabIndex = 7;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(679, 157);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(200, 22);
            this.отчествоTextBox.TabIndex = 9;
            // 
            // время_приёмаMaskedTextBox
            // 
            this.время_приёмаMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Время приёма", true));
            this.время_приёмаMaskedTextBox.Location = new System.Drawing.Point(215, 73);
            this.время_приёмаMaskedTextBox.Name = "время_приёмаMaskedTextBox";
            this.время_приёмаMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.время_приёмаMaskedTextBox.TabIndex = 11;
            // 
            // дата_приёма_пациентаDateTimePicker
            // 
            this.дата_приёма_пациентаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Дата приёма пациента", true));
            this.дата_приёма_пациентаDateTimePicker.Location = new System.Drawing.Point(215, 101);
            this.дата_приёма_пациентаDateTimePicker.Name = "дата_приёма_пациентаDateTimePicker";
            this.дата_приёма_пациентаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_приёма_пациентаDateTimePicker.TabIndex = 13;
            // 
            // дата_окончания_леченияDateTimePicker
            // 
            this.дата_окончания_леченияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Дата окончания лечения", true));
            this.дата_окончания_леченияDateTimePicker.Location = new System.Drawing.Point(215, 129);
            this.дата_окончания_леченияDateTimePicker.Name = "дата_окончания_леченияDateTimePicker";
            this.дата_окончания_леченияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_окончания_леченияDateTimePicker.TabIndex = 15;
            // 
            // назначениеTextBox
            // 
            this.назначениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Назначение", true));
            this.назначениеTextBox.Location = new System.Drawing.Point(215, 238);
            this.назначениеTextBox.Name = "назначениеTextBox";
            this.назначениеTextBox.Size = new System.Drawing.Size(200, 22);
            this.назначениеTextBox.TabIndex = 17;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.laboratornaa_Kartochka_Hacienta_VidBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(215, 266);
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.Size = new System.Drawing.Size(200, 22);
            this.описаниеTextBox.TabIndex = 19;
            // 
            // Mesto_polikliniki_leibel
            // 
            this.Mesto_polikliniki_leibel.AutoSize = true;
            this.Mesto_polikliniki_leibel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mesto_polikliniki_leibel.Location = new System.Drawing.Point(27, 26);
            this.Mesto_polikliniki_leibel.Name = "Mesto_polikliniki_leibel";
            this.Mesto_polikliniki_leibel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Mesto_polikliniki_leibel.Size = new System.Drawing.Size(137, 24);
            this.Mesto_polikliniki_leibel.TabIndex = 64;
            this.Mesto_polikliniki_leibel.Text = "Дата приёма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 192);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(333, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Назначение и описание лечения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(491, 26);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "Пациент";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(604, 266);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(106, 35);
            this.Add.TabIndex = 77;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(828, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 76;
            this.button1.Text = "Следующая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sledy
            // 
            this.sledy.Location = new System.Drawing.Point(716, 225);
            this.sledy.Name = "sledy";
            this.sledy.Size = new System.Drawing.Size(106, 35);
            this.sledy.TabIndex = 75;
            this.sledy.Text = "Следующая";
            this.sledy.UseVisualStyleBackColor = true;
            this.sledy.Click += new System.EventHandler(this.sledy_Click);
            // 
            // Pred
            // 
            this.Pred.Location = new System.Drawing.Point(604, 225);
            this.Pred.Name = "Pred";
            this.Pred.Size = new System.Drawing.Size(106, 35);
            this.Pred.TabIndex = 74;
            this.Pred.Text = "Предыдущая";
            this.Pred.UseVisualStyleBackColor = true;
            this.Pred.Click += new System.EventHandler(this.Pred_Click);
            // 
            // Perva
            // 
            this.Perva.Location = new System.Drawing.Point(492, 225);
            this.Perva.Name = "Perva";
            this.Perva.Size = new System.Drawing.Size(106, 35);
            this.Perva.TabIndex = 73;
            this.Perva.Text = "Первая";
            this.Perva.UseVisualStyleBackColor = true;
            this.Perva.Click += new System.EventHandler(this.Perva_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(492, 266);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(106, 35);
            this.Save.TabIndex = 72;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // laboratornaa_Kartochka_Hacienta_VidTableAdapter
            // 
            this.laboratornaa_Kartochka_Hacienta_VidTableAdapter.ClearBeforeFill = true;
            // 
            // Medecinskaa_karta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 547);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sledy);
            this.Controls.Add(this.Pred);
            this.Controls.Add(this.Perva);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mesto_polikliniki_leibel);
            this.Controls.Add(номер_пациентаLabel);
            this.Controls.Add(this.номер_пациентаTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(время_приёмаLabel);
            this.Controls.Add(this.время_приёмаMaskedTextBox);
            this.Controls.Add(дата_приёма_пациентаLabel);
            this.Controls.Add(this.дата_приёма_пациентаDateTimePicker);
            this.Controls.Add(дата_окончания_леченияLabel);
            this.Controls.Add(this.дата_окончания_леченияDateTimePicker);
            this.Controls.Add(назначениеLabel);
            this.Controls.Add(this.назначениеTextBox);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(this.laboratornaa_Kartochka_Hacienta_VidDataGridView);
            this.Name = "Medecinskaa_karta";
            this.Text = "Medecinskaa_karta";
            this.Load += new System.EventHandler(this.Medecinskaa_karta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratornaa_Kartochka_Hacienta_VidDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboratornaa_Kartochka_Hacienta_VidBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AProektSK1DataSet aProektSK1DataSet;
        private System.Windows.Forms.BindingSource laboratornaa_Kartochka_Hacienta_VidBindingSource;
        private AProektSK1DataSetTableAdapters.Laboratornaa_Kartochka_Hacienta_VidTableAdapter laboratornaa_Kartochka_Hacienta_VidTableAdapter;
        private AProektSK1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView laboratornaa_Kartochka_Hacienta_VidDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox номер_пациентаTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.MaskedTextBox время_приёмаMaskedTextBox;
        private System.Windows.Forms.DateTimePicker дата_приёма_пациентаDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_окончания_леченияDateTimePicker;
        private System.Windows.Forms.TextBox назначениеTextBox;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.Label Mesto_polikliniki_leibel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sledy;
        private System.Windows.Forms.Button Pred;
        private System.Windows.Forms.Button Perva;
        private System.Windows.Forms.Button Save;
    }
}