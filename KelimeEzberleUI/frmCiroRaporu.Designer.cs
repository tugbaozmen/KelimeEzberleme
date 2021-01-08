namespace KelimeEzberleUI
{
    partial class frmCiroRaporu
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
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.lblToplamCiro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOdemeler
            // 
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeler.Location = new System.Drawing.Point(12, 110);
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.RowHeadersWidth = 51;
            this.dgvOdemeler.RowTemplate.Height = 24;
            this.dgvOdemeler.Size = new System.Drawing.Size(508, 297);
            this.dgvOdemeler.TabIndex = 4;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(564, 127);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(192, 36);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Toplam Ciro: ";
            // 
            // lblToplamCiro
            // 
            this.lblToplamCiro.AutoSize = true;
            this.lblToplamCiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamCiro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblToplamCiro.Location = new System.Drawing.Point(591, 172);
            this.lblToplamCiro.Name = "lblToplamCiro";
            this.lblToplamCiro.Size = new System.Drawing.Size(0, 29);
            this.lblToplamCiro.TabIndex = 7;
            // 
            // frmCiroRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplamCiro);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvOdemeler);
            this.Name = "frmCiroRaporu";
            this.Text = "frmCiroRaporu";
            this.Load += new System.EventHandler(this.frmCiroRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOdemeler;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblToplamCiro;
    }
}