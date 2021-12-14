using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ortaokul : System.Web.UI.Page
{
    List<cArticle> ArticleItem;
    protected void Page_Load(object sender, EventArgs e)
    {
        ArticleItem = cArticle.GetArticleById(6);

        ltrHeader.Text = ArticleItem[0].Header;
        ltrHeader1.Text = ArticleItem[0].Header;
        ltrBreadHeader1.Text = ArticleItem[0].Header;
        ltrContent1.Text = ArticleItem[0].Content;
        ImageOrta.ImageUrl = ArticleItem[0].ImageUrl;
    }
}