namespace MedProekt1
{
    partial class Administrator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ukfdyfzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьТалонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.больницаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поликлиникаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.договорНаОбслуживаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukfdyfzToolStripMenuItem,
            this.получитьТалонToolStripMenuItem,
            this.договорНаОбслуживаниеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ukfdyfzToolStripMenuItem
            // 
            this.ukfdyfzToolStripMenuItem.Name = "ukfdyfzToolStripMenuItem";
            this.ukfdyfzToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.ukfdyfzToolStripMenuItem.Text = "Главная";
            // 
            // получитьТалонToolStripMenuItem
            // 
            this.получитьТалонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.больницаToolStripMenuItem,
            this.поликлиникаToolStripMenuItem1});
            this.получитьТалонToolStripMenuItem.Name = "получитьТалонToolStripMenuItem";
            this.получитьТалонToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.получитьТалонToolStripMenuItem.Text = "Записать пациента на приём";
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
            // договорНаОбслуживаниеToolStripMenuItem
            // 
            this.договорНаОбслуживаниеToolStripMenuItem.Name = "договорНаОбслуживаниеToolStripMenuItem";
            this.договорНаОбслуживаниеToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.договорНаОбслуживаниеToolStripMenuItem.Text = "Договор на обслуживание";
            this.договорНаОбслуживаниеToolStripMenuItem.Click += new System.EventHandler(this.договорНаОбслуживаниеToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ukfdyfzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьТалонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem больницаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поликлиникаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem договорНаОбслуживаниеToolStripMenuItem;
    }
}