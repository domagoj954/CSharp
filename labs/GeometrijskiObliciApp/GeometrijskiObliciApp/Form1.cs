using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometrijskiObliciApp {
    public partial class Form1 : Form {
        Oblici oblici;
        public Form1() {
            InitializeComponent();
            oblici = new Oblici();
        }

        private void btnDodajKvadrat_Click(object sender, EventArgs e) {
            oblici.DodajOblik(new Kvadrat(double.Parse(tbStranicaKvadrata.Text)));
            tbGeometrijskiOblici.Text = oblici.Opisi();
        }
    }
}
