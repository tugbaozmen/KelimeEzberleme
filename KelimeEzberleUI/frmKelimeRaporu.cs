using KelimeEzberle.BLL;
using System;
using System.Collections;
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
    public partial class frmKelimeRaporu : Form
    {
        KelimeBLL _kelimeBLL;
        frmAdminPaneli adminPaneli;

        public frmKelimeRaporu()
        {
            InitializeComponent();
            _kelimeBLL = new KelimeBLL();
            adminPaneli = this.MdiParent as frmAdminPaneli;
        }

        private void numKelimeSayisi_ValueChanged(object sender, EventArgs e)
        {
            lstKelimeler.Items.Clear();
            Dictionary<int, Dictionary<string, string>> kelimeler = _kelimeBLL.MaksimumTercihKelimeleri((int)numKelimeSayisi.Value);
            ListViewItem lvi;
            foreach (KeyValuePair<int, Dictionary<string, string>> item in kelimeler)
            {
                lvi = new ListViewItem();
                lvi.Text = item.Key.ToString();
                foreach (KeyValuePair<string, string> kelime in item.Value)
                {
                    lvi.SubItems.Add(kelime.Key);
                    lvi.SubItems.Add(kelime.Value);
                }
                lstKelimeler.Items.Add(lvi);
            }

            if (numKelimeSayisi.Value > kelimeler.Count)
            {
                MessageBox.Show("Daha fazla kelime bulunmamaktadır.");
                numKelimeSayisi.Maximum = kelimeler.Count;
            }
        }
    }
}
