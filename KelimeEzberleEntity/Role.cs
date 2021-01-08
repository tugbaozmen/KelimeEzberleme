using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzberleEntity
{
    public class Role : BaseClass
    {
        public int RolID { get; set; }
        public string RolAd { get; set; }

        public List<Kullanici> Kullanicilar { get; set; }

    }
}
