using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Login : BasePage
{
    List<cAdminUser> AdminUserItem
    {
        get { return (List<cAdminUser>)ViewState["AdminUserItem"]; }
        set { ViewState["AdminUserItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Page.Title = "YÖNETİCİ GİRİŞİ | Alku Admin v3.0";
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
        {
            AdminUserItem = cAdminUser.AdminUserLogin(txtUserName.Text, MD5Olustur(txtPassword.Text));

            if (AdminUserItem.Count > 0)
            {
                CurrentUsers = AdminUserItem[0];
                Session["Id"] = CurrentUsers.Id;
                Session["NameSurname"] = CurrentUsers.NameSurname;
                Session["UserName"] = CurrentUsers.UserName;
                Response.Redirect("Anasayfa");
            }
            else
            {
                ltrHeaderText.Text = "Yanlış Bilgi!";
                ltrErrorText.Text = "Lütfen kullanıcı adı ve parolanızı girip tekrar deneyiniz.";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
            }
        }
        else
        {
            ltrHeaderText.Text = "Eksik Bilgi!";
            ltrErrorText.Text = "Lütfen kullanıcı adı ve parolanızı girip tekrar deneyiniz.";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
        }
    }
}