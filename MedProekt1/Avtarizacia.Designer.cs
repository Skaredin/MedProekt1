namespace MedProekt1
{
    partial class Avtarizacia
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
            this.prikreplenniyekHospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prikreplenniye_k_HospitalTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Prikreplenniye_k_HospitalTableAdapter();
            this.grafikPriomaPoleklinikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grafik_Prioma_PoleklinikaTableAdapter = new MedProekt1.AProektSK1DataSetTableAdapters.Grafik_Prioma_PoleklinikaTableAdapter();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PassvordTextBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Passvord = new System.Windows.Forms.Label();
            this.VoitiButton = new System.Windows.Forms.Button();
            this.RegistraciaButton = new System.Windows.Forms.Button();
            this.Naimenovanie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikreplenniyekHospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikPriomaPoleklinikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aProektSK1DataSet
            // 
            this.aProektSK1DataSet.DataSetName = "AProektSK1DataSet";
            this.aProektSK1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prikreplenniyekHospitalBindingSource
            // 
            this.prikreplenniyekHospitalBindingSource.DataMember = "Prikreplenniye_k_Hospital";
            this.prikreplenniyekHospitalBindingSource.DataSource = this.aProektSK1DataSet;
            // 
            // prikreplenniye_k_HospitalTableAdapter
            // 
            this.prikreplenniye_k_HospitalTableAdapter.ClearBeforeFill = true;
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
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(88, 59);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(172, 22);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PassvordTextBox
            // 
            this.PassvordTextBox.Location = new System.Drawing.Point(88, 87);
            this.PassvordTextBox.Name = "PassvordTextBox";
            this.PassvordTextBox.Size = new System.Drawing.Size(172, 22);
            this.PassvordTextBox.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(13, 59);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(47, 17);
            this.Login.TabIndex = 2;
            this.Login.Text = "Логин";
            // 
            // Passvord
            // 
            this.Passvord.AutoSize = true;
            this.Passvord.Location = new System.Drawing.Point(12, 92);
            this.Passvord.Name = "Passvord";
            this.Passvord.Size = new System.Drawing.Size(57, 17);
            this.Passvord.TabIndex = 3;
            this.Passvord.Text = "Пароль";
            // 
            // VoitiButton
            // 
            this.VoitiButton.Location = new System.Drawing.Point(57, 124);
            this.VoitiButton.Name = "VoitiButton";
            this.VoitiButton.Size = new System.Drawing.Size(172, 31);
            this.VoitiButton.TabIndex = 4;
            this.VoitiButton.Text = "Ввойти";
            this.VoitiButton.UseVisualStyleBackColor = true;
            this.VoitiButton.Click += new System.EventHandler(this.VoitiButton_Click);
            // 
            // RegistraciaButton
            // 
            this.RegistraciaButton.Location = new System.Drawing.Point(57, 161);
            this.RegistraciaButton.Name = "RegistraciaButton";
            this.RegistraciaButton.Size = new System.Drawing.Size(172, 31);
            this.RegistraciaButton.TabIndex = 5;
            this.RegistraciaButton.Text = "Зарегистрироваться";
            this.RegistraciaButton.UseVisualStyleBackColor = true;
            this.RegistraciaButton.Click += new System.EventHandler(this.RegistraciaButton_Click);
            // 
            // Naimenovanie
            // 
            this.Naimenovanie.AutoSize = true;
            this.Naimenovanie.Location = new System.Drawing.Point(85, 9);
            this.Naimenovanie.Name = "Naimenovanie";
            this.Naimenovanie.Size = new System.Drawing.Size(94, 17);
            this.Naimenovanie.TabIndex = 6;
            this.Naimenovanie.Text = "Авторизация";
            // 
            // Avtarizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.Naimenovanie);
            this.Controls.Add(this.RegistraciaButton);
            this.Controls.Add(this.VoitiButton);
            this.Controls.Add(this.Passvord);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PassvordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "Avtarizacia";
            this.Text = "Avtarizacia";
            this.Load += new System.EventHandler(this.Avtarizacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aProektSK1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikreplenniyekHospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafikPriomaPoleklinikaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AProektSK1DataSet aProektSK1DataSet;
        private System.Windows.Forms.BindingSource prikreplenniyekHospitalBindingSource;
        private AProektSK1DataSetTableAdapters.Prikreplenniye_k_HospitalTableAdapter prikreplenniye_k_HospitalTableAdapter;
        private System.Windows.Forms.BindingSource grafikPriomaPoleklinikaBindingSource;
        private AProektSK1DataSetTableAdapters.Grafik_Prioma_PoleklinikaTableAdapter grafik_Prioma_PoleklinikaTableAdapter;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PassvordTextBox;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Passvord;
        private System.Windows.Forms.Button VoitiButton;
        private System.Windows.Forms.Button RegistraciaButton;
        private System.Windows.Forms.Label Naimenovanie;
    }
}