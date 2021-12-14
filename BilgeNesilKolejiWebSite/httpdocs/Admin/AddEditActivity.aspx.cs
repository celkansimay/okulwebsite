using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEditActivity : BasePage
{
    List<cActivity> ActivityItem
    {
        get { return (List<cActivity>)ViewState["ActivityItem"]; }
        set { ViewState["ActivityItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            if (RouteData.Values["Id"] != null)
            {
                btnSave.Text = "Güncelle";

                ActivityItem = cActivity.GetActivityById(int.Parse(RouteData.Values["Id"].ToString()));

                Page.Title = ActivityItem[0].Header + " Etkinlik Düzenle | Alku Admin v3.0";
                ltrHeader.Text = ActivityItem[0].Header + " Düzenle";

                txtHeader.Text = ActivityItem[0].Header;
                //txtHeaderEn.Text = ActivityItem[0].HeaderEn;
                txtReleaseDate.Text = ActivityItem[0].ReleaseDate.ToString("dd/MM/yyyy");
                txtDescription.Text = ActivityItem[0].Article;
                //txtDescriptionEn.Text = ActivityItem[0].ArticleEn;
            }
            else
            {
                Page.Title = "Etkinlik Yazısı Kaydet | Alku Admin v3.0";
                ltrHeader.Text = "Etkinlik Yazısı Kaydet";
                btnSave.Text = "Kaydet";
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtHeader.Text)/* && !string.IsNullOrEmpty(txtHeaderEn.Text)*/ && !string.IsNullOrEmpty(txtDescription.Text) /*&& !string.IsNullOrEmpty(txtDescriptionEn.Text)*/)
        {
            string fileName = "";
            string filePath = "";

            if (fuPicture.HasFile == true)
            {
                fileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss_") + fuPicture.FileName;
                filePath = "~/assets/UploadFiles/Blog/" + fileName;

                fuPicture.SaveAs(Server.MapPath(filePath));
            }

            DateTime releaseDate = !string.IsNullOrEmpty(txtReleaseDate.Text) ? DateTime.Parse(txtReleaseDate.Text) : DateTime.Now;
            if (RouteData.Values["Id"] != null)
            {
                filePath = !string.IsNullOrEmpty(filePath) ? filePath : ActivityItem[0].ImageUrl;

                cActivity.UpdateActivity(int.Parse(RouteData.Values["Id"].ToString()), txtHeader.Text, "", txtDescription.Text, "", filePath, releaseDate, CurrentUsers.Id);

                Response.Redirect("Yazılar");
            }
            else
            {
                filePath = !string.IsNullOrEmpty(filePath) ? filePath : "-";

                cActivity.InsertActivity(txtHeader.Text, "", txtDescription.Text, "", filePath, releaseDate, CurrentUsers.Id);

                Response.Redirect("Yazılar");
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