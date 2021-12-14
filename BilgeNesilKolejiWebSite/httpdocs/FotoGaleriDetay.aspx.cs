using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FotoGaleriDetay : BasePage
{
    List<cGalleryDetail> GalleryDetailList;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GalleryDetailList = cGalleryDetail.GetGalleryDetailByGalleryId(int.Parse(RouteData.Values["Id"].ToString()));
            rptPhotoGallery.DataSource = GalleryDetailList;
            rptPhotoGallery.DataBind();
        }

    }
}