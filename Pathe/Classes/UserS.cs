using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pathe.Classes
{
    public class Users
    {
        public int UserID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Wachtwoord { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Geslacht { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public string Telefoonnummer { get; set; }
        public string Email { get; set; }
        public string Abbonement { get; set; }

        public Users(int userID, string voornaam, string achternaam, string Wachtwoord, DateTime geboorteDatum, string geslacht, string straat, string huisnummer, string postcode, string plaats, string telefoonnummer, string email, string abbonement)
        {
            this.UserID = userID;
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Wachtwoord = Wachtwoord;
            this.GeboorteDatum = geboorteDatum;
            this.Geslacht = geslacht;
            this.Straat = straat;
            this.Huisnummer = huisnummer;
            this.Postcode = postcode;
            this.Plaats = plaats;
            this.Telefoonnummer = telefoonnummer;
            this.Email = email;
            this.Abbonement = abbonement;
        }

        public Users( string voornaam, string achternaam, string Wachtwoord, string geslacht, string straat, string huisnummer, string postcode, string plaats, string telefoonnummer, string email, string abbonement)
        {
            this.Voornaam = voornaam;
            this.Achternaam = achternaam;
            this.Wachtwoord = Wachtwoord;
        
            this.Geslacht = geslacht;
            this.Straat = straat;
            this.Huisnummer = huisnummer;
            this.Postcode = postcode;
            this.Plaats = plaats;
            this.Telefoonnummer = telefoonnummer;
            this.Email = email;
            this.Abbonement = abbonement;
        }

        public override string ToString()
        {
            return null;
        }
    }
}