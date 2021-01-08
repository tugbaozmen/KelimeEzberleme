namespace KelimeEzberleUI
{
    partial class frmKullaniciRaporu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnKayitlariGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi: ";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "";
            this.dtpBaslangic.Location = new System.Drawing.Point(15, 41);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(273, 41);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 22);
            this.dtpBitis.TabIndex = 3;
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AllowUserToDeleteRows = false;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(15, 95);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.RowHeadersWidth = 51;
            this.dgvKullanicilar.RowTemplate.Height = 24;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(773, 343);
            this.dgvKullanicilar.TabIndex = 4;
            // 
            // btnKayitlariGetir
            // 
            this.btnKayitlariGetir.Location = new System.Drawing.Point(515, 32);
            this.btnKayitlariGetir.Name = "btnKayitlariGetir";
            this.btnKayitlariGetir.Size = new System.Drawing.Size(111, 31);
            this.btnKayitlariGetir.TabIndex = 5;
            this.btnKayitlariGetir.Text = "Kayıtları Getir";
            this.btnKayitlariGetir.UseVisualStyleBackColor = true;
            this.btnKayitlariGetir.Click += new System.EventHandler(this.btnKayitlariGetir_Click);
            // 
            // frmKullaniciRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKayitlariGetir);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKullaniciRaporu";
            this.Text = "Kısıtlıdan Normale Geçen Kullanıcılar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Button btnKayitlariGetir;
    }
}