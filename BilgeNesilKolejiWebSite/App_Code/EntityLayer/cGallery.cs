using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cGallery : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int Type { get; set; }
    public string Url { get; set; }
    public string Header { get; set; }
    public string HeaderEn { get; set; }
    public string Description { get; set; }
    public string DescriptionEn { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cGallery> GetGalleryByType(int pType)
    {
        DataTable dt = new DataTable();
        List<cGallery> List = new List<cGallery>();

        dt = DAL.GetGalleryByType(pType);

        foreach (DataRow row in dt.Rows)
        {
            cGallery item = new cGallery();
            {
                item.Id = row.Field<int>("Id");
                item.Type = row.Field<int>("Type");
                item.Url = row.Field<string>("Url");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Description = row.Field<string>("Description");
                item.DescriptionEn = row.Field<string>("DescriptionEn");
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

    public static List<cGallery> GetGalleryById(int pType)
    {
        DataTable dt = new DataTable();
        List<cGallery> List = new List<cGallery>();

        dt = DAL.GetGalleryById(pType);

        foreach (DataRow row in dt.Rows)
        {
            cGallery item = new cGallery();
            {
                item.Id = row.Field<int>("Id");
                item.Type = row.Field<int>("Type");
                item.Url = row.Field<string>("Url");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Description = row.Field<string>("Description");
                item.DescriptionEn = row.Field<string>("DescriptionEn");
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

    public static DataTable InsertGallery(int pType, string pUrl, string pHeader, string pHeaderEn, string pDescription, string pDescriptionEn, int pInsertBy)
    {
      return (DataTable)DAL.InsertGallery(pType, pUrl, pHeader, pHeaderEn, pDescription, pDescriptionEn, pInsertBy);
    }

    public static void UpdateGallery(int pId, int pType, string pUrl, string pHeader, string pHeaderEn, string pDescription, string pDescriptionEn, int pUpdateBy)
    {
        DAL.UpdateGallery(pId, pType, pUrl, pHeader, pHeaderEn, pDescription, pDescriptionEn, pUpdateBy);
    }

    public static void DeleteGallery(int pId)
    {
        DAL.DeleteGallery(pId);
    }

    #endregion
}

public partial class DataAccessLayer
{

    public DataTable GetGalleryByType(int pType)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetGalleryByType,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pType));
    }
    public DataTable GetGalleryById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetGalleryById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }

    public DataTable InsertGallery(int pType, string pUrl, string pHeader, string pHeaderEn, string pDescription, string pDescriptionEn, int pInsertBy)
    {
       return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.InsertGallery,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pType, pUrl, pHeader, pHeaderEn, pDescription, pDescriptionEn, pInsertBy));
    }

    public void UpdateGallery(int pId, int pType, string pUrl, string pHeader, string pHeaderEn, string pDescription, string pDescriptionEn, int pUpdateBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateGallery,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pType, pUrl, pHeader, pHeaderEn, pDescription, pDescriptionEn, pUpdateBy));
    }

    public void DeleteGallery(int pId)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteGallery,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }

}