using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cArticlePicture : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int ArticleId { get; set; }
    public string ImageUrl { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cArticlePicture> GetArticlePictureByArticleId(int pArticleId)
    {
        DataTable dt = new DataTable();
        List<cArticlePicture> List = new List<cArticlePicture>();

        dt = DAL.GetArticlePictureByArticleId(pArticleId);

        foreach (DataRow row in dt.Rows)
        {
            cArticlePicture item = new cArticlePicture();
            {
                item.Id = row.Field<int>("Id");
                item.ArticleId = row.Field<int>("ArticleId");
                item.ImageUrl = row.Field<string>("ImageUrl");
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

    public static List<cArticlePicture> GetArticlePictureById(int pId)
    {
        DataTable dt = new DataTable();
        List<cArticlePicture> List = new List<cArticlePicture>();

        dt = DAL.GetArticlePictureById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cArticlePicture item = new cArticlePicture();
            {
                item.Id = row.Field<int>("Id");
                item.ArticleId = row.Field<int>("ArticleId");
                item.ImageUrl = row.Field<string>("ImageUrl");
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

    public static void InsertArticlePicture(int pArticleId, string pImageUrl, int pInsertBy)
    {
        DAL.InsertArticlePicture(pArticleId, pImageUrl, pInsertBy);
    }

    public static void DeleteArticlePicture(int pId)
    {
        DAL.DeleteArticlePicture(pId);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetArticlePictureByArticleId(int pArticleId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetArticlePictureByArticleId,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pArticleId));
    }
    public DataTable GetArticlePictureById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetArticlePictureById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertArticlePicture(int pArticleId, string pImageUrl, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertArticlePicture,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pArticleId, pImageUrl, pInsertBy));
    }
    public void DeleteArticlePicture(int pId)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteArticlePicture,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
}