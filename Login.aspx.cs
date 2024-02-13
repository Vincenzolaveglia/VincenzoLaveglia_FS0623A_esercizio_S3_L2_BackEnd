using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercizio_L2_S3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("LOGIN");
            cookie.Values["username"] = TextBox1.Text;
            cookie.Expires = DateTime.Now.AddYears(4);
            Response.Cookies.Add(cookie);
            Response.Redirect("Home.aspx");
        }
    }
}