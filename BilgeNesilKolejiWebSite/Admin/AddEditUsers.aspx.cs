using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEditUsers : BasePage
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
            ltrBranchName.Text = companyName;

            if (RouteData.Values["Id"] == null)
            {
                Page.Title = "YÖNETİCİ EKLE | Alku Admin v3.0";
                ltrHeader.Text = "Yönetici Ekle";
            }
            else
            {
                Page.Title = "YÖNETİCİ GÜNCELLE | Alku Admin v3.0";
                ltrHeader.Text = "Yönetici Güncelle";

                AdminUserItem = cAdminUser.GetAdminUsersById(int.Parse(RouteData.Values["Id"].ToString()));
                txtNameSurname.Text = AdminUserItem[0].NameSurname;
                txtUserName.Text = AdminUserItem[0].UserName;
                txtUserName.Enabled = false;
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtNameSurname.Text) && !string.IsNullOrEmpty(txtUserName.Text))
        {
            if (RouteData.Values["Id"] == null)
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (txtPassword.Text == txtPasswordReply.Text)
                    {
                        cAdminUser.InsertAdminUser(txtNameSurname.Text, txtUserName.Text, MD5Olustur(txtPassword.Text));
                        Response.Redirect("Kullanıcılar");
                    }
                    else
                    {
                        ltrHeaderText.Text = "HATA!";
                        ltrErrorText.Text = "Girdiğiniz parolalar birbiriyle uyuşmuyor. Lütfen girdiğiniz parolaları kontrol edip tekrar deneyiniz!";
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
            else
            {
                int errCode = 0;
                string password = AdminUserItem[0].Password;
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    if (txtPassword.Text == txtPasswordReply.Text)
                    {
                        password = MD5Olustur(txtPassword.Text);
                    }
                    else errCode = 1;
                }

                if (errCode == 0)
                {
                    cAdminUser.UpdateAdminUser(int.Parse(RouteData.Values["Id"].ToString()), txtNameSurname.Text, txtUserName.Text, password);
                    Response.Redirect("Kullanıcılar");
                }
                else
                {
                    ltrHeaderText.Text = "HATA!";
                    ltrErrorText.Text = "Girdiğiniz parolalar birbiriyle uyuşmuyor. Lütfen girdiğiniz parolaları kontrol edip tekrar deneyiniz!";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
                }
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