using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cReferences : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int Rank { get; set; }
    public string LogoUrl { get; set; }
    public string CompanyName { get; set; }
    public string Description { get; set; }
    public string DescriptionEn { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    public string StatusText { get; set; }

    #endregion

    #region Methods

    public static List<cReferences> GetReferencesByAll()
    {
        DataTable dt = new DataTable();
        List<cReferences> List = new List<cReferences>();

        dt = DAL.GetReferencesByAll();

        foreach (DataRow row in dt.Rows)
        {
            cReferences item = new cReferences();
            {
                item.Id = row.Field<int>("Id");
                item.Rank = row.Field<int>("Rank");
                item.LogoUrl = row.Field<string>("LogoUrl");
                item.CompanyName = row.Field<string>("CompanyName");
                item.Description = row.Field<string>("Description");
                item.DescriptionEn = row.Field<string>("DescriptionEn");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.StatusText = item.Status == 1 ? "<label class=\"label label-success\">Aktif</label>" : "<label class=\"label label-danger\">Pasif</label>";
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cReferences> GetReferencesByActive()
    {
        DataTable dt = new DataTable();
        List<cReferences> List = new List<cReferences>();

        dt = DAL.GetReferencesByActive();

        foreach (DataRow row in dt.Rows)
        {
            cReferences item = new cReferences();
            {
                item.Id = row.Field<int>("Id");
                item.LogoUrl = row.Field<string>("LogoUrl");
                item.CompanyName = row.Field<string>("CompanyName");
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

    public static List<cReferences> GetReferencesByActiveFirstSix()
    {
        DataTable dt = new DataTable();
        List<cReferences> List = new List<cReferences>();

        dt = DAL.GetReferencesByActiveFirstSix();

        foreach (DataRow row in dt.Rows)
        {
            cReferences item = new cReferences();
            {
                item.Id = row.Field<int>("Id");
                item.LogoUrl = row.Field<string>("LogoUrl");
                item.CompanyName = row.Field<string>("CompanyName");
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

    public static List<cReferences> GetReferencesById(int pId)
    {
        DataTable dt = new DataTable();
        List<cReferences> List = new List<cReferences>();

        dt = DAL.GetReferencesById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cReferences item = new cReferences();
            {
                item.Id = row.Field<int>("Id");
                item.LogoUrl = row.Field<string>("LogoUrl");
                item.CompanyName = row.Field<string>("CompanyName");
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

    public static void InsertReferences(string pLogoUrl, string pCompanyName, string pDescription, string pDescriptionEn, int pInsertBy)
    {
        DAL.InsertReferences(pLogoUrl, pCompanyName, pDescription, pDescriptionEn, pInsertBy);
    }

    public static void UpdateReferences(int pId, string pLogoUrl, string pCompanyName, string pDescription, string pDescriptionEn, int pUpdateBy)
    {
        DAL.UpdateReferences(pId, pLogoUrl, pCompanyName, pDescription, pDescriptionEn, pUpdateBy);
    }

    public static void DeleteReferences(int pId, int pStatus)
    {
        DAL.DeleteReferences(pId, pStatus);
    }

    public static void ReferencesRankChanger(int pWillShrink, int pWillGrow, int pSmallRank, int pBigRank)
    {
        DAL.ReferencesRankChanger(pWillShrink, pWillGrow, pSmallRank, pBigRank);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetReferencesByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetReferencesByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetReferencesByActive()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetReferencesByActive,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetReferencesByActiveFirstSix()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetReferencesByActiveFirstSix,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetReferencesById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetReferencesById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertReferences(string pLogoUrl, string pCompanyName, string pDescription, string pDescriptionEn, int pInsertBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertReferences,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pLogoUrl, pCompanyName, pDescription, pDescriptionEn, pInsertBy));
    }
    public void UpdateReferences(int pId, string pLogoUrl, string pCompanyName, string pDescription, string pDescriptionEn, int pUpdateBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateReferences,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pLogoUrl, pCompanyName, pDescription, pDescriptionEn, pUpdateBy));
    }
    public void DeleteReferences(int pId, int pStatus)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteReferences,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pStatus));
    }
    public void ReferencesRankChanger(int pWillShrink, int pWillGrow, int pSmallRank, int pBigRank)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.ReferencesRankChanger,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pWillShrink, pWillGrow, pSmallRank, pBigRank));
    }
}