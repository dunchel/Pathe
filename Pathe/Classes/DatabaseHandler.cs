using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace Pathe.Classes
{
    public class DatabaseHandler
    {
        public string connectionstring = "User Id=system;Password=shadow;Data Source=localhost:1521";
         public OracleConnection con;
        public  OracleCommand cmd;
         public OracleDataReader dr;

        public  void Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = connectionstring;
            con.Open();
            Console.WriteLine("Connection succesfull");
        }

        public  void Disconnect()
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
        public  Users GetUser(int userID)
        {
            Users Toadd = null;

            try
            {
                Connect();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO GEBRUIKER UserID, Voornaam, Achternaam, Geboortedatum, Geslacht, Straat, Huisnummer, Postcode, Plaats,Telefoonnummer, Email, Abbonement FROM GEBRUIKER WHERE UserID=:UserID";
                cmd.Parameters.Add("UserID", userID);
                cmd.CommandType = System.Data.CommandType.Text;
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

                    Users user = new Users(userID, voornaam, achternaam, wachtwoord, geboortedatum, geslacht, straat, huisnummer, postcode, plaats, telefoonnummer, email, abbonement);
                    
                }
            }
            catch
            {
                return null;
            }
            return Toadd;
        }

        public void  AddUser(Users newuser)
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
            catch(Exception ex)
            {
                
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
          
            
        }

        public bool DeleteUser()
        {

            return false;
        }

        public  bool Login()
        {
            return false;
        }
    }
}