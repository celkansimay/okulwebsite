using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Contents : BasePage
{
    List<cArticle> ArticleList
    {
        get { return (List<cArticle>)ViewState["ArticleList"]; }
        set { ViewState["ArticleList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            ArticleList = cArticle.GetArticleByAll();
            rptContents.DataSource = ArticleList;
            rptContents.DataBind();

            Page.Title = "İÇERİKLER | Alku Admin v3.0";
        }
    }

    public static string ClearHtml(string text)
    {
        return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
    }
}