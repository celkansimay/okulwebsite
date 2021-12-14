using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cBlogPostPicture : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int BlogId { get; set; }
    public string ImageUrl { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cBlogPostPicture> GetBlogPostPictureByBlogId(int pBlogId)
    {
        DataTable dt = new DataTable();
        List<cBlogPostPicture> List = new List<cBlogPostPicture>();

        dt = DAL.GetBlogPostPictureByBlogId(pBlogId);

        foreach (DataRow row in dt.Rows)
        {
            cBlogPostPicture item = new cBlogPostPicture();
            {
                item.Id = row.Field<int>("Id");
                item.BlogId = row.Field<int>("BlogId");
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

    public static void InsertBlogPostPicture(int pBlogId, string pImageUrl, int pInsertBy)
    {
        DAL.InsertBlogPostPicture(pBlogId, pImageUrl, pInsertBy);
    }

    public static void UpdateBlogPostPicture(int pId, int pBlogId, string pImageUrl, int pInsertBy)
    {
        DAL.UpdateBlogPostPicture(pId, pBlogId, pImageUrl, pInsertBy);
    }

    public static void DeleteBlogPostPicture(int pId)
    {
        DAL.DeleteBlogPostPicture(pId);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetBlogPostPictureByBlogId(int pBlogId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetBlogPostPictureByBlogId,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pBlogId));
    }
    public void InsertBlogPostPicture(int pBlogId, string pImageUrl, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertBlogPostPicture,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pBlogId, pImageUrl, pInsertBy));
    }
    public void UpdateBlogPostPicture(int pId, int pBlogId, string pImageUrl, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateBlogPostPicture,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pBlogId, pImageUrl, pInsertBy));
    }
    public void DeleteBlogPostPicture(int pId)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteBlogPostPicture,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
}