using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pathe.Database;
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
            this.Rating = rating;
            this.Kijkwijzer = kijkwijzer;
            this.Genre = genre;
            this.Kwaliteit = kwaliteit;
            this.is3D = id3D;
            this.Lengte = lengte;

        }
        public Film( string filmNaam, int rating, string kijkwijzer, string genre, string kwaliteit, bool id3D, string lengte)
        {
            
            this.FilmNaam = filmNaam;
            this.Rating = rating;
            this.Kijkwijzer = kijkwijzer;
            this.Genre = genre;
            this.Kwaliteit = kwaliteit;
            this.is3D = id3D;
            this.Lengte = lengte;

        }

        public override string ToString()
        {
            return null;
        }

        public static List<Film> GetFilms()
        {
            DatabaseHandler db = new DatabaseHandler();
            return   db.GetFilms();
        }

        public static Film GetFilm(int filmid)
        {

            DatabaseHandler db = new DatabaseHandler();
            return db.GetFilm(filmid);
        }

        public static void AddFilm(Film film)
        {
            DatabaseHandler db = new DatabaseHandler();
             db.AddFilm(film);
        }
    }
}