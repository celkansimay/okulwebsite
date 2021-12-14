using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cBlogPost : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string Header { get; set; }
    public string HeaderEn { get; set; }
    public string Article { get; set; }
    public string ArticleEn { get; set; }
    public string ImageUrl { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    public string StatusText { get; set; }
    public string NameSurname { get; set; }
    public string Link { get; set; }

    #endregion

    #region Methods

    public static List<cBlogPost> GetBlogPostByAll()
    {
        DataTable dt = new DataTable();
        List<cBlogPost> List = new List<cBlogPost>();

        dt = DAL.GetBlogPostByAll();

        foreach (DataRow row in dt.Rows)
        {
            cBlogPost item = new cBlogPost();
            {
                item.Id = row.Field<int>("Id");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Article = row.Field<string>("Article");
                item.ArticleEn = row.Field<string>("ArticleEn");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.InsertBy = row.Field<int>("InsertBy");
                item.ReleaseDate = row.Field<DateTime>("ReleaseDate");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");

                item.StatusText = item.Status == 1 ? "Aktif" : "Pasif";
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cBlogPost> GetBlogPostByActive()
    {
        DataTable dt = new DataTable();
        List<cBlogPost> List = new List<cBlogPost>();

        dt = DAL.GetBlogPostByActive();

        foreach (DataRow row in dt.Rows)
        {
            cBlogPost item = new cBlogPost();
            {
                item.Id = row.Field<int>("Id");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Article = row.Field<string>("Article");
                item.ArticleEn = row.Field<string>("ArticleEn");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.InsertBy = row.Field<int>("InsertBy");
                item.ReleaseDate = row.Field<DateTime>("ReleaseDate");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");

                item.NameSurname = row.Field<string>("NameSurname");
                item.Link = "/BlogDetay/" + item.Id + "/" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cBlogPost> GetBlogPostByActiveAndLastThree()
    {
        DataTable dt = new DataTable();
        List<cBlogPost> List = new List<cBlogPost>();

        dt = DAL.GetBlogPostByActiveAndLastThree();

        foreach (DataRow row in dt.Rows)
        {
            cBlogPost item = new cBlogPost();
            {
                item.Id = row.Field<int>("Id");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Article = row.Field<string>("Article");
                item.ArticleEn = row.Field<string>("ArticleEn");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.InsertBy = row.Field<int>("InsertBy");
                item.ReleaseDate = row.Field<DateTime>("ReleaseDate");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");

                item.Link = "BlogDetay-" + item.Id + "-" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cBlogPost> GetBlogPostByActiveAndLastFive()
    {
        DataTable dt = new DataTable();
        List<cBlogPost> List = new List<cBlogPost>();

        dt = DAL.GetBlogPostByActiveAndLastFive();

        foreach (DataRow row in dt.Rows)
        {
            cBlogPost item = new cBlogPost();
            {
                item.Id = row.Field<int>("Id");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Article = row.Field<string>("Article");
                item.ArticleEn = row.Field<string>("ArticleEn");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.InsertBy = row.Field<int>("InsertBy");
                item.ReleaseDate = row.Field<DateTime>("ReleaseDate");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");

                item.Link = "BlogDetay-" + item.Id + "-" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cBlogPost> GetBlogPostById(int pId)
    {
        DataTable dt = new DataTable();
        List<cBlogPost> List = new List<cBlogPost>();

        dt = DAL.GetBlogPostById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cBlogPost item = new cBlogPost();
            {
                item.Id = row.Field<int>("Id");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Article = row.Field<string>("Article");
                item.ArticleEn = row.Field<string>("ArticleEn");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.InsertBy = row.Field<int>("InsertBy");
                item.ReleaseDate = row.Field<DateTime>("ReleaseDate");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");

                item.NameSurname = row.Field<string>("NameSurname");
            }
            List.Add(item);
        }
        return List;
    }

    public static void InsertBlogPost(string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        DAL.InsertBlogPost(pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy);
    }

    public static void UpdateBlogPost(int pId, string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        DAL.UpdateBlogPost(pId, pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy);
    }

    public static void DeleteStatusBlogPost(int pId, int pStatus)
    {
        DAL.DeleteStatusBlogPost(pId, pStatus);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetBlogPostByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetBlogPostByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetBlogPostByActive()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetBlogPostByActive,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetBlogPostByActiveAndLastThree()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetBlogPostByActiveAndLastThree,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetBlogPostByActiveAndLastFive()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetBlogPostByActiveAndLastFive,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetBlogPostById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetBlogPostById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertBlogPost(string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertBlogPost,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy));
    }
    public void UpdateBlogPost(int pId, string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateBlogPost,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy));
    }
    public void DeleteStatusBlogPost(int pId, int pStatus)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteStatusBlogPost,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pStatus));
    }
}