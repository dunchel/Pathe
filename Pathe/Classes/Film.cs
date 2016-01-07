using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pathe.Classes
{
    public class Film
    {
        public int FilmID { get; set; }
        public string FilmNaam { get; set; }
        public int Rating { get; set; }
        public string Kijkwijzer { get; set; }
        public string Genre { get; set; }
        public string Kwaliteit { get; set; }
        public bool is3D { get; set; }
        public string Lengte { get; set; }

        public Film(int filmID, string filmNaam, int rating, string kijkwijzer, string genre, string kwaliteit, bool id3D, string lengte)
        {
            this.FilmID = filmID;
            this.FilmNaam = filmNaam;

        }

        public override string ToString()
        {
            return null;
        }
    }
}