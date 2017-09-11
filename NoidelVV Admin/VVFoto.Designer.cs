namespace NoidelVV_Admin
{
    partial class VVFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VVFoto));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vvfoto_classes = new System.Windows.Forms.ListBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.n_fotoBig = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.n_fotoSmall = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.payed = new System.Windows.Forms.Label();
            this.n_annuari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vvfotoPrint = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.vvfoto_classes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(745, 558);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 1;
            // 
            // vvfoto_classes
            // 
            this.vvfoto_classes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vvfoto_classes.FormattingEnabled = true;
            this.vvfoto_classes.Location = new System.Drawing.Point(0, 0);
            this.vvfoto_classes.Name = "vvfoto_classes";
            this.vvfoto_classes.Size = new System.Drawing.Size(217, 558);
            this.vvfoto_classes.TabIndex = 0;
            this.vvfoto_classes.SelectedIndexChanged += new System.EventHandler(this.vvfoto_classes_SelectedIndexChanged_1);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(524, 558);
            this.splitContainer2.SplitterDistance = 260;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.n_fotoBig);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foto 15x22";
            // 
            // n_fotoBig
            // 
            this.n_fotoBig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n_fotoBig.Location = new System.Drawing.Point(3, 16);
            this.n_fotoBig.Multiline = true;
            this.n_fotoBig.Name = "n_fotoBig";
            this.n_fotoBig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.n_fotoBig.Size = new System.Drawing.Size(518, 241);
            this.n_fotoBig.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button1);
            this.splitContainer3.Panel2.Controls.Add(this.payed);
            this.splitContainer3.Panel2.Controls.Add(this.n_annuari);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Size = new System.Drawing.Size(524, 294);
            this.splitContainer3.SplitterDistance = 250;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.n_fotoSmall);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Foto 20x30";
            // 
            // n_fotoSmall
            // 
            this.n_fotoSmall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n_fotoSmall.Location = new System.Drawing.Point(3, 16);
            this.n_fotoSmall.Multiline = true;
            this.n_fotoSmall.Name = "n_fotoSmall";
            this.n_fotoSmall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.n_fotoSmall.Size = new System.Drawing.Size(518, 231);
            this.n_fotoSmall.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Stampa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // payed
            // 
            this.payed.AutoSize = true;
            this.payed.ForeColor = System.Drawing.Color.Red;
            this.payed.Location = new System.Drawing.Point(370, 10);
            this.payed.Name = "payed";
            this.payed.Size = new System.Drawing.Size(64, 13);
            this.payed.TabIndex = 2;
            this.payed.Text = "Non Pagato";
            // 
            // n_annuari
            // 
            this.n_annuari.AutoSize = true;
            this.n_annuari.Location = new System.Drawing.Point(54, 10);
            this.n_annuari.Name = "n_annuari";
            this.n_annuari.Size = new System.Drawing.Size(13, 13);
            this.n_annuari.TabIndex = 1;
            this.n_annuari.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Annuari:";
            // 
            // vvfotoPrint
            // 
            this.vvfotoPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.vvfotoPrint_PrintPage);
            // 
            // VVFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 558);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(761, 597);
            this.MinimumSize = new System.Drawing.Size(761, 597);
            this.Name = "VVFoto";
            this.Text = "VVFoto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VVFoto_FormClosing);
            this.Load += new System.EventHandler(this.VVFoto_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox vvfoto_classes;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox n_fotoBig;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox n_fotoSmall;
        private System.Windows.Forms.Label payed;
        private System.Windows.Forms.Label n_annuari;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument vvfotoPrint;
        private System.Windows.Forms.Button button1;
    }
}