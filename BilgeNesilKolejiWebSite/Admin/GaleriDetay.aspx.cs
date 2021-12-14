using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_GaleriDetay : BasePage
{

    List<cGalleryDetail> GalleryDetailList
    {
        get { return (List<cGalleryDetail>)ViewState["GalleryDetailList"]; }
        set { ViewState["GalleryDetailList"] = value; }
    }
    List<cGalleryDetail> GalleryDetailItem
    {
        get { return (List<cGalleryDetail>)ViewState["GalleryDetailItem"]; }
        set { ViewState["GalleryDetailItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            GalleryDetailList = cGalleryDetail.GetGalleryDetailByGalleryId(int.Parse(RouteData.Values["GalleryId"].ToString()));
            //rptGallery.DataSource = GalleryDetailList;
            //rptGallery.DataBind();

            if (GalleryDetailList.Count > 0)
            {
                rptPhotoGallery.DataSource = GalleryDetailList;
                rptPhotoGallery.DataBind();
                ltrNoData.Visible = false;
            }
            else
            {
                ltrNoData.Visible = true;
                ltrNoData.Text = "&nbsp;&nbsp;&nbsp;Kayıt Bulunamadı.";
            }

            //if (RouteData.Values["Id"] != null) //Güncelle
            //{
            //    GalleryDetailItem = cGalleryDetail.GetGalleryDetailByGalleryId(int.Parse(RouteData.Values["Id"].ToString()));

            //    btnSave.Text = "Güncelle";
            //}
            //else //Kaydet
            //{
            btnSave.Text = "Kaydet";
            //}
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (fuFile.HasFile == true)
        {
            try
            {
                string fileName = DateTime.Now.ToString("ddMMyyyy-HHmmss") + "_" + fuFile.FileName;
                string filePath = "~/UploadedFiles/PhotoGallery/" + fileName;
                fuFile.SaveAs(Server.MapPath(filePath));

                DateTime StartDate = DateTime.Parse("2016-01-01 00:00:00");
                DateTime EndDate = DateTime.Parse("2099-01-01 00:00:00");

                if (RouteData.Values["Id"] != null) //Güncelle
                {
                    cGalleryDetail.UpdateGalleryDetail(int.Parse(RouteData.Values["Id"].ToString()), 1, filePath, CurrentUsers.Id);

                    Response.Redirect("GaleriDetay-" + RouteData.Values["Id"].ToString());
                }
                else //Kaydet
                {
                    DataTable dt = new DataTable();
                    cGalleryDetail.InsertGalleryDetail(int.Parse(RouteData.Values["GalleryId"].ToString()), filePath, CurrentUsers.Id);
                    //InsertGalleryDetail(int pGalleryId, string ImgUrl, int pInsertBy)

                    Response.Redirect("GaleriDetay-" + RouteData.Values["GalleryId"].ToString());
                }
            }
            catch (Exception ex)
            {
                ltrErrorText.Text = "Güncellenemedi!";
                ltrHeaderText.Text = "Hata kodu: " + ex.ToString();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
            }
        }
        else
        {
            ltrErrorText.Text = "Eksik Bilgi!";
            ltrHeaderText.Text = "Lütfen tüm *'lı alanları doldurduğunuzdan emin olup tekrar deneyiniz.";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
        }
    }

    protected void rptPhotoGallery_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "Delete":
                try
                {
                    cGalleryDetail.DeleteGalleryDetail(int.Parse(e.CommandArgument.ToString()));

                    File.Delete(Server.MapPath(GalleryDetailList[e.Item.ItemIndex].ImgUrl));

                    Response.Redirect("GaleriDetay-" + RouteData.Values["GalleryId"].ToString());
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