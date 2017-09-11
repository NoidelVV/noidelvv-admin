namespace NoidelVV_Admin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vVFotoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vVAbbigliamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateDOCXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatorePasswordClassiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.certificatiCreditiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmiToolStripMenuItem,
            this.passwordToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmiToolStripMenuItem
            // 
            this.programmiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vVFotoToolStripMenuItem1,
            this.vVAbbigliamentoToolStripMenuItem});
            this.programmiToolStripMenuItem.Name = "programmiToolStripMenuItem";
            this.programmiToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programmiToolStripMenuItem.Text = "&Connetti";
            // 
            // vVFotoToolStripMenuItem1
            // 
            this.vVFotoToolStripMenuItem1.Name = "vVFotoToolStripMenuItem1";
            this.vVFotoToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.vVFotoToolStripMenuItem1.Text = "VVFoto";
            this.vVFotoToolStripMenuItem1.Click += new System.EventHandler(this.vVFotoToolStripMenuItem1_Click);
            // 
            // vVAbbigliamentoToolStripMenuItem
            // 
            this.vVAbbigliamentoToolStripMenuItem.Name = "vVAbbigliamentoToolStripMenuItem";
            this.vVAbbigliamentoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.vVAbbigliamentoToolStripMenuItem.Text = "VVAbbigliamento";
            this.vVAbbigliamentoToolStripMenuItem.Click += new System.EventHandler(this.vVAbbigliamentoToolStripMenuItem_Click);
            // 
            // passwordToolStripMenuItem
            // 
            this.passwordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateDOCXToolStripMenuItem});
            this.passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            this.passwordToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.passwordToolStripMenuItem.Text = "&Password";
            // 
            // generateDOCXToolStripMenuItem
            // 
            this.generateDOCXToolStripMenuItem.Name = "generateDOCXToolStripMenuItem";
            this.generateDOCXToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.generateDOCXToolStripMenuItem.Text = "Generate DOCX";
            this.generateDOCXToolStripMenuItem.Click += new System.EventHandler(this.generateDOCXToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatorePasswordClassiToolStripMenuItem,
            this.certificatiCreditiToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "&Utilities";
            // 
            // generatorePasswordClassiToolStripMenuItem
            // 
            this.generatorePasswordClassiToolStripMenuItem.Name = "generatorePasswordClassiToolStripMenuItem";
            this.generatorePasswordClassiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.generatorePasswordClassiToolStripMenuItem.Text = "Generatore Password Classi";
            this.generatorePasswordClassiToolStripMenuItem.Click += new System.EventHandler(this.generatorePasswordClassiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // certificatiCreditiToolStripMenuItem
            // 
            this.certificatiCreditiToolStripMenuItem.Name = "certificatiCreditiToolStripMenuItem";
            this.certificatiCreditiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.certificatiCreditiToolStripMenuItem.Text = "Certificati Crediti";
            this.certificatiCreditiToolStripMenuItem.Click += new System.EventHandler(this.certificatiCreditiToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 531);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "NoidelVV Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vVFotoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatorePasswordClassiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vVAbbigliamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateDOCXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificatiCreditiToolStripMenuItem;

    }
}