using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class SpNameCollection
{
    #region AdminUsers

    public static string GetAdminUsersByAll = "Get_List_AdminUsers_By_All";
    public static string GetAdminUsersById = "Get_Item_AdminUsers_By_Id";
    public static string AdminUserLogin = "Admin_UserLogin";
    public static string InsertAdminUser = "Insert_AdminUser";
    public static string UpdateAdminUser = "Update_AdminUser";
    public static string DeleteAdminUser = "Delete_AdminUser";

    #endregion

    #region Sliders

    public static string GetSlidersByAll = "Get_List_Sliders_By_All";
    public static string GetSlidersById = "Get_Item_Sliders_By_Id";
    public static string InsertSlider = "Insert_Slider";
    public static string UpdateSliderById = "Update_Slider_By_Id";
    public static string UpdateStatusSliderById = "Update_Status_Slider_By_Id";

    #endregion

    #region Menu

    public static string GetMenuByTopId = "Get_List_Menu_By_TopId";
    public static string GetMenuByAll = "Get_List_Menu_By_All";

    #endregion

    #region Products

    public static string GetProductsByAll = "Get_List_Products_By_All";
    public static string GetProductsById = "Get_Item_Products_By_Id";
    public static string InsertProducts = "Insert_Products";
    public static string UpdateProducts = "Update_Products";
    public static string UpdateStatusProducts = "Update_Status_Products";

    #endregion

    #region ProductPicture

    public static string GetProductPictureByProductId = "Get_List_ProductPicture_By_ProductId";
    public static string InsertProductPicture = "Insert_ProductPicture";
    public static string UpdateProductPicture = "Update_ProductPicture";
    public static string DeleteProductPicture = "Delete_ProductPicture";

    #endregion

    #region Article

    public static string GetArticleByAll = "Get_List_Article_By_All";
    public static string GetArticleById = "Get_Item_Article_By_Id";
    public static string InsertArticle = "Insert_Article";
    public static string UpdateArticle = "Update_Article";

    #endregion

    #region ArticlePicture

    public static string GetArticlePictureByArticleId = "Get_List_ArticlePicture_By_ArticleId";
    public static string GetArticlePictureById = "Get_Item_ArticlePicture_By_Id";
    public static string InsertArticlePicture = "Insert_ArticlePicture";
    public static string DeleteArticlePicture = "Delete_ArticlePicture";

    #endregion

    #region BlogPost

    public static string GetBlogPostByAll = "Get_List_BlogPost_By_All";
    public static string GetBlogPostByActive = "Get_List_BlogPost_By_Active";
    public static string GetBlogPostByActiveAndLastThree = "Get_List_BlogPost_By_Active_And_LastThree";
    public static string GetBlogPostByActiveAndLastFive = "Get_List_BlogPost_By_Active_And_LastFive";
    public static string GetBlogPostById = "Get_Item_BlogPost_By_Id";
    public static string InsertBlogPost = "Insert_BlogPost";
    public static string UpdateBlogPost = "Update_BlogPost";
    public static string DeleteStatusBlogPost = "Delete_Status_BlogPost";

    #endregion

    #region Activity

    public static string GetActivityByAll = "Get_Activity_By_All";
    public static string GetActivityByActive = "Get_Activity_By_Active";
    public static string GetActivityByActiveAndLastThree = "Get_Activity_By_Active_And_Last_Three";
    public static string GetActivityByActiveAndLastFive = "Get_Activity_By_Active_And_LastFive";
    public static string GetActivityById = "Get_Activity_By_Id";
    public static string InsertActivity = "Insert_Activity";
    public static string UpdateActivity = "Update_Activity";
    public static string DeleteStatusActivity = "Delete_Status_Activity";

    #endregion

    #region News

    public static string GetNewsByAll = "Get_News_By_All";
    public static string GetNewsByActive = "Get_News_By_Active";
    public static string GetNewsByActiveAndLastThree = "Get_News_By_Active_And_LastThree";
    public static string GetNewsByActiveAndLastFive = "Get_News_By_Active_And_LastFive";
    public static string GetNewsById = "Get_News_By_Id";
    public static string InsertNews = "Insert_News";
    public static string UpdateNews = "Update_News";
    public static string DeleteStatusNews = "Delete_Status_News";
    #endregion

    #region Gallery

    public static string GetGalleryByType = "Get_Gallery_By_Type";
    public static string GetGalleryById = "Get_Gallery_By_Id";
    public static string InsertGallery = "Insert_Gallery";
    public static string UpdateGallery = "Update_Gallery";
    public static string DeleteGallery = "Delete_Gallery";
    #endregion

    #region GalleryDetail

    public static string GetGalleryDetailByGalleryId = "Get_List_Gallery_Detail_By_Gallery_Id";
    public static string InsertGalleryDetail = "Insert_Gallery_Detail";
    public static string UpdateGalleryDetail = "Update_Gallery_Detail";
    public static string DeleteGalleryDetail = "Delete_Gallery_Detail";
    #endregion



    #region BlogPostPicture

    public static string GetBlogPostPictureByBlogId = "Get_List_BlogPostPicture_By_BlogId";
    public static string InsertBlogPostPicture = "Insert_BlogPostPicture";
    public static string UpdateBlogPostPicture = "Update_BlogPostPicture";
    public static string DeleteBlogPostPicture = "Delete_BlogPostPicture";

    #endregion

    #region References

    public static string GetReferencesByAll = "Get_List_References_By_All";
    public static string GetReferencesByActive = "Get_List_References_By_Active";
    public static string GetReferencesByActiveFirstSix = "Get_List_References_By_Active_First_Six";
    public static string GetReferencesById = "Get_Item_References_By_Id";
    public static string InsertReferences = "Insert_References";
    public static string UpdateReferences = "Update_References";
    public static string DeleteReferences = "Delete_References";
    public static string ReferencesRankChanger = "References_Rank_Changer";

    #endregion

    #region ContactForm

    public static string GetContactFormByStatus = "Get_List_ContactForm_By_Status";
    public static string GetContactFormById = "Get_Item_ContactForm_By_Id";
    public static string InsertContactForm = "Insert_ContactForm";
    public static string ReadContactForm = "Read_ContactForm";
    public static string UpdateStatusContactForm = "Update_Status_ContactForm";

    #endregion

    #region General

    public static string GetGeneralInformation = "Get_Item_GeneralInformation";
    public static string UpdateGeneralInformation = "Update_GeneralInformation";

    #endregion

    #region Reports

    public static string GetReportsByAdminDefault = "Get_Reports_By_Admin_Default";

    #endregion

    #region DemoForm

    public static string GetDemoFormByAll = "Get_List_DemoForm_By_All";
    public static string GetDemoFormById = "Get_List_DemoForm_By_Id";
    public static string InsertDemoForm = "Insert_DemoForm";

    #endregion

    #region FormClass

    public static string GetFormClassByAll = "Get_List_FormClass_By_All";

    #endregion

    #region EarlySaved

    public static string InsertEarlySaved = "Insert_EarlySaved";

    #endregion
}