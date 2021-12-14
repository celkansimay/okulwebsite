using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cNews : DataAccess
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
    public string ShortArticle { get; set; }

    #endregion

    #region Methods

    public static List<cNews> GetNewsByAll()
    {
        DataTable dt = new DataTable();
        List<cNews> List = new List<cNews>();

        dt = DAL.GetNewsByAll();

        foreach (DataRow row in dt.Rows)
        {
            cNews item = new cNews();
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
    public static List<cNews> GetNewsByActive()
    {
        DataTable dt = new DataTable();
        List<cNews> List = new List<cNews>();

        dt = DAL.GetNewsByActive();

        foreach (DataRow row in dt.Rows)
        {
            cNews item = new cNews();
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
                item.Link = "HaberDetay/-" + item.Id + "/" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }
    public static List<cNews> GetNewsByActiveAndLastThree()
    {
        DataTable dt = new DataTable();
        List<cNews> List = new List<cNews>();

        dt = DAL.GetNewsByActiveAndLastThree();

        foreach (DataRow row in dt.Rows)
        {
            cNews item = new cNews();
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

                item.ShortArticle = BasePage.ClearHtml(item.Article).Length > 250 ? BasePage.ClearHtml(item.Article).Substring(0, 250) + "..." : BasePage.ClearHtml(item.Article); 
                item.NameSurname = row.Field<string>("NameSurname");
                item.Link = "HaberDetay/-" + item.Id + "/" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }
    public static List<cNews> GetNewsByActiveAndLastFive()
    {
        DataTable dt = new DataTable();
        List<cNews> List = new List<cNews>();

        dt = DAL.GetNewsByActiveAndLastFive();

        foreach (DataRow row in dt.Rows)
        {
            cNews item = new cNews();
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

                item.Link = "HaberDetay/-" + item.Id + "/" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }
    public static List<cNews> GetNewsById(int pId)
    {
        DataTable dt = new DataTable();
        List<cNews> List = new List<cNews>();

        dt = DAL.GetNewsById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cNews item = new cNews();
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

    public static void InsertNews(string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        DAL.InsertNews(pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy);
    }

    public static void UpdateNews(int pId, string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        DAL.UpdateNews(pId, pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy);
    }

    public static void DeleteStatusNews(int pId, int pStatus)
    {
        DAL.DeleteStatusNews(pId, pStatus);
    }
    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetNewsByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetNewsByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetNewsByActive()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetNewsByActive,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetNewsByActiveAndLastThree()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetNewsByActiveAndLastThree,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetNewsByActiveAndLastFive()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetNewsByActiveAndLastFive,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetNewsById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetNewsById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertNews(string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertNews,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy));
    }
    public void UpdateNews(int pId, string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateNews,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy));
    }
    public void DeleteStatusNews(int pId, int pStatus)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteStatusNews,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pStatus));
    }
}