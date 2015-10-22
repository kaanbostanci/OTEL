namespace OtelResepsiyon
{
    partial class AnaForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.oteldekiMüşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boşOdalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oteldekiMüşterilerToolStripMenuItem,
            this.rezervasyonToolStripMenuItem,
            this.odalarıListeleToolStripMenuItem,
            this.boşOdalarToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(777, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // oteldekiMüşterilerToolStripMenuItem
            // 
            this.oteldekiMüşterilerToolStripMenuItem.Name = "oteldekiMüşterilerToolStripMenuItem";
            this.oteldekiMüşterilerToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.oteldekiMüşterilerToolStripMenuItem.Text = "Oteldeki Müşteriler";
            this.oteldekiMüşterilerToolStripMenuItem.Click += new System.EventHandler(this.oteldekiMüşterilerToolStripMenuItem_Click);
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            this.rezervasyonToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonToolStripMenuItem_Click);
            // 
            // odalarıListeleToolStripMenuItem
            // 
            this.odalarıListeleToolStripMenuItem.Name = "odalarıListeleToolStripMenuItem";
            this.odalarıListeleToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.odalarıListeleToolStripMenuItem.Text = "Odaları Listele";
            this.odalarıListeleToolStripMenuItem.Click += new System.EventHandler(this.odalarıListeleToolStripMenuItem_Click);
            // 
            // boşOdalarToolStripMenuItem
            // 
            this.boşOdalarToolStripMenuItem.Name = "boşOdalarToolStripMenuItem";
            this.boşOdalarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.boşOdalarToolStripMenuItem.Text = "Boş Odalar";
            this.boşOdalarToolStripMenuItem.Click += new System.EventHandler(this.boşOdalarToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.checkOutToolStripMenuItem.Text = "Check-Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(777, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AnaForm";
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boşOdalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oteldekiMüşterilerToolStripMenuItem;
    }
}



