using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cGalleryDetail : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int GalleryId { get; set; }
    public string ImgUrl { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int Status { get; set; }

    public string InsertName { get; set; }

    #endregion
    #region Methods

    public static List<cGalleryDetail> GetGalleryDetailByGalleryId(int pGalelryId)
    {
        DataTable dt = new DataTable();
        List<cGalleryDetail> List = new List<cGalleryDetail>();

        dt = DAL.GetGalleryDetailByGalleryId(pGalelryId);

        foreach (DataRow row in dt.Rows)
        {
            cGalleryDetail item = new cGalleryDetail();
            {
                item.Id = row.Field<int>("Id");
                item.GalleryId = row.Field<int>("GalleryId");
                item.ImgUrl = row.Field<string>("ImgUrl");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.Status = row.Field<int>("Status");

                item.InsertName = row.Field<string>("InsertName");
            }
            List.Add(item);
        }
        return List;
    }
    public static void InsertGalleryDetail( int pGalleryId, string ImgUrl, int pInsertBy)
    {
        DAL.InsertGalleryDetail(pGalleryId, ImgUrl, pInsertBy);
    }

    public static void UpdateGalleryDetail(int pId, int pGalleryId, string ImgUrl, int pInsertBy)
    {
        DAL.UpdateGalleryDetail(pId, pGalleryId, ImgUrl, pInsertBy);
    }

    public static void DeleteGalleryDetail(int pId)
    {
        DAL.DeleteGalleryDetail(pId);
    }
    #endregion
}

public partial class DataAccessLayer
{

    public DataTable GetGalleryDetailByGalleryId(int pGalelryId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetGalleryDetailByGalleryId,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pGalelryId));
    }
    public void InsertGalleryDetail(int pGalleryId, string ImgUrl, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertGalleryDetail,
             MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pGalleryId, ImgUrl, pInsertBy));
    }

    public void UpdateGalleryDetail(int pId, int pGalleryId, string ImgUrl, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateGalleryDetail,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pGalleryId, ImgUrl, pInsertBy));
    }

    public void DeleteGalleryDetail(int pId)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteGalleryDetail,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }

}