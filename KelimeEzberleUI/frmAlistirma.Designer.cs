namespace KelimeEzberleUI
{
    partial class frmAlistirma
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
            this.btnSonucGoster = new System.Windows.Forms.Button();
            this.btnAlistirma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTurk1 = new System.Windows.Forms.TextBox();
            this.txtIng1 = new System.Windows.Forms.TextBox();
            this.gbAlistirmalar = new System.Windows.Forms.GroupBox();
            this.rbIngTurk = new System.Windows.Forms.RadioButton();
            this.rbKarisik = new System.Windows.Forms.RadioButton();
            this.rbTurkIng = new System.Windows.Forms.RadioButton();
            this.gbAlistirmalar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSonucGoster
            // 
            this.btnSonucGoster.Location = new System.Drawing.Point(269, 218);
            this.btnSonucGoster.Margin = new System.Windows.Forms.Padding(4);
            this.btnSonucGoster.Name = "btnSonucGoster";
            this.btnSonucGoster.Size = new System.Drawing.Size(133, 42);
            this.btnSonucGoster.TabIndex = 26;
            this.btnSonucGoster.Text = "Sonucu Göster";
            this.btnSonucGoster.UseVisualStyleBackColor = true;
            this.btnSonucGoster.Click += new System.EventHandler(this.btnSonucGoster_Click);
            // 
            // btnAlistirma
            // 
            this.btnAlistirma.Location = new System.Drawing.Point(65, 218);
            this.btnAlistirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlistirma.Name = "btnAlistirma";
            this.btnAlistirma.Size = new System.Drawing.Size(133, 42);
            this.btnAlistirma.TabIndex = 25;
            this.btnAlistirma.Text = "Başla";
            this.btnAlistirma.UseVisualStyleBackColor = true;
            this.btnAlistirma.Click += new System.EventHandler(this.btnAlistirma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Türkçe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "İngilizce";
            // 
            // txtTurk1
            // 
            this.txtTurk1.Location = new System.Drawing.Point(269, 148);
            this.txtTurk1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTurk1.Name = "txtTurk1";
            this.txtTurk1.Size = new System.Drawing.Size(132, 22);
            this.txtTurk1.TabIndex = 21;
            // 
            // txtIng1
            // 
            this.txtIng1.Location = new System.Drawing.Point(65, 148);
            this.txtIng1.Margin = new System.Windows.Forms.Padding(4);
            this.txtIng1.Name = "txtIng1";
            this.txtIng1.Size = new System.Drawing.Size(132, 22);
            this.txtIng1.TabIndex = 22;
            // 
            // gbAlistirmalar
            // 
            this.gbAlistirmalar.Controls.Add(this.rbIngTurk);
            this.gbAlistirmalar.Controls.Add(this.rbKarisik);
            this.gbAlistirmalar.Controls.Add(this.rbTurkIng);
            this.gbAlistirmalar.Location = new System.Drawing.Point(26, 13);
            this.gbAlistirmalar.Margin = new System.Windows.Forms.Padding(4);
            this.gbAlistirmalar.Name = "gbAlistirmalar";
            this.gbAlistirmalar.Padding = new System.Windows.Forms.Padding(4);
            this.gbAlistirmalar.Size = new System.Drawing.Size(432, 73);
            this.gbAlistirmalar.TabIndex = 20;
            this.gbAlistirmalar.TabStop = false;
            this.gbAlistirmalar.Text = "Alıştırmalar";
            // 
            // rbIngTurk
            // 
            this.rbIngTurk.AutoSize = true;
            this.rbIngTurk.Location = new System.Drawing.Point(8, 23);
            this.rbIngTurk.Margin = new System.Windows.Forms.Padding(4);
            this.rbIngTurk.Name = "rbIngTurk";
            this.rbIngTurk.Size = new System.Drawing.Size(128, 21);
            this.rbIngTurk.TabIndex = 5;
            this.rbIngTurk.TabStop = true;
            this.rbIngTurk.Text = "İngilizce-Türkçe";
            this.rbIngTurk.UseVisualStyleBackColor = true;
            // 
            // rbKarisik
            // 
            this.rbKarisik.AutoSize = true;
            this.rbKarisik.Location = new System.Drawing.Point(283, 23);
            this.rbKarisik.Margin = new System.Windows.Forms.Padding(4);
            this.rbKarisik.Name = "rbKarisik";
            this.rbKarisik.Size = new System.Drawing.Size(125, 21);
            this.rbKarisik.TabIndex = 5;
            this.rbKarisik.TabStop = true;
            this.rbKarisik.Text = "Karışık İngilizce";
            this.rbKarisik.UseVisualStyleBackColor = true;
            // 
            // rbTurkIng
            // 
            this.rbTurkIng.AutoSize = true;
            this.rbTurkIng.Location = new System.Drawing.Point(141, 23);
            this.rbTurkIng.Margin = new System.Windows.Forms.Padding(4);
            this.rbTurkIng.Name = "rbTurkIng";
            this.rbTurkIng.Size = new System.Drawing.Size(128, 21);
            this.rbTurkIng.TabIndex = 5;
            this.rbTurkIng.TabStop = true;
            this.rbTurkIng.Text = "Türkçe-İngilizce";
            this.rbTurkIng.UseVisualStyleBackColor = true;
            // 
            // frmAlistirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 304);
            this.Controls.Add(this.btnSonucGoster);
            this.Controls.Add(this.btnAlistirma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTurk1);
            this.Controls.Add(this.txtIng1);
            this.Controls.Add(this.gbAlistirmalar);
            this.Name = "frmAlistirma";
            this.Text = "frmAlistirma";
            this.gbAlistirmalar.ResumeLayout(false);
            this.gbAlistirmalar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSonucGoster;
        private System.Windows.Forms.Button btnAlistirma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTurk1;
        private System.Windows.Forms.TextBox txtIng1;
        private System.Windows.Forms.GroupBox gbAlistirmalar;
        private System.Windows.Forms.RadioButton rbIngTurk;
        private System.Windows.Forms.RadioButton rbKarisik;
        private System.Windows.Forms.RadioButton rbTurkIng;
    }
}