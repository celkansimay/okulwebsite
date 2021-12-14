using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EtkinlikDetay : BasePage
{
   protected List<cActivity> ActivityItem;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ActivityItem = cActivity.GetActivityById(int.Parse(RouteData.Values["Id"].ToString()));
            Page.Title = ActivityItem[0].Header + " | BİLGE NESİL KOLEJİ";
            ltrBreadHeader.Text = ActivityItem[0].Header;
            imgUrl.ImageUrl = ActivityItem[0].ImageUrl;
            ltrHeader.Text = ActivityItem[0].Header;
            //ltrHeader2.Text = ActivityItem[0].Header;
        }
    }
}