using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BlogDetail : BasePage
{
    protected List<cBlogPost> BlogPostItem;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BlogPostItem = cBlogPost.GetBlogPostById(int.Parse(RouteData.Values["Id"].ToString()));
            Page.Title = BlogPostItem[0].Header + " | BİLGE NESİL KOLEJİ";
            ltrBreadHeader.Text = BlogPostItem[0].Header;
            imgUrl.ImageUrl = BlogPostItem[0].ImageUrl;
            ltrHeader.Text = BlogPostItem[0].Header;
        }
    }
}