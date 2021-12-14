using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Default : BasePage
{
    List<cBlogPost> BlogPostList
    {
        get { return (List<cBlogPost>)ViewState["BlogPostList"]; }
        set { ViewState["BlogPostList"] = value; }
    }
    List<cProducts> ProductsList
    {
        get { return (List<cProducts>)ViewState["ProductsList"]; }
        set { ViewState["ProductsList"] = value; }
    }
    List<cContactForm> ContactFormList
    {
        get { return (List<cContactForm>)ViewState["ContactFormList"]; }
        set { ViewState["ContactFormList"] = value; }
    }
    List<cReports> ReportsItem
    {
        get { return (List<cReports>)ViewState["ReportsItem"]; }
        set { ViewState["ReportsItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Page.Title = "ANASAYFA | Alku Admin v3.0";

            ltrBranchName.Text = companyName;

            ReportsItem = cReports.GetReportsByAdminDefault();
            ltrBlogText.Text = ReportsItem[0].BlogCount.ToString();
            ltrReferences.Text = ReportsItem[0].ReferencesCount.ToString();
            ltrProducts.Text = ReportsItem[0].ProductCount.ToString();
            ltrMessages.Text = ReportsItem[0].MessagesCount.ToString();

            BlogPostList = cBlogPost.GetBlogPostByAll();
            rptBlogPost.DataSource = BlogPostList;
            rptBlogPost.DataBind();

            //ProductsList = cProducts.GetProductsByAll();
            //rptProducts.DataSource = ProductsList;
            //rptProducts.DataBind();

            ContactFormList = cContactForm.GetContactFormByStatus(1);
            rptContents.DataSource = ContactFormList;
            rptContents.DataBind();
        }
    }
}