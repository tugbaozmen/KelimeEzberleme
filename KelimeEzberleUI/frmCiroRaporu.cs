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
    public partial class frmCiroRaporu : Form
    {
        KullaniciOdemeBLL _kullaniciOdeme;
        public frmCiroRaporu()
        {
            InitializeComponent();
            _kullaniciOdeme = new KullaniciOdemeBLL();
        }

        private void frmCiroRaporu_Load(object sender, EventArgs e)
        {
            dgvOdemeler.DataSource = _kullaniciOdeme.YapilanOdemeler();
            dgvOdemeler.Columns["Kullanici"].Visible = false;
            dgvOdemeler.Columns["Odeme"].Visible = false;
            lblToplamCiro.Text = _kullaniciOdeme.ToplamCiro().ToString("C2");
        }
    }
}
