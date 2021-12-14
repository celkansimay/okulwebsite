using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEditNews : BasePage
{
    List<cNews> NewsItem
    {
        get { return (List<cNews>)ViewState["NewsItem"]; }
        set { ViewState["NewsItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            if (RouteData.Values["Id"] != null)
            {
                btnSave.Text = "Güncelle";

                NewsItem = cNews.GetNewsById(int.Parse(RouteData.Values["Id"].ToString()));

                Page.Title = NewsItem[0].Header + " Haber Düzenle | Alku Admin v3.0";
                ltrHeader.Text = NewsItem[0].Header + " Düzenle";

                txtHeader.Text = NewsItem[0].Header;
                //txtHeaderEn.Text = ActivityItem[0].HeaderEn;
                txtReleaseDate.Text = NewsItem[0].ReleaseDate.ToString("dd/MM/yyyy");
                txtDescription.Text = NewsItem[0].Article;
                //txtDescriptionEn.Text = ActivityItem[0].ArticleEn;
            }
            else
            {
                Page.Title = "Haber Yazısı Kaydet | Alku Admin v3.0";
                ltrHeader.Text = "Haber Yazısı Kaydet";
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
                filePath = !string.IsNullOrEmpty(filePath) ? filePath : NewsItem[0].ImageUrl;

                cNews.UpdateNews(int.Parse(RouteData.Values["Id"].ToString()), txtHeader.Text, "", txtDescription.Text, "", filePath, releaseDate, CurrentUsers.Id);

                Response.Redirect("Yazılar");
            }
            else
            {
                filePath = !string.IsNullOrEmpty(filePath) ? filePath : "-";

                cNews.InsertNews(txtHeader.Text, "", txtDescription.Text, "", filePath, releaseDate, CurrentUsers.Id);

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