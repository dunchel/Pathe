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
            RefreshMenu();

        }



        private void RefreshMenu()
        {
            string Truth = "true";
            string lie = "false";
            if (Session["IsLoggedIn"] == null)
            {
                Session["IsLoggedIn"] = lie;
                
            }
        }
    }

}