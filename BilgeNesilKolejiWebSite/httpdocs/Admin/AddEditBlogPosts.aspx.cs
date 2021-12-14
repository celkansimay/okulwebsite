using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEditBlogPosts : BasePage
{
    List<cBlogPost> BlogPostItem
    {
        get { return (List<cBlogPost>)ViewState["BlogPostItem"]; }
        set { ViewState["BlogPostItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            if (RouteData.Values["Id"] != null)
            {
                btnSave.Text = "Güncelle";

                BlogPostItem = cBlogPost.GetBlogPostById(int.Parse(RouteData.Values["Id"].ToString()));

                Page.Title = BlogPostItem[0].Header + " Blog Düzenle | Alku Admin v3.0";
                ltrHeader.Text = BlogPostItem[0].Header + " Düzenle";

                txtHeader.Text = BlogPostItem[0].Header;
               // txtHeaderEn.Text = BlogPostItem[0].HeaderEn;
                txtReleaseDate.Text = BlogPostItem[0].ReleaseDate.ToString("dd/MM/yyyy");
                txtDescription.Text = BlogPostItem[0].Article;
               // txtDescriptionEn.Text = BlogPostItem[0].ArticleEn;
            }
            else
            {
                Page.Title = "Blog Yazısı Kaydet | Alku Admin v3.0";
                ltrHeader.Text = "Blog Yazısı Kaydet";
                btnSave.Text = "Kaydet";
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtReleaseDate.Text) && !string.IsNullOrEmpty(txtHeader.Text) && !string.IsNullOrEmpty(txtDescription.Text))
        {
            string fileName = "";
            string filePath = "";

            if (fuPicture.HasFile == true)
            {
                fileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss_") + fuPicture.FileName;
                filePath = "~/assets/UploadFiles/Blog/" + fileName;

                fuPicture.SaveAs(Server.MapPath(filePath));
            }

            if (RouteData.Values["Id"] != null)
            {
                filePath = !string.IsNullOrEmpty(filePath) ? filePath : BlogPostItem[0].ImageUrl;

                cBlogPost.UpdateBlogPost(int.Parse(RouteData.Values["Id"].ToString()), txtHeader.Text, "", txtDescription.Text, "", filePath, DateTime.Parse(txtReleaseDate.Text), CurrentUsers.Id);

                Response.Redirect("Yazılar");
            }
            else
            {
                filePath = !string.IsNullOrEmpty(filePath) ? filePath : "-";

                cBlogPost.InsertBlogPost(txtHeader.Text,"", txtDescription.Text, "", filePath, DateTime.Parse(txtReleaseDate.Text), CurrentUsers.Id);

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