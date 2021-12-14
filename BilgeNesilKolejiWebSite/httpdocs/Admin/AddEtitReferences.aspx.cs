using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEtitReferences : BasePage
{
    List<cReferences> ReferencesItem
    {
        get { return (List<cReferences>)ViewState["ReferencesItem"]; }
        set { ViewState["ReferencesItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            if (RouteData.Values["Id"] != null)
            {
                ReferencesItem = cReferences.GetReferencesById(int.Parse(RouteData.Values["Id"].ToString()));

                txtDescription.Text = ReferencesItem[0].Description;
                txtDescriptionEn.Text = ReferencesItem[0].DescriptionEn;

                Page.Title = ReferencesItem[0].CompanyName + " REFERANS GÜNCELLE | Alku Admin v3.0";

                ltrHeader.Text = "Referans Güncelle";
                btnSave.Text = "Güncelle";
            }
            else
            {
                Page.Title = "REFERANS EKLE | Alku Admin v3.0";

                ltrHeader.Text = "Referans Kaydet";
                btnSave.Text = "Kaydet";
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtDescription.Text) && !string.IsNullOrEmpty(txtDescriptionEn.Text) && !string.IsNullOrEmpty(txtCompanyName.Text))
        {
            string fileName;
            string filePath;

            if (RouteData.Values["Id"] != null)
            {
                filePath = ReferencesItem[0].LogoUrl;

                if (fuPicture.HasFile == true)
                {
                    fileName = DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss-") + fuPicture.FileName;
                    filePath = "~/assets/UploadFiles/References/" + fileName;
                    fuPicture.SaveAs(Server.MapPath(filePath));
                }

                cReferences.UpdateReferences(int.Parse(RouteData.Values["Id"].ToString()), filePath, txtCompanyName.Text, txtDescription.Text, txtDescriptionEn.Text, CurrentUsers.Id);

                Response.Redirect("Referanslar");
            }
            else
            {
                if (fuPicture.HasFile == true)
                {
                    fileName = DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss-") + fuPicture.FileName;
                    filePath = "~/assets/UploadFiles/References/" + fileName;
                    fuPicture.SaveAs(Server.MapPath(filePath));

                    cReferences.InsertReferences(filePath, txtCompanyName.Text, txtDescription.Text, txtDescriptionEn.Text, CurrentUsers.Id);

                    Response.Redirect("Referanslar");
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