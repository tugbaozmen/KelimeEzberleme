using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzberleEntity
{
    public class Kelime : BaseClass
    {
        public int KelimeID { get; set; }
        public string Ingilizce { get; set; }
        public string Turkce { get; set; }

        public List<Havuz> Havuzlar { get; set; }
    }
}
