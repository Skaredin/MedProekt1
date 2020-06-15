namespace MedProekt1
{
    partial class Employees
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ukfdyfzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьТалонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.больницаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поликлиникаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.медецинскаяКарточкаПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukfdyfzToolStripMenuItem,
            this.получитьТалонToolStripMenuItem,
            this.медецинскаяКарточкаПациентаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ukfdyfzToolStripMenuItem
            // 
            this.ukfdyfzToolStripMenuItem.Name = "ukfdyfzToolStripMenuItem";
            this.ukfdyfzToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.ukfdyfzToolStripMenuItem.Text = "Главная";
            this.ukfdyfzToolStripMenuItem.Click += new System.EventHandler(this.ukfdyfzToolStripMenuItem_Click);
            // 
            // получитьТалонToolStripMenuItem
            // 
            this.получитьТалонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.больницаToolStripMenuItem,
            this.поликлиникаToolStripMenuItem1});
            this.получитьТалонToolStripMenuItem.Name = "получитьТалонToolStripMenuItem";
            this.получитьТалонToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.получитьТалонToolStripMenuItem.Text = "Расписание";
            // 
            // больницаToolStripMenuItem
            // 
            this.больницаToolStripMenuItem.Name = "больницаToolStripMenuItem";
            this.больницаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.больницаToolStripMenuItem.Text = "Больница";
            this.больницаToolStripMenuItem.Click += new System.EventHandler(this.больницаToolStripMenuItem_Click);
            // 
            // поликлиникаToolStripMenuItem1
            // 
            this.поликлиникаToolStripMenuItem1.Name = "поликлиникаToolStripMenuItem1";
            this.поликлиникаToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.поликлиникаToolStripMenuItem1.Text = "Поликлиника";
            this.поликлиникаToolStripMenuItem1.Click += new System.EventHandler(this.поликлиникаToolStripMenuItem1_Click);
            // 
            // медецинскаяКарточкаПациентаToolStripMenuItem
            // 
            this.медецинскаяКарточкаПациентаToolStripMenuItem.Name = "медецинскаяКарточкаПациентаToolStripMenuItem";
            this.медецинскаяКарточкаПациентаToolStripMenuItem.Size = new System.Drawing.Size(253, 24);
            this.медецинскаяКарточкаПациентаToolStripMenuItem.Text = "Медецинская карточка пациента";
            this.медецинскаяКарточкаПациентаToolStripMenuItem.Click += new System.EventHandler(this.медецинскаяКарточкаПациентаToolStripMenuItem_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Employees";
            this.Text = "Employees";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ukfdyfzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьТалонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem больницаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поликлиникаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem медецинскаяКарточкаПациентаToolStripMenuItem;
    }
}