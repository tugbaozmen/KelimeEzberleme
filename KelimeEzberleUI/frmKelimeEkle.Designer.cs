namespace KelimeEzberleUI
{
    partial class frmKelimeEkle
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
            this.btnTamam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstHavuzKelimeler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kelimeSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstAnaKelimeler = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(399, 339);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(152, 28);
            this.btnTamam.TabIndex = 11;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Havuzumdaki Kelimeler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kelimeler";
            // 
            // lstHavuzKelimeler
            // 
            this.lstHavuzKelimeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.lstHavuzKelimeler.ContextMenuStrip = this.contextMenuStrip1;
            this.lstHavuzKelimeler.FullRowSelect = true;
            this.lstHavuzKelimeler.GridLines = true;
            this.lstHavuzKelimeler.HideSelection = false;
            this.lstHavuzKelimeler.Location = new System.Drawing.Point(339, 35);
            this.lstHavuzKelimeler.Margin = new System.Windows.Forms.Padding(4);
            this.lstHavuzKelimeler.Name = "lstHavuzKelimeler";
            this.lstHavuzKelimeler.Size = new System.Drawing.Size(261, 277);
            this.lstHavuzKelimeler.TabIndex = 7;
            this.lstHavuzKelimeler.UseCompatibleStateImageBehavior = false;
            this.lstHavuzKelimeler.View = System.Windows.Forms.View.Details;
            this.lstHavuzKelimeler.SelectedIndexChanged += new System.EventHandler(this.lstHavuzKelimeler_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kelime No";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İngilizce";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Türkçe";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kelimeSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 28);
            // 
            // kelimeSilToolStripMenuItem
            // 
            this.kelimeSilToolStripMenuItem.Name = "kelimeSilToolStripMenuItem";
            this.kelimeSilToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.kelimeSilToolStripMenuItem.Text = "Kelime Sil";
            this.kelimeSilToolStripMenuItem.Click += new System.EventHandler(this.kelimeSilToolStripMenuItem_Click);
            // 
            // lstAnaKelimeler
            // 
            this.lstAnaKelimeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstAnaKelimeler.ContextMenuStrip = this.contextMenuStrip2;
            this.lstAnaKelimeler.FullRowSelect = true;
            this.lstAnaKelimeler.GridLines = true;
            this.lstAnaKelimeler.HideSelection = false;
            this.lstAnaKelimeler.Location = new System.Drawing.Point(35, 35);
            this.lstAnaKelimeler.Margin = new System.Windows.Forms.Padding(4);
            this.lstAnaKelimeler.Name = "lstAnaKelimeler";
            this.lstAnaKelimeler.Size = new System.Drawing.Size(259, 277);
            this.lstAnaKelimeler.TabIndex = 8;
            this.lstAnaKelimeler.UseCompatibleStateImageBehavior = false;
            this.lstAnaKelimeler.View = System.Windows.Forms.View.Details;
            this.lstAnaKelimeler.SelectedIndexChanged += new System.EventHandler(this.lstAnaKelimeler_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kelime No";
            this.columnHeader6.Width = 69;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "İngilizce";
            this.columnHeader7.Width = 66;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Türkçe";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(106, 28);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.ekleToolStripMenuItem.Text = "Ekle";
            this.ekleToolStripMenuItem.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // frmKelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 387);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstHavuzKelimeler);
            this.Controls.Add(this.lstAnaKelimeler);
            this.Name = "frmKelimeEkle";
            this.Text = "frmKelimeEkle";
            this.Load += new System.EventHandler(this.frmKelimeEkle_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstHavuzKelimeler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lstAnaKelimeler;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kelimeSilToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
    }
}