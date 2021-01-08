using KelimeEzberle.BLL;
using KelimeEzberleEntity;
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
    public partial class frmLogin : Form
    {
        KullaniciBLL _kullaniciBLL;
        Kullanici kullanici;
        int kullaniciID;
        public frmLogin()
        {
            InitializeComponent();
            _kullaniciBLL = new KullaniciBLL();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            string sifre = txtSifre.Text;

            try
            {
                kullanici = _kullaniciBLL.KullaniciDogrulama(mail, sifre);
                if (kullanici != null)
                {
                    kullaniciID = kullanici.KullaniciID;
                    if (kullanici.RolID == 1)
                    {
                        frmAdminPaneli adminForm = new frmAdminPaneli();
                        adminForm.Owner = this;
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmAnasayfa anaSayfaForm = new frmAnasayfa(kullaniciID);
                        anaSayfaForm.Owner = this;
                        anaSayfaForm.ShowDialog();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            frmKayit kayitForm = new frmKayit();
            kayitForm.Show();
            this.Hide();
        }
    }
}
