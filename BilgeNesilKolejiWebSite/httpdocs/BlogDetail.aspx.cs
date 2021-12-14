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
            Page.Title = BlogPostItem[0].HeaderEn + " | BİLGE NESİL KOLEJİ";
            ltrBreadHeader.Text = BlogPostItem[0].Header;
            imgUrl.ImageUrl = BlogPostItem[0].ImageUrl;
            ltrHeader.Text = BlogPostItem[0].Header;
            //ltrHeader2.Text = ActivityItem[0].Header;






            //BlogPostList = cBlogPost.GetBlogPostByActiveAndLastThree();
            //rptLastBlogDetail.DataSource = BlogPostList;
            //rptLastBlogDetail.DataBind();

            //BlogPostItem = cBlogPost.GetBlogPostById(int.Parse(RouteData.Values["Id"].ToString()));
            ////imgUrl.ImageUrl = BlogPostItem[0].ImageUrl;
            ////ltrNameSurname.Text = BlogPostItem[0].NameSurname;
            ////ltrDate.Text = BlogPostItem[0].ReleaseDate.ToString("dd MMM yyyy");

            ////ltrHeader.Text = BlogPostItem[0].HeaderEn;
            ////ltrArticle.Text = BlogPostItem[0].ArticleEn;

            Page.Title = BlogPostItem[0].HeaderEn + " | BİLGE NESİL KOLEJİ";

        }
    }
}