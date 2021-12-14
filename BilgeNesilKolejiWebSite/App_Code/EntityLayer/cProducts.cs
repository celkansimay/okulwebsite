using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cProducts : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public string ProductName { get; set; }
    public string ProductNameEn { get; set; }
    public string Description { get; set; }
    public string DescriptionEn { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cProducts> GetProductsByAll()
    {
        DataTable dt = new DataTable();
        List<cProducts> List = new List<cProducts>();

        dt = DAL.GetProductsByAll();

        foreach (DataRow row in dt.Rows)
        {
            cProducts item = new cProducts();
            {
                item.Id = row.Field<int>("Id");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.ProductName = row.Field<string>("ProductName");
                item.ProductNameEn = row.Field<string>("ProductNameEn");
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

    public static List<cProducts> GetProductsById(int pId)
    {
        DataTable dt = new DataTable();
        List<cProducts> List = new List<cProducts>();

        dt = DAL.GetProductsById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cProducts item = new cProducts();
            {
                item.Id = row.Field<int>("Id");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.ProductName = row.Field<string>("ProductName");
                item.ProductNameEn = row.Field<string>("ProductNameEn");
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

    public static void InsertProducts(string pImageUrl, string pProductName, string pProductNameEn, string pDescription, string pDescriptionEn, int pInsertBy)
    {
        DAL.InsertProducts(pImageUrl, pProductName, pProductNameEn, pDescription, pDescriptionEn, pInsertBy);
    }

    public static void UpdateProducts(int pId, string pImageUrl, string pProductName, string pProductNameEn, string pDescription, string pDescriptionEn, int pInsertBy)
    {
        DAL.UpdateProducts(pId, pImageUrl, pProductName, pProductNameEn, pDescription, pDescriptionEn, pInsertBy);
    }

    public static void UpdateStatusProducts(int pId, int pStatus)
    {
        DAL.UpdateStatusProducts(pId, pStatus);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetProductsByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetProductsByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetProductsById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetProductsById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertProducts(string pImageUrl, string pProductName, string pProductNameEn, string pDescription, string pDescriptionEn, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertProducts,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pImageUrl, pProductName, pProductNameEn, pDescription, pDescriptionEn, pInsertBy));
    }
    public void UpdateProducts(int pId, string pImageUrl, string pProductName, string pProductNameEn, string pDescription, string pDescriptionEn, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateProducts,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pImageUrl, pProductName, pProductNameEn, pDescription, pDescriptionEn, pInsertBy));
    }
    public void UpdateStatusProducts(int pId, int pStatus)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateStatusProducts,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pStatus));
    }
}