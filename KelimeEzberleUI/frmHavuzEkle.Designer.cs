﻿namespace KelimeEzberleUI
{
    partial class frmHavuzEkle
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
            this.btnHavuzOlustur = new System.Windows.Forms.Button();
            this.txtHavuzAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHavuzOlustur
            // 
            this.btnHavuzOlustur.Location = new System.Drawing.Point(134, 71);
            this.btnHavuzOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.btnHavuzOlustur.Name = "btnHavuzOlustur";
            this.btnHavuzOlustur.Size = new System.Drawing.Size(244, 38);
            this.btnHavuzOlustur.TabIndex = 5;
            this.btnHavuzOlustur.Text = "Havuz Oluştur";
            this.btnHavuzOlustur.UseVisualStyleBackColor = true;
            this.btnHavuzOlustur.Click += new System.EventHandler(this.btnHavuzOlustur_Click);
            // 
            // txtHavuzAdi
            // 
            this.txtHavuzAdi.Location = new System.Drawing.Point(134, 13);
            this.txtHavuzAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHavuzAdi.Name = "txtHavuzAdi";
            this.txtHavuzAdi.Size = new System.Drawing.Size(243, 22);
            this.txtHavuzAdi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Havuz Adı :";
            // 
            // frmHavuzEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 142);
            this.Controls.Add(this.btnHavuzOlustur);
            this.Controls.Add(this.txtHavuzAdi);
            this.Controls.Add(this.label1);
            this.Name = "frmHavuzEkle";
            this.Text = "frmHavuzEkle";
            this.Load += new System.EventHandler(this.frmHavuzEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHavuzOlustur;
        private System.Windows.Forms.TextBox txtHavuzAdi;
        private System.Windows.Forms.Label label1;
    }
}