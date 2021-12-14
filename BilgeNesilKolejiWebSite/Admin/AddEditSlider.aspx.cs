using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEditSlider : BasePage
{
    List<cSliders> SlidersItem
    {
        get { return (List<cSliders>)ViewState["SlidersItem"]; }
        set { ViewState["SlidersItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            if (RouteData.Values["Id"] != null)
            {
                ltrHeader.Text = "Slider Güncelle";
                btnSave.Text = "Güncelle";

                SlidersItem = cSliders.GetSlidersById(int.Parse(RouteData.Values["Id"].ToString()));

                Page.Title = SlidersItem[0].Header + " Slider Düzenle | Alku Admin v3.0";

                txtLink.Text = SlidersItem[0].Link;
                txtHeader.Text = SlidersItem[0].Header;
               // txtHeaderEn.Text = SlidersItem[0].HeaderEn;
                txtDescription.Text = SlidersItem[0].Description;
               // txtDescriptionEn.Text = SlidersItem[0].DescriptionEn;
            }
            else
            {
                Page.Title = "Slider Ekle | Alku Admin v3.0";

                ltrHeader.Text = "Slider Ekle";
                btnSave.Text = "Kaydet";
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtHeader.Text) && !string.IsNullOrEmpty(txtDescription.Text))
        {
            string fileName;
            string filePath;
            if (RouteData.Values["Id"] != null) //Güncelle
            {
                try
                {
                    filePath = SlidersItem[0].ImageUrl;

                    if (fuPicture.HasFile == true)
                    {
                        fileName = DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss-") + fuPicture.FileName;
                        filePath = "~/assets/UploadFiles/Slider/" + fileName;
                        fuPicture.SaveAs(Server.MapPath(filePath));
                    }

                    cSliders.UpdateSliderById(int.Parse(RouteData.Values["Id"].ToString()), filePath, txtHeader.Text, "", txtDescription.Text, "", txtLink.Text, CurrentUsers.Id);

                    Response.Redirect("Slider");
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
                        filePath = "~/assets/UploadFiles/Slider/" + fileName;
                        fuPicture.SaveAs(Server.MapPath(filePath));

                        cSliders.InsertSlider(filePath, txtHeader.Text, "", txtDescription.Text, "", txtLink.Text, CurrentUsers.Id);

                        Response.Redirect("Slider", true);
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