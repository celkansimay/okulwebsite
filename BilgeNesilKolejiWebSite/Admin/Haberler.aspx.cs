using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Haberler : BasePage
{
    List<cNews> NewsList
    {
        get { return (List<cNews>)ViewState["NewsList"]; }
        set { ViewState["NewsList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            NewsList = cNews.GetNewsByAll();
            rptNews.DataSource = NewsList;
            rptNews.DataBind();

            Page.Title = "HABER YAZILARI | Alku Admin v3.0";
        }
    }
}