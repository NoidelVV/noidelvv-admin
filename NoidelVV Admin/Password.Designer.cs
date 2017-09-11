namespace NoidelVV_Admin
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.fileTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generatePswBt = new System.Windows.Forms.Button();
            this.yearMTB = new System.Windows.Forms.MaskedTextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.textTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // fileTB
            // 
            this.fileTB.Location = new System.Drawing.Point(124, 6);
            this.fileTB.Name = "fileTB";
            this.fileTB.Size = new System.Drawing.Size(230, 20);
            this.fileTB.TabIndex = 0;
            this.fileTB.TextChanged += new System.EventHandler(this.fileTB_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "XLSX Passwords\' file";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // generatePswBt
            // 
            this.generatePswBt.Location = new System.Drawing.Point(251, 299);
            this.generatePswBt.Name = "generatePswBt";
            this.generatePswBt.Size = new System.Drawing.Size(135, 39);
            this.generatePswBt.TabIndex = 3;
            this.generatePswBt.Text = "Generate Password File";
            this.generatePswBt.UseVisualStyleBackColor = true;
            this.generatePswBt.Click += new System.EventHandler(this.generatePswBt_Click);
            // 
            // yearMTB
            // 
            this.yearMTB.Location = new System.Drawing.Point(124, 58);
            this.yearMTB.Mask = "2\\010/2\\010";
            this.yearMTB.Name = "yearMTB";
            this.yearMTB.Size = new System.Drawing.Size(60, 20);
            this.yearMTB.TabIndex = 4;
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(124, 32);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(230, 20);
            this.titleTB.TabIndex = 5;
            this.titleTB.Text = "Noi del VV ~ Password Utenti";
            // 
            // textTB
            // 
            this.textTB.Location = new System.Drawing.Point(12, 102);
            this.textTB.Multiline = true;
            this.textTB.Name = "textTB";
            this.textTB.Size = new System.Drawing.Size(374, 191);
            this.textTB.TabIndex = 6;
            this.textTB.Text = resources.GetString("textTB.Text");
            this.textTB.TextChanged += new System.EventHandler(this.textTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titolo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Anno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Testo";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Crediti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.yearMTB);
            this.Controls.Add(this.generatePswBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileTB);
            this.Name = "Crediti";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generatePswBt;
        private System.Windows.Forms.MaskedTextBox yearMTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox textTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}