using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : BasePage
{
    List<cSliders> SlidersList;
    List<cArticle> ArticleItem1;
    List<cArticle> ArticleItem2;
    List<cArticle> ArticleItem3;
    List<cBlogPost> BlogPostList;
    List<cNews> NewsList;
    List<cActivity> ActivityList;
    protected void Page_Load(object sender, EventArgs e)
    {
        SlidersList = cSliders.GetSlidersByAll();

        string sliderText = "";

        foreach (var item in SlidersList)
        {
            sliderText += "<div class=\"item owl-bg-img\" style=\"background-image: url('" + item.ImageUrl.ToString().Substring(1) + "');\">";
            sliderText += "<div class=\"opacity-full bg-dark-gray\"></div>";
            sliderText += "<div class=\"container full-screen position-relative\">";
            sliderText += "<div class=\"slider-typography text-center\">";
            sliderText += "<div class=\"slider-text-middle-main\">";
            sliderText += "<div class=\"slider-text-middle slider-text-middle6 padding-left-right-px wow fadeInUp\">";
            sliderText += "<span class=\"slider-title-big5 white-text text-uppercase font-weight-600 letter-spacing-1\">";
            sliderText += item.Header + "</span>";
            sliderText += "<span class=\"white-text text-med  letter-spacing-3 margin-three no-margin-bottom display-block xs-letter-spacing-6\">";
            sliderText += item.Description + "</span>";

            sliderText += "<div class=\"col - lg - 12 text - center\">";
            sliderText += "<a href=\"/FotoGaleri\" class=\"btn highlight-button-white-border margin-four no-margin-bottom no-margin-lr btn-small\">";
            sliderText += "Keşfet </a>";
            sliderText += "</div>";
            sliderText += "</div>";
            sliderText += "</div>";
            sliderText += "</div>";
            sliderText += "</div>";
            sliderText += "</div>";


            //sliderText += "<div class=\"col - lg - 12 text - center\">";
            //sliderText += "<a href=\"/Haberler\" class=\"btn highlight-button-black-border margin-four no-margin-bottom no-margin-lr btn-small\">";
            //sliderText += "Fotoğraf Galerisini Görüntüle + </a>";
            //sliderText += "</div>";
        }

        ltrSlider.Text = sliderText;

        ArticleItem1 = cArticle.GetArticleById(1);
        ArticleItem2 = cArticle.GetArticleById(2);
        ArticleItem3 = cArticle.GetArticleById(3);

        ltrHeader.Text = ArticleItem1[0].Header;
        ltrHeader2.Text = ArticleItem2[0].Header;
        ltrHeader3.Text = ArticleItem3[0].Header;
        ltrContent1.Text = ArticleItem1[0].Content;
        ltrContent2.Text = ArticleItem2[0].Content;
        ltrContent3.Text = ArticleItem3[0].Content;

        BlogPostList = cBlogPost.GetBlogPostByActive();
        rptBlog.DataSource = BlogPostList;
        rptBlog.DataBind();

        NewsList = cNews.GetNewsByActiveAndLastThree();
        rptNews.DataSource = NewsList;
        rptNews.DataBind();

        ActivityList = cActivity.GetActivityByActiveAndLastThree();
        rptActivity.DataSource = ActivityList;
        rptActivity.DataBind();
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