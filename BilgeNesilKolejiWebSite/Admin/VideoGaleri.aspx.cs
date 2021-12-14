using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_VideoGaleri : BasePage
{
    List<cGallery> GalleryItem
    {
        get { return (List<cGallery>)ViewState["GalleryItem"]; }
        set { ViewState["GalleryItem"] = value; }
    }

    List<cGallery> GalleryList
    {
        get { return (List<cGallery>)ViewState["GalleryList"]; }
        set { ViewState["GalleryList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            ltrBranchName.Text = companyName;

            GalleryList = cGallery.GetGalleryByType(2);
            rptVideo.DataSource = GalleryList;
            rptVideo.DataBind();



            ltrBranchName.Text = companyName;

            if (RouteData.Values["Id"] != null)
            {
                ltrHeader.Text = "Fotoğraf Güncelle";
                btnSave.Text = "Güncelle";

                GalleryItem = cGallery.GetGalleryById(2);

                //Page.Title = GalleryItem[0].Header + " Video Düzenle | Alku Admin v3.0";

                txtLink.Text = GalleryItem[0].Url;
                //txtHeader.Text = GalleryItem[0].Header;
                //txtHeaderEn.Text = GalleryItem[0].HeaderEn;
                // txtDescription.Text = GalleryItem[0].Description;
                //txtDescriptionEn.Text = GalleryItem[0].DescriptionEn;
            }
            else
            {
                Page.Title = "Video Ekle | Alku Admin v3.0";

                ltrHeader.Text = "Video Ekle";
                btnSave.Text = "Kaydet";
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtLink.Text))
        {
            //string filePath;

            try
            {
                cGallery.InsertGallery(2, txtLink.Text, "", "", "", "", CurrentUsers.Id);
                // filePath = GalleryItem[0].Url;
            }

            catch (Exception ex)
            {
                ltrHeaderText.Text = "Yanlış Bilgi!";
                ltrErrorText.Text = "Hata kodu: " + ex.ToString();
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


    protected void rptVideoGallery_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "DeleteRow":
                try
                {
                    cGallery.DeleteGallery(int.Parse(e.CommandArgument.ToString()));

                    File.Delete(Server.MapPath(GalleryList[e.Item.ItemIndex].Url));

                    Response.Redirect("VideoGaleri-");
                }
                catch (Exception ex)
                {
                    ltrErrorText.Text = "Kayıt Silinemedi!";
                    ltrHeaderText.Text = "Hata kodu: " + ex.ToString();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
                }
                break;
        }
    }
}
