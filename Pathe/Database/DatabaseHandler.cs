using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle;
using System.Data;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.Data.Sql;
using System.Data.Common;
using Pathe.Classes;
using System.Diagnostics;

namespace Pathe.Database
{
    public class DatabaseHandler
    {
        public string connectionstring = "User Id=system;Password=shadow;Data Source=localhost:1521";
        public OracleConnection con;
        public OracleCommand cmd;
        public OracleDataReader dr;

        public void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = connectionstring;
            con.Open();
            Console.WriteLine("Connection succesfull");
        }

        public void Disconnect()
        {
            con.Close();
            con.Dispose();
        }
        //all save readers 
        static string SafeReadString(OracleDataReader odr, int ColIndex)
        {
            {
                if (!odr.IsDBNull(ColIndex))
                    return odr.GetString(ColIndex);
                else
                    return string.Empty;
            }
        }

        static int SafeReadInt(OracleDataReader odr, int ColIndex)
        {
            {
                if (!odr.IsDBNull(ColIndex))
                    return odr.GetInt32(ColIndex);
                else
                    return -1;
            }
        }

        static decimal SafeReadDecimal(OracleDataReader odr, int ColIndex)
        {
            {
                if (!odr.IsDBNull(ColIndex))
                    return odr.GetDecimal(ColIndex);
                else
                    return 0;
            }
        }
        public Users GetUser(string Email, string Wachtwoord)
        {
            Users Toadd = null;

            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "SELECT UserID, Voornaam, Achternaam, Geboortedatum, Geslacht, Straat, Huisnummer, Postcode, Plaats,Telefoonnummer, Email, Abbonement FROM GEBRUIKER WHERE UserID=:UserID";
                cmd.Parameters.Add("Email", Email);
                cmd.Parameters.Add("Wachtwoord", Wachtwoord);

                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Getting user failed");
                return null;
            }
            finally
            {
                Disconnect();
            }
            try
            {
                while (dr.Read())
                {
                    var id = dr.GetInt32(0);
                    var voornaam = SafeReadString(dr, 1);
                    var achternaam = SafeReadString(dr, 2);
                    var wachtwoord = SafeReadString(dr, 3);
                    var geboortedatum = dr.GetDateTime(4);
                    var geslacht = SafeReadString(dr, 5);
                    var straat = SafeReadString(dr, 7);
                    string huisnummer = SafeReadString(dr, 8);
                    var postcode = SafeReadString(dr, 9);
                    var plaats = SafeReadString(dr, 10);
                    var telefoonnummer = SafeReadString(dr, 11);
                    var email = SafeReadString(dr, 12);
                    var abbonement = SafeReadString(dr, 13);

                    Users user = new Users(id, voornaam, achternaam, wachtwoord, geboortedatum, geslacht, straat, huisnummer, postcode, plaats, telefoonnummer, email, abbonement);

                }
            }
            catch
            {
                return null;
            }
            return Toadd;
        }

        public void AddUser(Users newuser)
        {
            try
            {
                Connect();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText =
                    "INSERT INTO GEBRUIKER(VOORNAAM, ACHTERNAAM , Straat ,WACHTWOORD , GESLACHT, HUISNUMMER , POSTCODE , PLAATS , TELEFOONNUMMER, EMAIL , ABBONEMENT) VALUES(:NewVoornaam, :NewAchternaam,:NewStraat, :NewWachtwoord, :NewGeslacht, :NewHuisnummer, :NewPostcode, :NewPlaats, :NewTelefoonnumer, :NewEmail, :NewAbbonement)";

                cmd.Parameters.Add("NewVoornaam", OracleDbType.Varchar2).Value = newuser.Voornaam;
                cmd.Parameters.Add("NewAchternaam", OracleDbType.Varchar2).Value = newuser.Achternaam;
                cmd.Parameters.Add("NewStraat", OracleDbType.Varchar2).Value = newuser.Straat;
                cmd.Parameters.Add("NewWachtwoord", OracleDbType.Varchar2).Value = newuser.Wachtwoord;
                cmd.Parameters.Add("NewGeslacht", OracleDbType.Varchar2).Value = newuser.Geslacht;
                cmd.Parameters.Add("NewHuisnummer", OracleDbType.Varchar2).Value = newuser.Huisnummer;
                cmd.Parameters.Add("NewPostcode", OracleDbType.Varchar2).Value = newuser.Postcode;
                cmd.Parameters.Add("NewPlaats", OracleDbType.Varchar2).Value = newuser.Plaats;
                cmd.Parameters.Add("NewTelefoonnumer", OracleDbType.Varchar2).Value = newuser.Telefoonnummer;
                cmd.Parameters.Add("NewEmail", OracleDbType.Varchar2).Value = newuser.Email;
                cmd.Parameters.Add("NewAbbonement", OracleDbType.Varchar2).Value = newuser.Abbonement;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }


        }
        // deze methode gaat alle users uit de database opvragen.
        public List<Users> GetAllUsers()
        {

            List<Users> Userlist = new List<Users>();
            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "SELECT UserID, Voornaam, Achternaam, Geboortedatum, Geslacht, Straat, Huisnummer, Postcode, Plaats,Telefoonnummer, Email, Abbonement FROM GEBRUIKER";
                cmd.CommandType = System.Data.CommandType.Text;
                dr = cmd.ExecuteReader();
                dr.Read();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            try
            {
                while (dr.Read())
                {
                    var id = dr.GetInt32(0);
                    var voornaam = SafeReadString(dr, 1);
                    var achternaam = SafeReadString(dr, 2);
                    var wachtwoord = SafeReadString(dr, 3);
                    var geboortedatum = dr.GetDateTime(4);
                    var geslacht = SafeReadString(dr, 5);
                    var straat = SafeReadString(dr, 7);
                    string huisnummer = SafeReadString(dr, 8);
                    var postcode = SafeReadString(dr, 9);
                    var plaats = SafeReadString(dr, 10);
                    var telefoonnummer = SafeReadString(dr, 11);
                    var email = SafeReadString(dr, 12);
                    var abbonement = SafeReadString(dr, 13);

                    Users user = new Users(id, voornaam, achternaam, wachtwoord, geboortedatum, geslacht, straat, huisnummer, postcode, plaats, telefoonnummer, email, abbonement);
                    Userlist.Add(user);
                }
                Disconnect();
                return Userlist;

            }
            catch
            {
                return null;
            }

        }

        public void AddFilm(Film newFilmToAdd)
        {
            Connect();
            cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText =
               "INSERT INTO FILM (FILMNAAM, RATING, KIJKWIJZER, GENRE, KWALITEIT, DIMENSIONAAL,LENGTE) VALUES ( :NewFilmnaam,:NewRating, :NewKijkwijzer, :NewGenre, :NewKwaliteit, :NewDimensionaal, :NewLengte)";
        }

        public bool AuthenticateUser(string Email, string Pass)
        {
            try
            {
                Connect();

                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM GEBRUIKER WHERE email =:NewEmail AND Wachtwoord =:NewWachtwoord";
                cmd.Parameters.Add("NewEmail", Email);
                cmd.Parameters.Add("NewWachtwoord", Pass);
                cmd.CommandType = System.Data.CommandType.Text;
                dr = cmd.ExecuteReader();

                // ik gebruik hier de Hasrows methode. Als de waardes kloppen, dan zijn er rijen. 
                // Deze bool is dus handig om te gebruiken als je een overeenkomst wil weten of
                // er een overeenkomst is tussen de ingevulde waardes en de gebruiker.
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {

                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public List<Film> GetFilms()
        {
            try
            {
                Connect();
                List<Film> films = new List<Film>();
                this.cmd = new OracleCommand();
                this.cmd.Connection = this.con;
                this.cmd.CommandText =
                    "SELECT * FROM FILM";
                this.cmd.CommandType = System.Data.CommandType.Text;
                this.dr = this.cmd.ExecuteReader();
                while (dr.Read())
                {
                    var filmid = SafeReadInt(dr, 0);
                    var filmnaam = SafeReadString(dr, 1);
                    var rating = SafeReadInt(dr, 2);
                    var kijkwijzer = SafeReadString(dr, 3);
                    var genre = SafeReadString(dr, 4);
                    var kwaliteit = SafeReadString(dr, 5);
                    var dimensionaal = SafeReadString(dr, 6);
                    var lengte = SafeReadInt(dr, 7);
                    bool is3d;
                    if (dimensionaal == "3D")
                    {
                        is3d = true;
                    }
                    else
                    {
                        is3d = false;
                    }

                    Film filmtoadd = new Film(filmid, filmnaam, rating, kijkwijzer, genre, kwaliteit, is3d, lengte.ToString());
                    films.Add(filmtoadd);

                }
                return films;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }

        public Film GetFilm(int filmid)
        {
            Film filmtoadd = null;
            try
            {
                Connect();
                this.cmd = new OracleCommand();
                this.cmd.Connection = this.con;
                this.cmd.CommandText =
                    "SELECT * FROM FILM WHERE FILMID =:NewFilmID";
                cmd.Parameters.Add("NewFilmID", filmid);
                this.cmd.CommandType = System.Data.CommandType.Text;
                this.dr = this.cmd.ExecuteReader();
                while (dr.Read())
                {
                    var filmID = SafeReadInt(dr, 0);
                    var filmnaam = SafeReadString(dr, 1);
                    var rating = SafeReadInt(dr, 2);
                    var kijkwijzer = SafeReadString(dr, 3);
                    var genre = SafeReadString(dr, 4);
                    var kwaliteit = SafeReadString(dr, 5);
                    var dimensionaal = SafeReadString(dr, 6);
                    var lengte = SafeReadInt(dr, 7);
                    bool is3d;
                    if (dimensionaal == "3D")
                    {
                        is3d = true;
                    }
                    else
                    {
                        is3d = false;
                    }
                    filmtoadd = new Film(filmID, filmnaam, rating, kijkwijzer, genre, kwaliteit, is3d, lengte.ToString());

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return filmtoadd;

        }

        public List<Users> GetUserCache()
        {
            try
            {
                Connect();
                List<Users> requiredlist = new List<Users>();
                this.cmd = new OracleCommand();
                this.cmd.Connection = this.con;
                this.cmd.CommandText =
                    "SELECT UserID, Voornaam, Achternaam, Email FROM GEBRUIKER";

                this.cmd.CommandType = System.Data.CommandType.Text;
                this.dr = this.cmd.ExecuteReader();
                while (dr.Read())
                {

                    int useridx = Convert.ToInt32(dr["UserID"].ToString());
                    var voornaamx = SafeReadString(dr, 1);
                    var achternaamx = SafeReadString(dr, 2);
                    var emailx = SafeReadString(dr, 3);

                    Users item = new Users(useridx, voornaamx, achternaamx, emailx);
                    requiredlist.Add(item);
                }
                return requiredlist;
            }
            catch (Exception e)

            {
                System.Diagnostics.Debug.WriteLine(e.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }


        }

    }

}