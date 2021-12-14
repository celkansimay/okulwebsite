using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hakkimizda : System.Web.UI.Page
{
    List<cArticle> ArticleItem;
    protected void Page_Load(object sender, EventArgs e)
    {
        ArticleItem = cArticle.GetArticleById(9);

        ltrHeader.Text = ArticleItem[0].Header;
        ltrcContent1.Text = ArticleItem[0].Content;
        Image.ImageUrl = ArticleItem[0].ImageUrl;
    }
}