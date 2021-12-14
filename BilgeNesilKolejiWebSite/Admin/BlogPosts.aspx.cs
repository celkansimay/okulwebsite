using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_BlogPosts : BasePage
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
            ltrBranchName.Text = companyName;

            BlogPostList = cBlogPost.GetBlogPostByAll();
            rptBlogPost.DataSource = BlogPostList;
            rptBlogPost.DataBind();

            Page.Title = "BLOG YAZILARI | Alku Admin v3.0";
        }
    }
}