using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pathe.Database;

namespace Pathe.Classes
{
    public class Reactie
    {
        public int ReactieID { get; set; }
        public int FilmID { get; set; }
        public string ReactieTekst { get; set; }

        public Reactie( string reactieTekst , int filmid)
        {
            this.FilmID = filmid;
            this.ReactieTekst = reactieTekst;
        }
      

        public Reactie(int ReactieID, string reactietekst, int filmID)
        {
            this.ReactieID = ReactieID;
            this.ReactieTekst = reactietekst;
            this.FilmID = filmID;
        }

        public override string ToString()
        {
            return null;
        }

        public static List<Reactie> GetReacties(int filmid)
        {
            DatabaseHandler db = new DatabaseHandler();
            return db.GetReacties(filmid);
        }

        public static bool AddReactie(Reactie reactietoadd)
        {
            DatabaseHandler db = new DatabaseHandler();

            return db.AddReview(reactietoadd);
        }
    }
}