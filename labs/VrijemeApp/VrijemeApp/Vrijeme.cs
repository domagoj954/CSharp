using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VrijemeApp {
  class Vrijeme {
    public Vrijeme() {
      vrijeme = new XmlDocument();
      vrijeme.Load("http://vrijeme.hr/hrvatska_n.xml");
      DohvatiPodatke();
    }

    public void DohvatiPodatke() {
      podaci = new List<VrijemePodatak>();

      XmlNodeList gradovi = vrijeme.GetElementsByTagName("Grad");
      foreach (XmlNode grad in gradovi) {
        podaci.Add(new VrijemePodatak(
            grad["GradIme"].InnerText,
            grad["Podatci"]["Temp"].InnerText,
            grad["Podatci"]["Vlaga"].InnerText,
            grad["Podatci"]["Tlak"].InnerText
        ));
      }
    }

    public IEnumerable<string> DohvatiGradove() {
      return
          from p in podaci
          orderby p.Grad
          select p.Grad;
    }

    public VrijemePodatak DohvatiPodatkeZaGrad(string grad) {
      return
        (from p in podaci
        where p.Grad == grad
        select p).First();
    }

    public IEnumerable<string> DohvatiNajtoplije() {
      return
        (from p in podaci
        orderby p.Temperatura descending
        select p.Grad + ", " + p.Temperatura + " °C").Take(5);
    }

    private XmlDocument vrijeme;
    private List<VrijemePodatak> podaci;
  }
}