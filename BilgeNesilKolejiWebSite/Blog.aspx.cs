using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Blog : BasePage
{
    List<cBlogPost> BlogPostList
    {
        get { return (List<cBlogPost>)ViewState["BlogPostList"]; }
        set { ViewState["BlogPostList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BlogPostList = cBlogPost.GetBlogPostByActive();
            rptBlog.DataSource = BlogPostList;
            rptBlog.DataBind();
        }
    }
    public static string ClearHtml(string text)
    {
        return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
    }

    protected void rptBlog_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            Literal ltrArticle = (Literal)e.Item.FindControl("ltrArticle");

            ltrArticle.Text = BlogPostList[e.Item.ItemIndex].Article.Length > 250 ? BlogPostList[e.Item.ItemIndex].Article.Substring(0, 250) + "..." : BlogPostList[e.Item.ItemIndex].Article;
        }
    }
}