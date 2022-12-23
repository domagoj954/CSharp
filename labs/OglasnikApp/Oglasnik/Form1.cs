using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oglasnik {
    public partial class FormMain : Form {
        Oglasnik oglasnik;

        public FormMain() {
            InitializeComponent();
            oglasnik = new Oglasnik();
        }

        private void btnDodajOglas_Click(object sender, EventArgs e) {
            if (cbSlikovniOglas.Checked && cbVideoOglas.Checked) {
                MessageBox.Show("Ne može se postaviti oglas koji je i slikovni i video.");
            } else {
                if (cbSlikovniOglas.Checked) {
                    oglasnik.DodajOglas(new SlikovniOglas(tbNaslov.Text, tbTekst.Text, tbSlikovniLink.Text));
                } else if (cbVideoOglas.Checked) {
                    oglasnik.DodajOglas(new VideoOglas(tbNaslov.Text, tbTekst.Text, tbVideoLink.Text));
                } else {
                    oglasnik.DodajOglas(new Oglas(tbNaslov.Text, tbTekst.Text));
                }

                lbOglasi.Items.Clear();
                foreach (var oglas in oglasnik.VratiOglase()) {
                    lbOglasi.Items.Add(oglas);
                }
            }
        }
    }
}
