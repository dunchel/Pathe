using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pathe.Classes;
using Pathe.Database;

namespace Pathe.Pages
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_Register_Click(object sender, EventArgs e)
        {
            string voornaam = TB_Voornaam.Text;
            string achternaam = TB_Achternaam.Text;
            string wachtwoord = TB_Wachtwoord.Text;
            string abbonement = TB_Abbonement.Text;
            string plaats = TB_Plaats.Text;
            string postcode = TB_Postcode.Text;
            string telefoonnummer = TB_Telefoonnummer.Text;
            string geslacht = TB_Geslacht.Text;
            string email = TB_Email.Text;
            string huisnummer = TB_Huisnummer.Text;
            string straat = TB_Straat.Text;
            
            Users user = new Users(voornaam,achternaam,wachtwoord,geslacht,straat,huisnummer,postcode,plaats,telefoonnummer,email,abbonement);
            DatabaseHandler d = new DatabaseHandler();
            d.AddUser(user);
        }
    }
}