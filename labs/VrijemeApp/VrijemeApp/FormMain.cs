using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VrijemeApp {
  public partial class FormMain : Form {
    Vrijeme vrijeme;

    public FormMain() {
      InitializeComponent();
      vrijeme = new Vrijeme();
    }

    private void FormMain_Load(object sender, EventArgs e) {
      // cbCities.Items.Add("Bjelovar");
      /*foreach (var grad in vrijeme.DohvatiGradove()) {
        cbCities.Items.Add(grad);
      }*/
      /*cbCities.Items.AddRange(vrijeme.DohvatiGradove().ToArray());
      lbWarmestCities.Items.AddRange(vrijeme.DohvatiNajtoplije().ToArray());*/
      AzurirajKontrole();
    }

    private void cbCities_TextChanged(object sender, EventArgs e) {
      var podatak = vrijeme.DohvatiPodatkeZaGrad(cbCities.Text);
      lblCity.Text = podatak.Grad;
      //lblCityTemperature.Text = podatak.Temperatura + " °C";
      lblCityTemperature.Text = string.Format("{0} °C", podatak.Temperatura);
    }

    private void tmrRefresh_Tick(object sender, EventArgs e) {
      vrijeme = new Vrijeme();
    }

    private void AzurirajKontrole() {
      cbCities.Items.Clear();
      cbCities.Items.AddRange(vrijeme.DohvatiGradove().ToArray());
      lbWarmestCities.Items.Clear();
      lbWarmestCities.Items.AddRange(vrijeme.DohvatiNajtoplije().ToArray());
    }
  }
}
