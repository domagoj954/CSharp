using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik {
    class Oglas {
        public Oglas(string naslov, string tekst) {
            Naslov = naslov;
            Tekst = tekst;
        }

        public override string ToString() {
            return string.Format("{0} {1}", Naslov, Tekst);
        }

        public string Naslov { get; set; }
        public string Tekst { get; set; }
    }
}
