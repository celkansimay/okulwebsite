using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Etkinlikler : BasePage
{
    List<cActivity> ActiviyList
    {
        get { return (List<cActivity>)ViewState["ActiviyList"]; }
        set { ViewState["ActiviyList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ActiviyList = cActivity.GetActivityByActive();
            //rptActivity.DataSource = ActiviyList;
            //rptActivity.DataBind();
            string activityText = "";

            foreach (var item in ActiviyList)
            {
                string metin = ClearHtml(item.Article);
                string editMetin = metin.Length > 250 ? ClearHtml(item.Article).Substring(0, 250) : metin;

                activityText += "<div class=\"col-md-12\">";
                activityText += "    <div class=\"portfolio-short-description-bg pull-left\" style=\"background-image:url('" + item.ImageUrl.Substring(1) + "')\" >";
                //activityText += "        <a href='" + item.Link + "'>";
                //activityText += "            <img src='" + item.ImageUrl.Substring(1) + ").ToString().Substring(1) %>' class=\"img-responsive\" />";
                //activityText += "        </a>";
                activityText += "        <figure class=\"pull-right wow fadeInRight animated\" style=\"visibility: visible; animation-name: fadeInRight;\">";
                activityText += "            <figcaption>";
                activityText += "                <div class=\"separator-line bg-yellow no-margin-lr margin-ten no-margin-top\"></div>";
                activityText += "                <h3 class=\"white-text\"><a href='EtkinlikDetay/" + item.Id + "/" + createLinkText(item.Header) + "'>";
                activityText += "                    " + item.Header + "";
                activityText += "                </a></h3>";
                activityText += "                <p class=\"light-gray-text\">";
                activityText += "                    "+ editMetin + "";
                activityText += "                </p>";
                activityText += "                <a href='EtkinlikDetay/" + item.Id + "/" + createLinkText(item.Header) + "' class=\"highlight-button btn btn-very-small button xs-no-margin\">Devamını Oku</a>";
                activityText += "            </figcaption>";
                activityText += "        </figure>";
                activityText += "    </div>";
                activityText += "</div>";
            }


            ltrActivity.Text = activityText;
        }
    }

   // <a href = "#" class="highlight-button-dark btn btn-very-small button xs-no-margin">Very Small</a>
    //protected void rptActivity_ItemDataBound(object sender, RepeaterItemEventArgs e)
    //{
    //    if (e.Item.ItemType == ListViewItemType.DataItem)
    //    {
    //        Literal ltrHeader = (Literal)e.Item.FindControl("ltrHeader");
    //        Literal ltrArticle = (Literal)e.Item.FindControl("ltrArticle");

    //        ltrHeader.Text = ActiviyList[e.Item.DataItemIndex].Header;//her satıra bır e degıskenı atanıyor ve satırın ındexı alınıyor.
    //        string metin = ClearHtml(ActiviyList[e.Item.DataItemIndex].Article);
    //        ltrArticle.Text = metin.Length > 250 ? ClearHtml(ActiviyList[e.Item.DataItemIndex].Article).Substring(0, 250) : metin;

    //        Image listImage = (Image)e.Item.FindControl("listImage");
    //        listImage.Visible = ActiviyList[e.Item.DataItemIndex].ImageUrl != "-" ? true : false;
    //    }
    //}

    protected void rptActivity_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            //Literal ltrHeader = (Literal)e.Item.FindControl("ltrHeader");
            Literal ltrArticle = (Literal)e.Item.FindControl("ltrArticle");

            //ltrHeader.Text = ActiviyList[e.Item.ItemIndex].Header;//her satıra bır e degıskenı atanıyor ve satırın ındexı alınıyor.
            string metin = ClearHtml(ActiviyList[e.Item.ItemIndex].Article);
            ltrArticle.Text = metin.Length > 250 ? ClearHtml(ActiviyList[e.Item.ItemIndex].Article).Substring(0, 250) : metin;

            //Image listImage = (Image)e.Item.FindControl("listImage");
            //listImage.Visible = ActiviyList[e.Item.ItemIndex].ImageUrl != "-" ? true : false;
        }
    }
}