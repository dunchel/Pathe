using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pathe.Classes
{
    public class Reactie
    {
        public int ReactieID { get; set; }
        public int FilmID { get; set; }
        public string ReactieTekst { get; set; }

        public Reactie(int reactieID, string reactieTekst)
        {

        }

        public override string ToString()
        {
            return null;
        }
    }
}