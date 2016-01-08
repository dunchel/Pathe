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

            if (Session["currentUser"] is Users)
            {
                Users user = (Users)Session["currentUser"];
                if (user.Abbonement == "ADMIN")
                {
                    AddMovieDialog.Visible = true;
                    btn_AddFilm.Visible = true;
                }
            }
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

        protected void btn_AddFilm_Click(object sender, EventArgs e)
        {
            bool is3d;
            if (dp_Dimensionaal.SelectedValue == "2D")
            {
                is3d = false;
            }
            else
            {
                is3d = true;
            }

            int rating;
           if( int.TryParse(TB_Rating.Text, out rating))
            {
                Classes.Film film = new Classes.Film(TB_Filmnaam.Text, Convert.ToInt32(TB_Rating.Text), TB_Kijkwijzer.Text, TB_Genre.Text, TB_Kwaliteit.Text, is3d, Lengte.Text);
                Classes.Film.AddFilm(film);
                Response.Redirect(Request.RawUrl);
            }
           else
            {
                filmoverzichtlabel.InnerText = "de film is niet toegevoegd!";
            }
           

        }
    }
}