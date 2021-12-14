using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cActivity : DataAccess
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

    public static List<cActivity> GetActivityByAll()
    {
        DataTable dt = new DataTable();
        List<cActivity> List = new List<cActivity>();

        dt = DAL.GetActivityByAll();

        foreach (DataRow row in dt.Rows)
        {
            cActivity item = new cActivity();
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

    public static List<cActivity> GetActivityByActive()
    {
        DataTable dt = new DataTable();
        List<cActivity> List = new List<cActivity>();

        dt = DAL.GetActivityByActive();

        foreach (DataRow row in dt.Rows)
        {
            cActivity item = new cActivity();
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

               // item.NameSurname = row.Field<string>("NameSurname");
                item.Link = "EtkinlikDetay-" + item.Id + "-" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cActivity> GetActivityByActiveAndLastThree()
    {
        DataTable dt = new DataTable();
        List<cActivity> List = new List<cActivity>();

        dt = DAL.GetActivityByActiveAndLastThree();

        foreach (DataRow row in dt.Rows)
        {
            cActivity item = new cActivity();
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
                item.Link = "EtkinlikDetay-" + item.Id + "-" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cActivity> GetActivityByActiveAndLastFive()
    {
        DataTable dt = new DataTable();
        List<cActivity> List = new List<cActivity>();

        dt = DAL.GetActivityByActiveAndLastFive();

        foreach (DataRow row in dt.Rows)
        {
            cActivity item = new cActivity();
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

                item.Link = "EtkinlikDetay-" + item.Id + "-" + item.Header.ToLower().Replace(' ', '_').Replace('İ', 'i').Replace('I', 'i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç', 'c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cActivity> GetActivityById(int pId)
    {
        DataTable dt = new DataTable();
        List<cActivity> List = new List<cActivity>();

        dt = DAL.GetActivityById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cActivity item = new cActivity();
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

    public static void InsertActivity(string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        DAL.InsertActivity(pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy);
    }

    public static void UpdateActivity(int pId, string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        DAL.UpdateActivity(pId, pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy);
    }

    public static void DeleteStatusActivity(int pId, int pStatus)
    {
        DAL.DeleteStatusActivity(pId, pStatus);
    }

    #endregion
}
public partial class DataAccessLayer
{
    public DataTable GetActivityByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetActivityByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetActivityByActive()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetActivityByActive,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetActivityByActiveAndLastThree()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetActivityByActiveAndLastThree,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetActivityByActiveAndLastFive()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetActivityByActiveAndLastFive,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetActivityById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetActivityById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertActivity(string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertActivity,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy));
    }
    public void UpdateActivity(int pId, string pHeader, string pHeaderEn, string pArticle, string pArticleEn, string pImageUrl, DateTime pReleaseDate, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateActivity,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pHeader, pHeaderEn, pArticle, pArticleEn, pImageUrl, pReleaseDate, pInsertBy));
    }
    public void DeleteStatusActivity(int pId, int pStatus)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteStatusActivity,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pStatus));
    }
}