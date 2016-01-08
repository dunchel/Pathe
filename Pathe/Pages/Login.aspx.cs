using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pathe.Classes;
using Pathe.Pages;
using System.ComponentModel.DataAnnotations;
using Pathe;
using Pathe.Cache;
using Pathe.Database;

namespace Pathe.Pages
{
    public partial class Login : System.Web.UI.Page
    {

        private DatabaseHandler db = new DatabaseHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["email"] != null)
            {
                TB_Username.Text = Request.QueryString["Email"];
            }
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            // go to register page 

        }

        protected void Btn_Register_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            if (db.AuthenticateUser(TB_Username.Text, TB_Password.Text))
            {
                LoadUser();
                Response.Redirect("home.aspx");
            }
            else
            {
                AuthenticationFailed();
            }

        }



        private void LoadUser()
        {
            UserCache.UpdateCache();
            Users item = UserCache.ListOfUsers.Find(x => x.Email == TB_Username.Text);
            Session["isLoggedIn"] = "true";
            Session["currentUser"] = item;
            Session.Timeout = 2000;
        }

        private void AuthenticationFailed()
        {
            Welkom.Text = "Deze combinatie van email en wachtwoord is onjuist of onbekend, probeer opnieuw!";
        }
    }

}

