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
    public partial class frmAlistirma : Form
    {
        Random rnd;
        HavuzBLL havuzBLL;
        KelimeBLL kelimeBLL;
        int _havuzID;
        public frmAlistirma(int havuzID)
        {
            InitializeComponent();
            rnd = new Random();
            havuzBLL = new HavuzBLL();
            kelimeBLL = new KelimeBLL();
            _havuzID = havuzID;
        }

        private void btnAlistirma_Click(object sender, EventArgs e)
        {
            List<Kelime> kelimeler = kelimeBLL.HavuzunKelimeleri(_havuzID);
            foreach (Kelime item in kelimeler)
            {

                int deger = rnd.Next(0, kelimeler.Count);
                if (rbIngTurk.Checked)
                {
                    txtIng1.Text = kelimeler[deger].Ingilizce;
                    return;
                }
                else if (rbTurkIng.Checked)
                {
                    TextBoxTemizle();
                    txtTurk1.Text = kelimeler[deger].Turkce;
                    return;
                }
                else
                {
                    TextBoxTemizle();
                    txtIng1.Text = kelimeler[deger].Ingilizce;
                    return;
                }
            }
        }
        private void TextBoxTemizle()
        {
            txtIng1.Clear();
            txtTurk1.Clear();
        }
        private void btnSonucGoster_Click(object sender, EventArgs e)
        {
            List<Kelime> kelimeler = kelimeBLL.HavuzunKelimeleri(_havuzID);
            foreach (Kelime item in kelimeler)
            {
                if (rbIngTurk.Checked)
                {
                    txtTurk1.Text = kelimeBLL.IngKelimeGetir(txtIng1.Text).Turkce;
                    return;
                }
                else if (rbTurkIng.Checked)
                {

                    txtTurk1.Text = kelimeBLL.TurkceKelimeGetir(txtIng1.Text).Ingilizce;
                    return;
                }
                else
                {
                    TextBoxTemizle();
                    label3.Text = "Karışıklığı Düzelt";
                    txtTurk1.Text = kelimeBLL.IngKelimeGetir(txtIng1.Text).Ingilizce;
                    return;
                }
            }
        }
    }
}
