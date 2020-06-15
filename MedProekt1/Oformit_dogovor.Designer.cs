namespace MedProekt1
{
    partial class Oformit_dogovor
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
            System.Windows.Forms.Label номер_договораLabel;
            System.Windows.Forms.Label лечебное_завидениеLabel;
            System.Windows.Forms.Label номер_больницыLabel;
            System.Windows.Forms.Label наименование_больницыLabel;
            System.Windows.Forms.Label номер_полеклиникиLabel;
            System.Windows.Forms.Label наименование_полеклиникиLabel;
            System.Windows.Forms.Label дата_заключенияLabel;
            System.Windows.Forms.Label время_заключенияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oformit_dogovor));
            this.aProektSK1DataSet = new MedProekt1.AProektSK1DataSet();
            this.dogovor_na_Obsluzhivaniye_VidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dogovor_na_Obsluzhivaniye_VidTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Dogovor_na_Obsluzhivaniye_VidTableAdapter();
            this.tableAdapterManager = new MedProekt1.AProektSK1DataSetTableAdapters.TableAdapterManager();
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_договораTextBox = new System.Windows.Forms.TextBox();
            this.лечебное_завидениеTextBox = new System.Windows.Forms.TextBox();
            this.номер_больницыTextBox = new System.Windows.Forms.TextBox();
            this.наименование_больницыTextBox = new System.Windows.Forms.TextBox();
            this.номер_полеклиникиTextBox = new System.Windows.Forms.TextBox();
            this.наименование_полеклиникиTextBox = new System.Windows.Forms.TextBox();
            this.дата_заключенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.время_заключенияTextBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            номер_договораLabel = new System.Windows.Forms.Label();
            лечебное_завидениеLabel = new System.Windows.Forms.Label();
            номер_больницыLabel = new System.Windows.Forms.Label();
            наименование_больницыLabel = new System.Windows.Forms.Label();
            номер_полеклиникиLabel = new System.Windows.Forms.Label();
            наименование_полеклиникиLabel = new System.Windows.Forms.Label();
            дата_заключенияLabel = new System.Windows.Forms.Label();
            время_заключенияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovor_na_Obsluzhivaniye_VidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovor_na_Obsluzhivaniye_VidBindingNavigator)).BeginInit();
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // номер_договораLabel
            // 
            номер_договораLabel.AutoSize = true;
            номер_договораLabel.Location = new System.Drawing.Point(28, 65);
            номер_договораLabel.Name = "номер_договораLabel";
            номер_договораLabel.Size = new System.Drawing.Size(139, 20);
            номер_договораLabel.TabIndex = 1;
            номер_договораLabel.Text = "Номер договора:";
            // 
            // лечебное_завидениеLabel
            // 
            лечебное_завидениеLabel.AutoSize = true;
            лечебное_завидениеLabel.Location = new System.Drawing.Point(28, 100);
            лечебное_завидениеLabel.Name = "лечебное_завидениеLabel";
            лечебное_завидениеLabel.Size = new System.Drawing.Size(174, 20);
            лечебное_завидениеLabel.TabIndex = 3;
            лечебное_завидениеLabel.Text = "Лечебное завидение:";
            // 
            // номер_больницыLabel
            // 
            номер_больницыLabel.AutoSize = true;
            номер_больницыLabel.Location = new System.Drawing.Point(28, 135);
            номер_больницыLabel.Name = "номер_больницыLabel";
            номер_больницыLabel.Size = new System.Drawing.Size(142, 20);
            номер_больницыLabel.TabIndex = 5;
            номер_больницыLabel.Text = "Номер больницы:";
            // 
            // наименование_больницыLabel
            // 
            наименование_больницыLabel.AutoSize = true;
            наименование_больницыLabel.Location = new System.Drawing.Point(28, 170);
            наименование_больницыLabel.Name = "наименование_больницыLabel";
            наименование_больницыLabel.Size = new System.Drawing.Size(205, 20);
            наименование_больницыLabel.TabIndex = 7;
            наименование_больницыLabel.Text = "Наименование больницы:";
            // 
            // номер_полеклиникиLabel
            // 
            номер_полеклиникиLabel.AutoSize = true;
            номер_полеклиникиLabel.Location = new System.Drawing.Point(28, 205);
            номер_полеклиникиLabel.Name = "номер_полеклиникиLabel";
            номер_полеклиникиLabel.Size = new System.Drawing.Size(166, 20);
            номер_полеклиникиLabel.TabIndex = 9;
            номер_полеклиникиLabel.Text = "Номер полеклиники:";
            // 
            // наименование_полеклиникиLabel
            // 
            наименование_полеклиникиLabel.AutoSize = true;
            наименование_полеклиникиLabel.Location = new System.Drawing.Point(28, 240);
            наименование_полеклиникиLabel.Name = "наименование_полеклиникиLabel";
            наименование_полеклиникиLabel.Size = new System.Drawing.Size(229, 20);
            наименование_полеклиникиLabel.TabIndex = 11;
            наименование_полеклиникиLabel.Text = "Наименование полеклиники:";
            // 
            // дата_заключенияLabel
            // 
            дата_заключенияLabel.AutoSize = true;
            дата_заключенияLabel.Location = new System.Drawing.Point(28, 276);
            дата_заключенияLabel.Name = "дата_заключенияLabel";
            дата_заключенияLabel.Size = new System.Drawing.Size(148, 20);
            дата_заключенияLabel.TabIndex = 13;
            дата_заключенияLabel.Text = "Дата заключения:";
            // 
            // время_заключенияLabel
            // 
            время_заключенияLabel.AutoSize = true;
            время_заключенияLabel.Location = new System.Drawing.Point(28, 310);
            время_заключенияLabel.Name = "время_заключенияLabel";
            время_заключенияLabel.Size = new System.Drawing.Size(158, 20);
            время_заключенияLabel.TabIndex = 15;
            время_заключенияLabel.Text = "Время заключения:";
            // 
            // aProektSK1DataSet
            // 
            this.aProektSK1DataSet.DataSetName = "AProektSK1DataSet";
            this.aProektSK1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dogovor_na_Obsluzhivaniye_VidBindingSource
            // 
            this.dogovor_na_Obsluzhivaniye_VidBindingSource.DataMember = "Dogovor_na_Obsluzhivaniye_Vid";
            this.dogovor_na_Obsluzhivaniye_VidBindingSource.DataSource = this.aProektSK1DataSet;
            // 
            // dogovor_na_Obsluzhivaniye_VidTableAdapter
            // 
            this.dogovor_na_Obsluzhivaniye_VidTableAdapter.ClearBeforeFill = true;
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
            // dogovor_na_Obsluzhivaniye_VidBindingNavigator
            // 
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.BindingSource = this.dogovor_na_Obsluzhivaniye_VidBindingSource;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem});
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.Name = "dogovor_na_Obsluzhivaniye_VidBindingNavigator";
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.Size = new System.Drawing.Size(526, 38);
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.TabIndex = 0;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem
            // 
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem.Enabled = false;
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem.Image")));
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem.Name = "dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem";
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // номер_договораTextBox
            // 
            this.номер_договораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovor_na_Obsluzhivaniye_VidBindingSource, "Номер договора", true));
            this.номер_договораTextBox.Location = new System.Drawing.Point(260, 61);
            this.номер_договораTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.номер_договораTextBox.Name = "номер_договораTextBox";
            this.номер_договораTextBox.Size = new System.Drawing.Size(224, 26);
            this.номер_договораTextBox.TabIndex = 2;
            // 
            // лечебное_завидениеTextBox
            // 
            this.лечебное_завидениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovor_na_Obsluzhivaniye_VidBindingSource, "Лечебное завидение", true));
            this.лечебное_завидениеTextBox.Location = new System.Drawing.Point(260, 96);
            this.лечебное_завидениеTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.лечебное_завидениеTextBox.Name = "лечебное_завидениеTextBox";
            this.лечебное_завидениеTextBox.Size = new System.Drawing.Size(224, 26);
            this.лечебное_завидениеTextBox.TabIndex = 4;
            // 
            // номер_больницыTextBox
            // 
            this.номер_больницыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovor_na_Obsluzhivaniye_VidBindingSource, "Номер больницы", true));
            this.номер_больницыTextBox.Location = new System.Drawing.Point(260, 131);
            this.номер_больницыTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.номер_больницыTextBox.Name = "номер_больницыTextBox";
            this.номер_больницыTextBox.Size = new System.Drawing.Size(224, 26);
            this.номер_больницыTextBox.TabIndex = 6;
            // 
            // наименование_больницыTextBox
            // 
            this.наименование_больницыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovor_na_Obsluzhivaniye_VidBindingSource, "Наименование больницы", true));
            this.наименование_больницыTextBox.Location = new System.Drawing.Point(260, 166);
            this.наименование_больницыTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.наименование_больницыTextBox.Name = "наименование_больницыTextBox";
            this.наименование_больницыTextBox.Size = new System.Drawing.Size(224, 26);
            this.наименование_больницыTextBox.TabIndex = 8;
            // 
            // номер_полеклиникиTextBox
            // 
            this.номер_полеклиникиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovor_na_Obsluzhivaniye_VidBindingSource, "Номер полеклиники", true));
            this.номер_полеклиникиTextBox.Location = new System.Drawing.Point(260, 201);
            this.номер_полеклиникиTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.номер_полеклиникиTextBox.Name = "номер_полеклиникиTextBox";
            this.номер_полеклиникиTextBox.Size = new System.Drawing.Size(224, 26);
            this.номер_полеклиникиTextBox.TabIndex = 10;
            // 
            // наименование_полеклиникиTextBox
            // 
            this.наименование_полеклиникиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovor_na_Obsluzhivaniye_VidBindingSource, "Наименование полеклиники", true));
            this.наименование_полеклиникиTextBox.Location = new System.Drawing.Point(260, 236);
            this.наименование_полеклиникиTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.наименование_полеклиникиTextBox.Name = "наименование_полеклиникиTextBox";
            this.наименование_полеклиникиTextBox.Size = new System.Drawing.Size(224, 26);
            this.наименование_полеклиникиTextBox.TabIndex = 12;
            // 
            // дата_заключенияDateTimePicker
            // 
            this.дата_заключенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dogovor_na_Obsluzhivaniye_VidBindingSource, "Дата заключения", true));
            this.дата_заключенияDateTimePicker.Location = new System.Drawing.Point(260, 271);
            this.дата_заключенияDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.дата_заключенияDateTimePicker.Name = "дата_заключенияDateTimePicker";
            this.дата_заключенияDateTimePicker.Size = new System.Drawing.Size(224, 26);
            this.дата_заключенияDateTimePicker.TabIndex = 14;
            // 
            // время_заключенияTextBox
            // 
            this.время_заключенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dogovor_na_Obsluzhivaniye_VidBindingSource, "Время заключения", true));
            this.время_заключенияTextBox.Location = new System.Drawing.Point(260, 306);
            this.время_заключенияTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.время_заключенияTextBox.Name = "время_заключенияTextBox";
            this.время_заключенияTextBox.Size = new System.Drawing.Size(224, 26);
            this.время_заключенияTextBox.TabIndex = 16;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(379, 352);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(106, 29);
            this.Save.TabIndex = 17;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Oformit_dogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 436);
            this.Controls.Add(this.Save);
            this.Controls.Add(номер_договораLabel);
            this.Controls.Add(this.номер_договораTextBox);
            this.Controls.Add(лечебное_завидениеLabel);
            this.Controls.Add(this.лечебное_завидениеTextBox);
            this.Controls.Add(номер_больницыLabel);
            this.Controls.Add(this.номер_больницыTextBox);
            this.Controls.Add(наименование_больницыLabel);
            this.Controls.Add(this.наименование_больницыTextBox);
            this.Controls.Add(номер_полеклиникиLabel);
            this.Controls.Add(this.номер_полеклиникиTextBox);
            this.Controls.Add(наименование_полеклиникиLabel);
            this.Controls.Add(this.наименование_полеклиникиTextBox);
            this.Controls.Add(дата_заключенияLabel);
            this.Controls.Add(this.дата_заключенияDateTimePicker);
            this.Controls.Add(время_заключенияLabel);
            this.Controls.Add(this.время_заключенияTextBox);
            this.Controls.Add(this.dogovor_na_Obsluzhivaniye_VidBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Oformit_dogovor";
            this.Text = "Oformit_dogovor";
            this.Load += new System.EventHandler(this.Oformit_dogovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovor_na_Obsluzhivaniye_VidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovor_na_Obsluzhivaniye_VidBindingNavigator)).EndInit();
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.ResumeLayout(false);
            this.dogovor_na_Obsluzhivaniye_VidBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AProektSK1DataSet aProektSK1DataSet;
        private System.Windows.Forms.BindingSource dogovor_na_Obsluzhivaniye_VidBindingSource;
        private AProektSK1DataSetTableAdapters.Dogovor_na_Obsluzhivaniye_VidTableAdapter dogovor_na_Obsluzhivaniye_VidTableAdapter;
        private AProektSK1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dogovor_na_Obsluzhivaniye_VidBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dogovor_na_Obsluzhivaniye_VidBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_договораTextBox;
        private System.Windows.Forms.TextBox лечебное_завидениеTextBox;
        private System.Windows.Forms.TextBox номер_больницыTextBox;
        private System.Windows.Forms.TextBox наименование_больницыTextBox;
        private System.Windows.Forms.TextBox номер_полеклиникиTextBox;
        private System.Windows.Forms.TextBox наименование_полеклиникиTextBox;
        private System.Windows.Forms.DateTimePicker дата_заключенияDateTimePicker;
        private System.Windows.Forms.TextBox время_заключенияTextBox;
        private System.Windows.Forms.Button Save;
    }
}