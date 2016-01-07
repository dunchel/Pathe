using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_aspx
{
    public class Zaal
    {
        public int ZaalID { get; set; }
        public int MaxKijkers { get; set; }
        public string SoortZaal { get; set; }
        public int BioscoopID { get; set; }

        public Zaal(int zaalID, int maxkijkers , string soortZaal , int bioscoopID)
        {

        }
    }
}
