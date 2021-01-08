using KelimeEzberle.BLL;
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
    public partial class frmKullaniciRaporu : Form
    {
        frmAdminPaneli adminPaneli;
        KullaniciBLL _kullaniciBLL;
        public frmKullaniciRaporu()
        {
            InitializeComponent();
            adminPaneli = this.MdiParent as frmAdminPaneli;
            _kullaniciBLL = new KullaniciBLL();
        }

        private void btnKayitlariGetir_Click(object sender, EventArgs e)
        {
            try
            {
                dgvKullanicilar.DataSource = _kullaniciBLL.KisitlidanNormale(dtpBaslangic.Value, dtpBitis.Value);
                dgvKullanicilar.Columns["Rol"].Visible = false;
                dgvKullanicilar.Columns["RolID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
