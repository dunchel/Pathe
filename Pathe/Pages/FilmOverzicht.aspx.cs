using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pathe.Classes;
using System.Data;


namespace Pathe.Pages
{
    public partial class FilmOverzicht : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_FilmList.DataSource = Classes.Film.GetFilms();
            lv_FilmList.DataBind();
        }

        protected void lv_FilmList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lv_FilmList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            ListViewDataItem dataItem = (ListViewDataItem)e.Item;
            Classes.Film film = (Classes.Film)dataItem.DataItem;

           
            
            Label rating = (Label)e.Item.FindControl("filmrating");
            rating.Text = film.Rating.ToString();

            Label kijkwijzer = (Label)e.Item.FindControl("kijkwijzer");
            kijkwijzer.Text = film.Kijkwijzer;

            Label genre = (Label)e.Item.FindControl("genre");
            genre.Text = film.Genre;

            Label kwaliteit = (Label)e.Item.FindControl("kwaliteit");
            kwaliteit.Text = film.Kwaliteit;


            Label dimensionaal = (Label)e.Item.FindControl("dimensionaal");

            if (film.is3D == true)
            {
                dimensionaal.Text = "3D";
            }
            else
            {
                dimensionaal.Text = "2D";
            }

            Label lengte = (Label)e.Item.FindControl("lengte");
            lengte.Text = film.Lengte + " minuten";

    
        }

      
    }
}