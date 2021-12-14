using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_LogOut : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CurrentUsers = null;
        Session["Id"] = null;
        Session["NameSurname"] = null;
        Session["UserName"] = null;
        Response.Redirect("UyeGirisi");
    }
}