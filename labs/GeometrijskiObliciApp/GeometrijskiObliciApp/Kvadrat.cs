using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskiObliciApp {
    class Kvadrat : GeometrijskiOblik, IGeometrijskiOblik {
        public Kvadrat(double stranica) {
            Stranica = stranica;
        }

        public override string Opis() {
            var opis = string.Format("Kvadrat ({0}): Površina: {1}",
                Stranica, Povrsina());
            return opis;
        }

        private double Povrsina() {
            return Stranica * Stranica;
        }

        public double Stranica { get; set; }
    }
}
