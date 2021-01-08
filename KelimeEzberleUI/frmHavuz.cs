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
    public partial class frmHavuz : Form
    {
        HavuzBLL havuzBLL;
        Havuz havuz;
        int _kullaniciID;
        int _havuzID, havuzId;
        KelimeBLL kelimeBLL;
        public frmHavuz(int kullaniciID, int havuzID)
        {
            InitializeComponent();
            havuzBLL = new HavuzBLL();
            havuz = new Havuz();
            _kullaniciID = kullaniciID;
            _havuzID = havuzID;
            kelimeBLL = new KelimeBLL();
        }

        private void frmHavuz_Load(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = new Kullanici();
                List<Havuz> kullaniciHavuzlari = havuzBLL.KullaniciHavuzlari(_kullaniciID);

                cmbHavuzlar.DisplayMember = "HavuzAdi";
                cmbHavuzlar.ValueMember = "HavuzID";
                cmbHavuzlar.DataSource = kullaniciHavuzlari;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlistirma_Click(object sender, EventArgs e)
        {
            frmAlistirma alistirmaForm = new frmAlistirma(_havuzID);
            alistirmaForm.Show();
            this.Hide();
        }

        private void cmbHavuzlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            havuzId = (int)cmbHavuzlar.SelectedValue;
        }
    }
}
