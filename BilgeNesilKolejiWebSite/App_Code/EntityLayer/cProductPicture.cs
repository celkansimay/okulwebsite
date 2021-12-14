using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cProductPicture : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ImageUrl { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cProductPicture> GetProductPictureByProductId(int pProductId)
    {
        DataTable dt = new DataTable();
        List<cProductPicture> List = new List<cProductPicture>();

        dt = DAL.GetProductPictureByProductId(pProductId);

        foreach (DataRow row in dt.Rows)
        {
            cProductPicture item = new cProductPicture();
            {
                item.Id = row.Field<int>("Id");
                item.ProductId = row.Field<int>("ProductId");
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

    public static void InsertProductPicture(int pProductId, string pImageUrl, int pInsertBy)
    {
        DAL.InsertProductPicture(pProductId, pImageUrl, pInsertBy);
    }

    public static void UpdateProductPicture(int pId, int pProductId, string pImageUrl, int pInsertBy)
    {
        DAL.UpdateProductPicture(pId, pProductId, pImageUrl, pInsertBy);
    }

    public static void DeleteProductPicture(int pId)
    {
        DAL.DeleteProductPicture(pId);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetProductPictureByProductId(int pProductId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetProductPictureByProductId,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pProductId));
    }
    public void InsertProductPicture(int pProductId, string pImageUrl, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertProductPicture,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pProductId, pImageUrl, pInsertBy));
    }
    public void UpdateProductPicture(int pId, int pProductId, string pImageUrl, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateProductPicture,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pProductId, pImageUrl, pInsertBy));
    }
    public void DeleteProductPicture(int pId)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteProductPicture,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
}