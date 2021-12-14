using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEditContent : BasePage
{
    List<cArticle> ArticleList
    {
        get { return (List<cArticle>)ViewState["ArticleList"]; }
        set { ViewState["ArticleList"] = value; }
    }
    List<cArticlePicture> ArticlePictureList
    {
        get { return (List<cArticlePicture>)ViewState["ArticlePictureList"]; }
        set { ViewState["ArticlePictureList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            ArticleList = cArticle.GetArticleById(int.Parse(RouteData.Values["Id"].ToString()));

            Page.Title = ArticleList[0].Header + " İçerik Düzenle | Alku Admin v3.0";
            txtHeader.Text = ArticleList[0].Header;
            //txtHeaderEn.Text = ArticleList[0].HeaderEn;
            txtDescription.Text = ArticleList[0].Content;
            //txtDescriptionEn.Text = ArticleList[0].ContentEn;

            ltrHeader.Text = ArticleList[0].Header + " Düzenle";

            imagePanelControl();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtHeader.Text) && !string.IsNullOrEmpty(txtDescription.Text))
        {
            string fileName;
            string filePath = ArticleList[0].ImageUrl;

            if (fuPicture.HasFile == true)
            {
                fileName = DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss-") + fuPicture.FileName;
                filePath = "~/assets/UploadFiles/Slider/" + fileName;
                fuPicture.SaveAs(Server.MapPath(filePath));
            }

            string newFilePath = !string.IsNullOrEmpty(filePath) ? filePath : "-";

            cArticle.UpdateArticle(int.Parse(RouteData.Values["Id"].ToString()), newFilePath, txtHeader.Text, "", txtDescription.Text,"", CurrentUsers.Id);

            Response.Redirect("İçerikler");
        }
        else
        {
            ltrHeaderText.Text = "Eksik Bilgi!";
            ltrErrorText.Text = "Lütfen kullanıcı adı ve parolanızı girip tekrar deneyiniz.";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
        }
    }

    protected void btnAddPicture_Click(object sender, EventArgs e)
    {
        if (fuFile.HasFile == true)
        {
            try
            {
                string fileName = DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss_") + fuFile.FileName;
                string filePath = "~/assets/UploadFiles/Content/" + fileName;

                fuFile.SaveAs(Server.MapPath(filePath));

                cArticlePicture.InsertArticlePicture(int.Parse(RouteData.Values["Id"].ToString()), filePath, CurrentUsers.Id);

                imagePanelControl();
            }
            catch (Exception ex)
            {
                ltrHeaderText.Text = "HATA!";
                ltrErrorText.Text = "Görsel Kaydedilemedi. Hata kodu: " + ex.ToString();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
            }
        }
    }

    protected void rptPhotoGallery_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "DeleteItem":
                try
                {
                    cArticlePicture.DeleteArticlePicture(int.Parse(e.CommandArgument.ToString()));
                    File.Delete(Server.MapPath(ArticlePictureList[e.Item.ItemIndex].ImageUrl));
                    
                    imagePanelControl();
                }
                catch (Exception ex)
                {
                    ltrHeaderText.Text = "HATA!";
                    ltrErrorText.Text = "Görsel Kaydedilemedi. Hata kodu: " + ex.ToString();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
                }
                break;
        }
    }

    private void imagePanelControl()
    {
        ArticlePictureList = cArticlePicture.GetArticlePictureByArticleId(int.Parse(RouteData.Values["Id"].ToString()));
        rptPhotoGallery.DataSource = ArticlePictureList;
        rptPhotoGallery.DataBind();

        if (ArticlePictureList.Count > 0)
        {
            pnlPicture.Visible = true;
        }
        else
            pnlPicture.Visible = false;
    }
}