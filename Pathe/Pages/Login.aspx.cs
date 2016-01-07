using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pathe.Classes;
using Pathe.Pages;

namespace Pathe.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
         
        }
    }
}