using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HaberDetay : BasePage
{
    protected List<cNews> NewsItem;
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            NewsItem = cNews.GetNewsById(int.Parse(RouteData.Values["Id"].ToString()));
            Page.Title = NewsItem[0].HeaderEn + " | BİLGE NESİL KOLEJİ";
            ltrBreadHeader.Text = NewsItem[0].Header;
            imgUrl.ImageUrl = NewsItem[0].ImageUrl;
            ltrHeader.Text = NewsItem[0].Header;
          

        }
    }
}