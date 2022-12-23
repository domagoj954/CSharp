using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiObliciApp {
    class Oblici {
        public Oblici() {
            oblici = new List<IGeometrijskiOblik>();
        }

        public void DodajOblik(IGeometrijskiOblik oblik) {
            oblici.Add(oblik);
        }

        public string Opisi() {
            string opisi = "";
            foreach (var oblik in oblici) {
                opisi += oblik.Opis() + "\r\n";
            }
            return opisi;
        }

        private List<IGeometrijskiOblik> oblici;
    }
}
