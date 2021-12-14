using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cArticle : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public string Header { get; set; }
    public string HeaderEn { get; set; }
    public string Content { get; set; }
    public string ContentEn { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cArticle> GetArticleByAll()
    {
        DataTable dt = new DataTable();
        List<cArticle> List = new List<cArticle>();

        dt = DAL.GetArticleByAll();

        foreach (DataRow row in dt.Rows)
        {
            cArticle item = new cArticle();
            {
                item.Id = row.Field<int>("Id");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Content = row.Field<string>("Content");
                item.ContentEn = row.Field<string>("ContentEn");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cArticle> GetArticleById(int pId)
    {
        DataTable dt = new DataTable();
        List<cArticle> List = new List<cArticle>();

        dt = DAL.GetArticleById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cArticle item = new cArticle();
            {
                item.Id = row.Field<int>("Id");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Content = row.Field<string>("Content");
                item.ContentEn = row.Field<string>("ContentEn");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
            }
            List.Add(item);
        }
        return List;
    }

    public static void InsertArticle(string pImageUrl, string pHeader, string pHeaderEn, string pContent, string pContentEn, int pInsertBy)
    {
        DAL.InsertArticle(pImageUrl, pHeader, pHeaderEn, pContent, pContentEn, pInsertBy);
    }

    public static void UpdateArticle(int pId, string pImageUrl, string pHeader, string pHeaderEn, string pContent, string pContentEn, int pUpdateBy)
    {
        DAL.UpdateArticle(pId, pImageUrl, pHeader, pHeaderEn, pContent, pContentEn, pUpdateBy);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetArticleByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetArticleByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetArticleById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetArticleById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertArticle(string pImageUrl, string pHeader, string pHeaderEn, string pContent, string pContentEn, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertArticle,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pImageUrl, pHeader, pHeaderEn, pContent, pContentEn, pInsertBy));
    }
    public void UpdateArticle(int pId, string pImageUrl, string pHeader, string pHeaderEn, string pContent, string pContentEn, int pUpdateBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateArticle,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pImageUrl, pHeader, pHeaderEn, pContent, pContentEn, pUpdateBy));
    }
}