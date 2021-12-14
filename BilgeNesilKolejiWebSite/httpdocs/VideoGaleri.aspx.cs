using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VideoGaleri : System.Web.UI.Page
{
    List<cGallery> GalleryList;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GalleryList = cGallery.GetGalleryByType(2);
            rptPhotoGallery.DataSource = GalleryList;
            rptPhotoGallery.DataBind();
        }

    }
}