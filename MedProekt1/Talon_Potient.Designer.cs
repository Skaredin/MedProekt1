namespace MedProekt1
{
    partial class Talon_Potient
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
            System.Windows.Forms.Label отчество_пациентаLabel;
            System.Windows.Forms.Label имя_пациентаLabel;
            System.Windows.Forms.Label фамилия_пациентаLabel;
            System.Windows.Forms.Label время_приёмаLabel;
            System.Windows.Forms.Label дата_приёмаLabel;
            System.Windows.Forms.Label вид_врачебной_деятельности1Label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Talon_Potient));
            this.aProektSK1DataSet = new MedProekt1.AProektSK1DataSet();
            this.grafik_Prioma_PoleklinikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafik_Prioma_PoleklinikaTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Grafik_Prioma_PoleklinikaTableAdapter();
            this.tableAdapterManager = new MedProekt1.AProektSK1DataSetTableAdapters.TableAdapterManager();
            this.grafik_Prioma_PoleklinikaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grafik_Prioma_PoleklinikaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.Button();
            this.отчество_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.имя_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.фамилия_пациентаTextBox = new System.Windows.Forms.TextBox();
            this.время_приёмаMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.дата_приёмаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.вид_врачебной_деятельности1ComboBox = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            отчество_пациентаLabel = new System.Windows.Forms.Label();
            имя_пациентаLabel = new System.Windows.Forms.Label();
            фамилия_пациентаLabel = new System.Windows.Forms.Label();
            время_приёмаLabel = new System.Windows.Forms.Label();
            дата_приёмаLabel = new System.Windows.Forms.Label();
            вид_врачебной_деятельности1Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_Prioma_PoleklinikaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_Prioma_PoleklinikaBindingNavigator)).BeginInit();
            this.grafik_Prioma_PoleklinikaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // отчество_пациентаLabel
            // 
            отчество_пациентаLabel.AutoSize = true;
            отчество_пациентаLabel.Location = new System.Drawing.Point(12, 159);
            отчество_пациентаLabel.Name = "отчество_пациентаLabel";
            отчество_пациентаLabel.Size = new System.Drawing.Size(142, 17);
            отчество_пациентаLabel.TabIndex = 17;
            отчество_пациентаLabel.Text = "Отчество пациента:";
            // 
            // имя_пациентаLabel
            // 
            имя_пациентаLabel.AutoSize = true;
            имя_пациентаLabel.Location = new System.Drawing.Point(12, 131);
            имя_пациентаLabel.Name = "имя_пациентаLabel";
            имя_пациентаLabel.Size = new System.Drawing.Size(106, 17);
            имя_пациентаLabel.TabIndex = 15;
            имя_пациентаLabel.Text = "Имя пациента:";
            // 
            // фамилия_пациентаLabel
            // 
            фамилия_пациентаLabel.AutoSize = true;
            фамилия_пациентаLabel.Location = new System.Drawing.Point(12, 103);
            фамилия_пациентаLabel.Name = "фамилия_пациентаLabel";
            фамилия_пациентаLabel.Size = new System.Drawing.Size(141, 17);
            фамилия_пациентаLabel.TabIndex = 13;
            фамилия_пациентаLabel.Text = "Фамилия пациента:";
            // 
            // время_приёмаLabel
            // 
            время_приёмаLabel.AutoSize = true;
            время_приёмаLabel.Location = new System.Drawing.Point(12, 75);
            время_приёмаLabel.Name = "время_приёмаLabel";
            время_приёмаLabel.Size = new System.Drawing.Size(107, 17);
            время_приёмаLabel.TabIndex = 9;
            время_приёмаLabel.Text = "Время приёма:";
            // 
            // дата_приёмаLabel
            // 
            дата_приёмаLabel.AutoSize = true;
            дата_приёмаLabel.Location = new System.Drawing.Point(12, 48);
            дата_приёмаLabel.Name = "дата_приёмаLabel";
            дата_приёмаLabel.Size = new System.Drawing.Size(99, 17);
            дата_приёмаLabel.TabIndex = 7;
            дата_приёмаLabel.Text = "Дата приёма:";
            // 
            // вид_врачебной_деятельности1Label1
            // 
            вид_врачебной_деятельности1Label1.AutoSize = true;
            вид_врачебной_деятельности1Label1.Location = new System.Drawing.Point(12, 187);
            вид_врачебной_деятельности1Label1.Name = "вид_врачебной_деятельности1Label1";
            вид_врачебной_деятельности1Label1.Size = new System.Drawing.Size(208, 17);
            вид_врачебной_деятельности1Label1.TabIndex = 29;
            вид_врачебной_деятельности1Label1.Text = "Вид врачебной деятельности:";
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
            // grafik_Prioma_PoleklinikaBindingNavigator
            // 
            this.grafik_Prioma_PoleklinikaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.grafik_Prioma_PoleklinikaBindingNavigator.BindingSource = this.grafik_Prioma_PoleklinikaBindingSource;
            this.grafik_Prioma_PoleklinikaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.grafik_Prioma_PoleklinikaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.grafik_Prioma_PoleklinikaBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.grafik_Prioma_PoleklinikaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.grafik_Prioma_PoleklinikaBindingNavigatorSaveItem});
            this.grafik_Prioma_PoleklinikaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.grafik_Prioma_PoleklinikaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.grafik_Prioma_PoleklinikaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.grafik_Prioma_PoleklinikaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.grafik_Prioma_PoleklinikaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.grafik_Prioma_PoleklinikaBindingNavigator.Name = "grafik_Prioma_PoleklinikaBindingNavigator";
            this.grafik_Prioma_PoleklinikaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.grafik_Prioma_PoleklinikaBindingNavigator.Size = new System.Drawing.Size(463, 31);
            this.grafik_Prioma_PoleklinikaBindingNavigator.TabIndex = 0;
            this.grafik_Prioma_PoleklinikaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // grafik_Prioma_PoleklinikaBindingNavigatorSaveItem
            // 
            this.grafik_Prioma_PoleklinikaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grafik_Prioma_PoleklinikaBindingNavigatorSaveItem.Enabled = false;
            this.grafik_Prioma_PoleklinikaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("grafik_Prioma_PoleklinikaBindingNavigatorSaveItem.Image")));
            this.grafik_Prioma_PoleklinikaBindingNavigatorSaveItem.Name = "grafik_Prioma_PoleklinikaBindingNavigatorSaveItem";
            this.grafik_Prioma_PoleklinikaBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.grafik_Prioma_PoleklinikaBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(359, 238);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 29;
            this.Save.Text = "Записаться";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // отчество_пациентаTextBox
            // 
            this.отчество_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grafik_Prioma_PoleklinikaBindingSource, "Отчество пациента", true));
            this.отчество_пациентаTextBox.Location = new System.Drawing.Point(234, 156);
            this.отчество_пациентаTextBox.Name = "отчество_пациентаTextBox";
            this.отчество_пациентаTextBox.Size = new System.Drawing.Size(200, 22);
            this.отчество_пациентаTextBox.TabIndex = 18;
            // 
            // имя_пациентаTextBox
            // 
            this.имя_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grafik_Prioma_PoleklinikaBindingSource, "Имя пациента", true));
            this.имя_пациентаTextBox.Location = new System.Drawing.Point(234, 128);
            this.имя_пациентаTextBox.Name = "имя_пациентаTextBox";
            this.имя_пациентаTextBox.Size = new System.Drawing.Size(200, 22);
            this.имя_пациентаTextBox.TabIndex = 16;
            // 
            // фамилия_пациентаTextBox
            // 
            this.фамилия_пациентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grafik_Prioma_PoleklinikaBindingSource, "Фамилия пациента", true));
            this.фамилия_пациентаTextBox.Location = new System.Drawing.Point(234, 100);
            this.фамилия_пациентаTextBox.Name = "фамилия_пациентаTextBox";
            this.фамилия_пациентаTextBox.Size = new System.Drawing.Size(200, 22);
            this.фамилия_пациентаTextBox.TabIndex = 14;
            // 
            // время_приёмаMaskedTextBox
            // 
            this.время_приёмаMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grafik_Prioma_PoleklinikaBindingSource, "Время приёма", true));
            this.время_приёмаMaskedTextBox.Location = new System.Drawing.Point(234, 72);
            this.время_приёмаMaskedTextBox.Mask = "00:00:00";
            this.время_приёмаMaskedTextBox.Name = "время_приёмаMaskedTextBox";
            this.время_приёмаMaskedTextBox.Size = new System.Drawing.Size(200, 22);
            this.время_приёмаMaskedTextBox.TabIndex = 10;
            // 
            // дата_приёмаDateTimePicker
            // 
            this.дата_приёмаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.grafik_Prioma_PoleklinikaBindingSource, "Дата приёма", true));
            this.дата_приёмаDateTimePicker.Location = new System.Drawing.Point(234, 44);
            this.дата_приёмаDateTimePicker.Name = "дата_приёмаDateTimePicker";
            this.дата_приёмаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_приёмаDateTimePicker.TabIndex = 8;
            // 
            // вид_врачебной_деятельности1ComboBox
            // 
            this.вид_врачебной_деятельности1ComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "хирурги",
            "терапевты",
            "невропатологи",
            "окулисты",
            "стоматологи",
            "рентгенологи",
            "гинекологи "});
            this.вид_врачебной_деятельности1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grafik_Prioma_PoleklinikaBindingSource, "Вид врачебной деятельности1", true));
            this.вид_врачебной_деятельности1ComboBox.FormattingEnabled = true;
            this.вид_врачебной_деятельности1ComboBox.Location = new System.Drawing.Point(234, 184);
            this.вид_врачебной_деятельности1ComboBox.Name = "вид_врачебной_деятельности1ComboBox";
            this.вид_врачебной_деятельности1ComboBox.Size = new System.Drawing.Size(200, 24);
            this.вид_врачебной_деятельности1ComboBox.TabIndex = 30;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(266, 238);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(87, 23);
            this.Add.TabIndex = 72;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Talon_Potient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 309);
            this.Controls.Add(this.Add);
            this.Controls.Add(вид_врачебной_деятельности1Label1);
            this.Controls.Add(this.вид_врачебной_деятельности1ComboBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(дата_приёмаLabel);
            this.Controls.Add(this.дата_приёмаDateTimePicker);
            this.Controls.Add(время_приёмаLabel);
            this.Controls.Add(this.время_приёмаMaskedTextBox);
            this.Controls.Add(фамилия_пациентаLabel);
            this.Controls.Add(this.фамилия_пациентаTextBox);
            this.Controls.Add(имя_пациентаLabel);
            this.Controls.Add(this.имя_пациентаTextBox);
            this.Controls.Add(отчество_пациентаLabel);
            this.Controls.Add(this.отчество_пациентаTextBox);
            this.Controls.Add(this.grafik_Prioma_PoleklinikaBindingNavigator);
            this.Name = "Talon_Potient";
            this.Text = "Talon_Potient";
            this.Load += new System.EventHandler(this.Talon_Potient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_Prioma_PoleklinikaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafik_Prioma_PoleklinikaBindingNavigator)).EndInit();
            this.grafik_Prioma_PoleklinikaBindingNavigator.ResumeLayout(false);
            this.grafik_Prioma_PoleklinikaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AProektSK1DataSet aProektSK1DataSet;
        private System.Windows.Forms.BindingSource grafik_Prioma_PoleklinikaBindingSource;
        private AProektSK1DataSetTableAdapters.Grafik_Prioma_PoleklinikaTableAdapter grafik_Prioma_PoleklinikaTableAdapter;
        private AProektSK1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator grafik_Prioma_PoleklinikaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton grafik_Prioma_PoleklinikaBindingNavigatorSaveItem;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox отчество_пациентаTextBox;
        private System.Windows.Forms.TextBox имя_пациентаTextBox;
        private System.Windows.Forms.TextBox фамилия_пациентаTextBox;
        private System.Windows.Forms.MaskedTextBox время_приёмаMaskedTextBox;
        private System.Windows.Forms.DateTimePicker дата_приёмаDateTimePicker;
        private System.Windows.Forms.ComboBox вид_врачебной_деятельности1ComboBox;
        private System.Windows.Forms.Button Add;
    }
}