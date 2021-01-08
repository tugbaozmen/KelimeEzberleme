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
    public partial class frmAnasayfa : Form
    {
        int _kullaniciID;
        public frmAnasayfa(int kullaniciID)
        {
            InitializeComponent();
            _kullaniciID = kullaniciID;
        }

        private void havuzlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavuzEkle havuzEkleform = new frmHavuzEkle();
            havuzEkleform.MdiParent = this;
            havuzEkleform.Show();
        }
        public int KullaniciIDAl()
        {
            return _kullaniciID;
        }
    }
}
