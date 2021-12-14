using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FenLisesi : System.Web.UI.Page
{
    List<cArticle> ArticleItem;
    protected void Page_Load(object sender, EventArgs e)
    {
        ArticleItem = cArticle.GetArticleById(7);

        ltrHeader.Text = ArticleItem[0].Header;
        ltrHeader1.Text = ArticleItem[0].Header;
        ltrBreadHeader1.Text = ArticleItem[0].Header;
        ltrContent1.Text = ArticleItem[0].Content;
        ImageFen.ImageUrl = ArticleItem[0].ImageUrl;
    }
}