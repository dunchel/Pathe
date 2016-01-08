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
            genre.Text = currentfilm.Genre;
            filmrating.Text = currentfilm.Rating.ToString();
            kijkwijzer.Text = currentfilm.Kijkwijzer;
            genre.Text = currentfilm.Genre;
            kwaliteit.Text = currentfilm.Kwaliteit;
            if (currentfilm.is3D == true )
            {
                dimensionaal.Text = "3D";
            }
            else
            {
                dimensionaal.Text = "2D";
            }
            lengte.Text = currentfilm.Lengte.ToString();
            lv_Reacties.DataSource = Classes.Reactie.GetReacties(currentfilm.FilmID);
            lv_Reacties.DataBind();

        }

        protected void lv_Reacties_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            ListViewDataItem dataItem = (ListViewDataItem)e.Item;
            Classes.Reactie reactie = (Classes.Reactie)dataItem.DataItem;

            Label reactietekst = (Label)e.Item.FindControl("reactietekst");
            reactietekst.Text = reactie.ReactieTekst;
        }

        protected void btn_postReactie_Click(object sender, EventArgs e)
        {
            Classes.Reactie.AddReactie(new Reactie(TB_reactie.Text, currentfilm.FilmID));
            Response.Redirect(Request.RawUrl);
        }
    }
}