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
    public partial class frmKelimeEkle : Form
    {
        int _havuzID;
        HavuzBLL havuzBLL;
        Kelime kelime;
        KelimeBLL kelimeBLL;
        int kelimeID, sentenceID, _kullaniciID;
        Kullanici kullanici;
        public frmKelimeEkle(int havuzID,int kullaniciID)
        {
            InitializeComponent();
            _havuzID = havuzID;
            _kullaniciID = kullaniciID;
            havuzBLL = new HavuzBLL();
            kelime = new Kelime();
            kelimeBLL = new KelimeBLL();
            kullanici = new Kullanici();
        }

        private void kelimeSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem kelime = lstHavuzKelimeler.FocusedItem;
                kelimeID = int.Parse(kelime.Text);
                if (havuzBLL.HavuzdanKelimeSil(kelimeID, _havuzID))
                {
                    MessageBox.Show("Kelime silinmiştir.");
                    FillList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillList()
        {
            lstHavuzKelimeler.Items.Clear();
            List<Kelime> kelimeler = kelimeBLL.KelimeleriGetir();
            ListViewItem lvi;

            foreach (Kelime item in kelimeler)
            {
                lvi = new ListViewItem();
                lvi.Text = item.KelimeID.ToString();
                lvi.SubItems.Add(item.Ingilizce);
                lvi.SubItems.Add(item.Turkce);
                lstHavuzKelimeler.Items.Add(lvi);
            }
        }
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (havuzBLL.HavuzaKelimeEkle(kelimeID, _havuzID))
                {
                    ListViewItem lvi;
                    foreach (Kelime item in kelimeBLL.HavuzunKelimeleri(_havuzID))
                    {
                        lvi = new ListViewItem();
                        lvi.Text = item.KelimeID.ToString();
                        lvi.SubItems.Add(item.Ingilizce);
                        lvi.SubItems.Add(item.Turkce);
                        lstHavuzKelimeler.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmKelimeEkle_Load(object sender, EventArgs e)
        {
            frmHavuzEkle havuzEkle;
            havuzEkle = this.Owner as frmHavuzEkle;
            List<Kelime> kelimeler = kelimeBLL.KelimeleriGetir();
            ListViewItem lvi;
            foreach (Kelime item in kelimeler)
            {
                lvi = new ListViewItem();
                lvi.Text = item.KelimeID.ToString();
                lvi.SubItems.Add(item.Ingilizce);
                lvi.SubItems.Add(item.Turkce);
                lstAnaKelimeler.Tag = kelime.KelimeID;
                lstAnaKelimeler.Items.Add(lvi);
            }
        }

        private void lstHavuzKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem silinecek = lstHavuzKelimeler.FocusedItem;
            sentenceID = int.Parse(silinecek.Text);
        }

        private void lstAnaKelimeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem selected = lstAnaKelimeler.FocusedItem;
            kelimeID = int.Parse(selected.Text);
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            frmHavuz havuz = new frmHavuz(_kullaniciID,_havuzID);
            havuz.Show();
        }
    }
}
