using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AddEditProduct : BasePage
{
    List<cProducts> ProductsItem
    {
        get { return (List<cProducts>)ViewState["ProductsItem"]; }
        set { ViewState["ProductsItem"] = value; }
    }
    List<cProductPicture> ProductPictureList
    {
        get { return (List<cProductPicture>)ViewState["ProductPictureList"]; }
        set { ViewState["ProductPictureList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;


            if (RouteData.Values["Id"] != null)
            {
                ProductsItem = cProducts.GetProductsById(int.Parse(RouteData.Values["Id"].ToString()));

                Page.Title = ProductsItem[0].ProductName + " Ürün Düzenle | Alku Admin v3.0";

                txtHeader.Text = ProductsItem[0].ProductName;
                //txtHeaderEn.Text = ProductsItem[0].ProductNameEn;
                txtDescription.Text = ProductsItem[0].Description;
                // txtDescriptionEn.Text = ProductsItem[0].DescriptionEn;

                ltrHeader.Text = ProductsItem[0].ProductName + " Güncelle";

                btnSave.Text = "Güncelle";

                pnlUploadPicture.Visible = true;
                imagePanelControl();
            }
            else
            {
                Page.Title = " Ürün Kaydet | Alku Admin v3.0";

                pnlUploadPicture.Visible = false;
                pnlPicture.Visible = false;
                ltrHeader.Text = "Yeni Ürün Kaydet";

                btnSave.Text = "Kaydet";
            }
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtDescription.Text) && !string.IsNullOrEmpty(txtHeader.Text))
        {
            string fileName = "";
            string filePath = "";
            if (RouteData.Values["Id"] != null)
            {
                if (fuPicture.HasFile == true)
                {
                    fileName += DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss_") + fuPicture.FileName;
                    filePath += "~/UploadFiles/Products/" + fileName;

                    fuPicture.SaveAs(Server.MapPath(filePath));
                }

                string newFilePath = !string.IsNullOrEmpty(filePath) ? filePath : ProductsItem[0].ImageUrl;

                cProducts.UpdateProducts(int.Parse(RouteData.Values["Id"].ToString()), newFilePath, txtHeader.Text, "", txtDescription.Text,"", CurrentUsers.Id);

                Response.Redirect("Ürünler");
            }
            else
            {
                if (fuPicture.HasFile == true)
                {
                    fileName += DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss_") + fuPicture.FileName;
                    filePath += "~/UploadFiles/Products/" + fileName;

                    fuPicture.SaveAs(Server.MapPath(filePath));
                }

                string newFilePath = !string.IsNullOrEmpty(filePath) ? filePath : "-";

                cProducts.InsertProducts(newFilePath, txtHeader.Text, "", txtDescription.Text,"", CurrentUsers.Id);

                Response.Redirect("Ürünler");
            }
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
                string filePath = "~/assets/UploadFiles/Products/" + fileName;

                fuFile.SaveAs(Server.MapPath(filePath));

                cProductPicture.InsertProductPicture(int.Parse(RouteData.Values["Id"].ToString()), filePath, CurrentUsers.Id);

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
                    cProductPicture.DeleteProductPicture(int.Parse(e.CommandArgument.ToString()));
                    File.Delete(Server.MapPath(ProductPictureList[e.Item.ItemIndex].ImageUrl));

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
        ProductPictureList = cProductPicture.GetProductPictureByProductId(int.Parse(RouteData.Values["Id"].ToString()));
        rptPhotoGallery.DataSource = ProductPictureList;
        rptPhotoGallery.DataBind();

        if (ProductPictureList.Count > 0)
        {
            pnlPicture.Visible = true;
        }
        else
            pnlPicture.Visible = false;
    }
}