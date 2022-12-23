using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik {
    class Oglasnik {
        public Oglasnik() {
            oglasi = new List<Oglas>();
            slikovniOglasi = new List<SlikovniOglas>();
            videoOglasi = new List<VideoOglas>();
        }

        public List<string> VratiOglase() {
            List<string> oglasiTekstualni = new List<string>();
            foreach (var oglas in oglasi) {
                oglasiTekstualni.Add(oglas.ToString());
            }
            foreach (var oglas in slikovniOglasi) {
                oglasiTekstualni.Add(oglas.ToString());
            }
            foreach (var oglas in videoOglasi) {
                oglasiTekstualni.Add(oglas.ToString());
            }
            return oglasiTekstualni;
        }

        public void DodajOglas(Oglas oglas) {
            oglasi.Add(oglas);
        }

        public void DodajOglas(SlikovniOglas slikovniOglas) {
            slikovniOglasi.Add(slikovniOglas);
        }

        public void DodajOglas(VideoOglas videoOglas) {
            videoOglasi.Add(videoOglas);
        }

        List<Oglas> oglasi;
        List<SlikovniOglas> slikovniOglasi;
        List<VideoOglas> videoOglasi;
    }
}
