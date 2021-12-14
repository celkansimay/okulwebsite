using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Galeri : BasePage
{

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

            Page.Title = "FOTOĞRAF GALERİSİ| Alku Admin v3.0";

            GalleryList = cGallery.GetGalleryByType(1);
            rptGallery.DataSource = GalleryList;
            rptGallery.DataBind();
        }
    }
}