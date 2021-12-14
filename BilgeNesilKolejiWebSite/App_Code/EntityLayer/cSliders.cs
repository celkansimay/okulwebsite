using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cSliders : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public string Header { get; set; }
    public string HeaderEn { get; set; }
    public string Description { get; set; }
    public string DescriptionEn { get; set; }
    public string Link { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cSliders> GetSlidersByAll()
    {
        DataTable dt = new DataTable();
        List<cSliders> List = new List<cSliders>();

        dt = DAL.GetSlidersByAll();

        foreach (DataRow row in dt.Rows)
        {
            cSliders item = new cSliders();
            {
                item.Id = row.Field<int>("Id");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Description = row.Field<string>("Description");
                item.DescriptionEn = row.Field<string>("DescriptionEn");
                item.Link = row.Field<string>("Link");
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

    public static List<cSliders> GetSlidersById(int pId)
    {
        DataTable dt = new DataTable();
        List<cSliders> List = new List<cSliders>();

        dt = DAL.GetSlidersById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cSliders item = new cSliders();
            {
                item.Id = row.Field<int>("Id");
                item.ImageUrl = row.Field<string>("ImageUrl");
                item.Header = row.Field<string>("Header");
                item.HeaderEn = row.Field<string>("HeaderEn");
                item.Description = row.Field<string>("Description");
                item.DescriptionEn = row.Field<string>("DescriptionEn");
                item.Link = row.Field<string>("Link");
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

    public static void InsertSlider(string pImageUrl, string pHeader, string pHeaderEn, string pDescription, string pDescriptionEn, string pLink, int pInsertBy)
    {
        DAL.InsertSlider(pImageUrl, pHeader, pHeaderEn, pDescription, pDescriptionEn, pLink, pInsertBy);
    }

    public static void UpdateSliderById(int pId, string pImageUrl, string pHeader, string pHeaderEn, string pDescription, string pDescriptionEn, string pLink, int pUpdateBy)
    {
        DAL.UpdateSliderById(pId, pImageUrl, pHeader, pHeaderEn, pDescription, pDescriptionEn, pLink, pUpdateBy);
    }

    public static void UpdateStatusSliderById(int pId, int pStatus)
    {
        DAL.UpdateStatusSliderById(pId, pStatus);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetSlidersByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetSlidersByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetSlidersById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetSlidersById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }

    public void InsertSlider(string pImageUrl, string pHeader, string pHeaderEn, string pDescription, string pDescriptionEn, string pLink, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertSlider,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pImageUrl, pHeader, pHeaderEn, pDescription, pDescriptionEn, pLink, pInsertBy));
    }

    public void UpdateSliderById(int pId, string pImageUrl, string pHeader, string pHeaderEn, string pDescription, string pDescriptionEn, string pLink, int pUpdateBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateSliderById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pImageUrl, pHeader, pHeaderEn, pDescription, pDescriptionEn, pLink, pUpdateBy));
    }

    public void UpdateStatusSliderById(int pId, int pStatus)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateStatusSliderById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pStatus));
    }
}