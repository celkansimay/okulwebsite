using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Haberler : BasePage
{
    List<cNews> NewList
    {
        get { return (List<cNews>)ViewState["NewList"]; }
        set { ViewState["NewList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            NewList = cNews.GetNewsByActive();
            rptBlog.DataSource = NewList;
            rptBlog.DataBind();
        }
    }
    public static string ClearHtml(string text)
    {
        return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
    }

    protected void rptNews_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            Literal ltrArticle = (Literal)e.Item.FindControl("ltrArticle");

            ltrArticle.Text = NewList[e.Item.ItemIndex].Article.Length > 250 ? NewList[e.Item.ItemIndex].Article.Substring(0, 250) + "..." : NewList[e.Item.ItemIndex].Article;
        }
    }
}