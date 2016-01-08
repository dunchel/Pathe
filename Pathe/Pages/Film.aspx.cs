using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pathe.Classes;

namespace Pathe.Pages
{
    public partial class Film : System.Web.UI.Page
    {
        private Classes.Film currentfilm;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.Params["id"]);
            currentfilm = Classes.Film.GetFilm(id);
            if (currentfilm == null)
            {
                Response.Redirect("FilmOverzicht.aspx");
            }
            filmnaam.Text = currentfilm.FilmNaam;
        }
    }
}