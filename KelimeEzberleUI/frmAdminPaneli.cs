using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeEzberleUI
{
    public partial class frmAdminPaneli : Form
    {
        public frmAdminPaneli()
        {
            InitializeComponent();
        }

        private void kullaniciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciListele kullaniciListele = new frmKullaniciListele();
            kullaniciListele.MdiParent = this;
            kullaniciListele.Show();
        }

        private void kelimeRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKelimeRaporu kelimeRaporu = new frmKelimeRaporu();
            kelimeRaporu.MdiParent = this;
            kelimeRaporu.Show();
        }

        private void kullaniciRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciRaporu kullaniciRaporu = new frmKullaniciRaporu();
            kullaniciRaporu.MdiParent = this;
            kullaniciRaporu.Show();
        }

        private void ciroRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiroRaporu ciroRaporu = new frmCiroRaporu();
            ciroRaporu.MdiParent = this;
            ciroRaporu.Show();
        }
    }
}
