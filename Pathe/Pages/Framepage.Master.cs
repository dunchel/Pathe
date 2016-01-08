using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pathe.Database;
using Pathe.Classes;
using Pathe.Cache;

namespace Pathe.Pages
{
    public partial class Framepage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshMasterPage();
        }
        

        private void RefreshMasterPage()
        {
            string xja = "true";
            string xnee = "false";
            if (this.Session["isLoggedIn"] == null)
            {
                this.Session["isLoggedIn"] = xnee;
                loginbutton.Text = "Login";
                
            } else
            {
                if ((string)this.Session["isLoggedIn"] == xja)
                { 

                loginbutton.Text = "Logout";
                } else if ((string)this.Session["isLoggedIn"] == xnee)
                {
                    loginbutton.Text = "Login";

                }
            }

        }

        protected void loginbutton_Click(object sender, EventArgs e)
        {
            string xja = "true";
            string xnee = "false";
            if (this.Session["isLoggedIn"] == null)
            {
                Response.Redirect("Login.aspx");


            }
            else
            {
                if ((string)this.Session["isLoggedIn"] == xja)
                {
                    this.Session["isLoggedIn"] = xnee;
                    Response.Redirect("Login.aspx");

                }
                else if ((string)this.Session["isLoggedIn"] == xnee)
                {
                    Response.Redirect("Login.aspx");

                }
            }
           
        }
    }
}