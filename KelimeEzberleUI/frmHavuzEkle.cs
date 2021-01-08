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
    public partial class frmHavuzEkle : Form
    {
        Havuz havuz;
        HavuzBLL _havuzBLL;
        frmAnasayfa anaSayfaForm;
        public frmHavuzEkle()
        {
            InitializeComponent();
            havuz = new Havuz();
            _havuzBLL = new HavuzBLL();
        }

        private void btnHavuzOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                havuz.HavuzAdi = txtHavuzAdi.Text;
                havuz.KullaniciID = anaSayfaForm.KullaniciIDAl();

                if (_havuzBLL.HavuzEkle(havuz))
                {
                    MessageBox.Show("Havuz başarı ile eklenmiştir.");
                }
                else
                {
                    MessageBox.Show("Ekleme gerçekleştirilemedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //TODO: 
            int deger = _havuzBLL.SonHavuzIDGetir();
            frmKelimeEkle kelimeEkle = new frmKelimeEkle(deger, havuz.KullaniciID);
            kelimeEkle.Show();
            this.Hide();
        }

        private void frmHavuzEkle_Load(object sender, EventArgs e)
        {
            anaSayfaForm = this.MdiParent as frmAnasayfa;
        }
    }
}
