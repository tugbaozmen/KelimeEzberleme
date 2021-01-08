using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzberleEntity
{
    public class Havuz : BaseClass
    {
        public int HavuzID { get; set; }
        public string HavuzAdi { get; set; }
        public int KullaniciID { get; set; }

        
        public Kullanici Kullanici { get; set; }
        public List<Kelime> Kelimeler { get; set; }
    }
}
