using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEditSGallery : BasePage
{
    List<cGallery> GalleryItem
    {
        get { return (List<cGallery>)ViewState["GalleryItem"]; }
        set { ViewState["GalleryItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            if (RouteData.Values["Id"] != null)
            {
                ltrHeader.Text = "Video Güncelle";
                btnSave.Text = "Güncelle";

                GalleryItem = cGallery.GetGalleryById(int.Parse(RouteData.Values["Id"].ToString()));

                Page.Title = GalleryItem[0].Header + " Fotoğraf Düzenle | Alku Admin v3.0";

                txtLink.Text = GalleryItem[0].Url;
                txtHeader.Text = GalleryItem[0].Header;
                //txtHeaderEn.Text = GalleryItem[0].HeaderEn;
                txtDescription.Text = GalleryItem[0].Description;
                //txtDescriptionEn.Text = GalleryItem[0].DescriptionEn;
            }
            else
            {
                Page.Title = "Fotoğraf Ekle | Alku Admin v3.0";

                ltrHeader.Text = "Fotoğraf Ekle";
                btnSave.Text = "Kaydet";
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtHeader.Text) &&  !string.IsNullOrEmpty(txtDescription.Text))
        {
            string fileName;
            string filePath;
            if (RouteData.Values["Id"] != null) //Güncelle
            {
                try
                {
                    filePath = GalleryItem[0].Url;

                    if (fuPicture.HasFile == true)
                    {
                        fileName = DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss-") + fuPicture.FileName;
                        filePath = "~/assets/UploadFiles/Slider/" + fileName;
                        fuPicture.SaveAs(Server.MapPath(filePath));
                    }

                    cGallery.UpdateGallery(int.Parse(RouteData.Values["Id"].ToString()), 1,filePath, txtHeader.Text, "", txtDescription.Text, "",  CurrentUsers.Id);

                    Response.Redirect("Fotoğraflar");
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
                if (fuPicture.HasFile == true)
                {
                    try
                    {
                        fileName = DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss-") + fuPicture.FileName;
                        filePath = "~/assets/UploadFiles/PhotoGallery/" + fileName;
                        fuPicture.SaveAs(Server.MapPath(filePath));

                        cGallery.InsertGallery(1, filePath, txtHeader.Text, "", txtDescription.Text,"", CurrentUsers.Id);
                        Response.Redirect("Fotoğraflar", true);
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
        }
        else
        {
            ltrHeaderText.Text = "Eksik Bilgi!";
            ltrErrorText.Text = "Lütfen kullanıcı adı ve parolanızı girip tekrar deneyiniz.";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
        }
    }
}