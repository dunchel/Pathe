using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_aspx
{
   public class Speelfilm
    {
        public int SpeelfilmID { get; set; }

        public string Begintijd { get; set; }

        public string Eindtijd { get; set; }

        public DateTime Datum { get; set; }

        public int FilmID { get; set; }

        public int ZaalID { get; set; }

        public Speelfilm(int speelfilm, string begintijd, string eindtijd, DateTime datum, int filmID, int zaalID)
        {

        }

           
    }
}
