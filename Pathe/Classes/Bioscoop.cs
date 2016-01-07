using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_aspx
{
  public  class Bioscoop
    {

        public int BioscoopID { get; set; }
        public string BioscoopNaam { get; set; }
        public string Locatie { get; set; }

        public int Zalen { get; set; }
        public bool IMAXZaal { get; set; }
        public bool KlimaatControle { get; set; }
        public bool RolstoelMogelijkheid { get; set; }

        public bool  RingLeiding { get; set; }

        public bool InvalidenToilet { get; set; }

        public int AantalStoelen { get; set; }
        

        public Bioscoop(int bioscoopID, string bioscoopNaam, string locatie, int zalen, bool imaxZaal, bool klimaatControle, bool rolstoelMogelijkheid, bool ringLeiding, bool invalidenToilet, int aantalStoelen)
        {
            this.BioscoopID = bioscoopID;
            this.BioscoopNaam = bioscoopNaam;
            this.Locatie = locatie;
            this.Zalen = zalen;
            this.IMAXZaal = imaxZaal;
            this.KlimaatControle = klimaatControle;
            this.RolstoelMogelijkheid = rolstoelMogelijkheid;
            this.RingLeiding = ringLeiding;
            this.InvalidenToilet = invalidenToilet;
            this.AantalStoelen = aantalStoelen;
        }
    }
}
