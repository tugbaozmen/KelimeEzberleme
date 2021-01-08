using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzberleEntity
{
    public class Odeme : BaseClass
    {
        public int OdemeID { get; set; }
        public string OdemeTuru { get; set; }
 

        public List<Kullanici> Kullanicilar { get; set; }
        public KullaniciOdeme KullaniciOdeme { get; set; }
    }
}
