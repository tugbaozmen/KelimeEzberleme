namespace KelimeEzberleUI
{
    partial class frmKelimeRaporu
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
            this.numKelimeSayisi = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lstKelimeler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numKelimeSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // numKelimeSayisi
            // 
            this.numKelimeSayisi.Location = new System.Drawing.Point(12, 49);
            this.numKelimeSayisi.Name = "numKelimeSayisi";
            this.numKelimeSayisi.Size = new System.Drawing.Size(120, 22);
            this.numKelimeSayisi.TabIndex = 0;
            this.numKelimeSayisi.ValueChanged += new System.EventHandler(this.numKelimeSayisi_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "En çok tekrarlanan kaç kelime getirmek istediğinizi seçiniz: ";
            // 
            // lstKelimeler
            // 
            this.lstKelimeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstKelimeler.FullRowSelect = true;
            this.lstKelimeler.GridLines = true;
            this.lstKelimeler.HideSelection = false;
            this.lstKelimeler.Location = new System.Drawing.Point(12, 97);
            this.lstKelimeler.Name = "lstKelimeler";
            this.lstKelimeler.Size = new System.Drawing.Size(379, 228);
            this.lstKelimeler.TabIndex = 2;
            this.lstKelimeler.UseCompatibleStateImageBehavior = false;
            this.lstKelimeler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tercih Sayısı";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İngilizcesi";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Türkçesi";
            this.columnHeader3.Width = 123;
            // 
            // frmKelimeRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 336);
            this.Controls.Add(this.lstKelimeler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numKelimeSayisi);
            this.Name = "frmKelimeRaporu";
            this.Text = "Kelime Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.numKelimeSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numKelimeSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstKelimeler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}