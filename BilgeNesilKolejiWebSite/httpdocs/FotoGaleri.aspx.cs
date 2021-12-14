using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FotoGaleri : BasePage
{
    List<cGallery> GalleryList;
    List<cGallery> GalleryItem;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GalleryList = cGallery.GetGalleryByType(1);
            rptPhotoGallery.DataSource = GalleryList;
            rptPhotoGallery.DataBind();
        }

    }

    public static string ClearHtml(string text)
    {
        return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
    }

    protected void rptPhotoGallery_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            Literal ltrHeader = (Literal)e.Item.FindControl("ltrHeader");

            //ltrHeader.Text = GalleryList[e.Item.ItemIndex].Header;
        }
    }
}