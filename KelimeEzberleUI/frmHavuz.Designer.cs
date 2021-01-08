namespace KelimeEzberleUI
{
    partial class frmHavuz
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
            this.btnAlistirma = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbHavuzlar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAlistirma
            // 
            this.btnAlistirma.Location = new System.Drawing.Point(146, 101);
            this.btnAlistirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlistirma.Name = "btnAlistirma";
            this.btnAlistirma.Size = new System.Drawing.Size(269, 44);
            this.btnAlistirma.TabIndex = 14;
            this.btnAlistirma.Text = "Alıştırma Yap";
            this.btnAlistirma.UseVisualStyleBackColor = true;
            this.btnAlistirma.Click += new System.EventHandler(this.btnAlistirma_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(146, 54);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(269, 39);
            this.btnTamam.TabIndex = 13;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Havuz Seçin:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 152);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 366);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İngilizce";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Türkçe";
            this.columnHeader3.Width = 162;
            // 
            // cmbHavuzlar
            // 
            this.cmbHavuzlar.FormattingEnabled = true;
            this.cmbHavuzlar.Location = new System.Drawing.Point(146, 21);
            this.cmbHavuzlar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHavuzlar.Name = "cmbHavuzlar";
            this.cmbHavuzlar.Size = new System.Drawing.Size(268, 24);
            this.cmbHavuzlar.TabIndex = 10;
            this.cmbHavuzlar.SelectedIndexChanged += new System.EventHandler(this.cmbHavuzlar_SelectedIndexChanged);
            // 
            // frmHavuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 542);
            this.Controls.Add(this.btnAlistirma);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbHavuzlar);
            this.Name = "frmHavuz";
            this.Text = "frmHavuz";
            this.Load += new System.EventHandler(this.frmHavuz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlistirma;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cmbHavuzlar;
    }
}