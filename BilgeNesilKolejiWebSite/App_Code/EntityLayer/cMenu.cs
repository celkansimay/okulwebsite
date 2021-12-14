using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cMenu : DataAccess
{
    #region Methods

    public int Id { get; set; }
    public int TopId { get; set; }
    public string MenuName { get; set; }
    public string MenuNameEn { get; set; }
    public string Link { get; set; }
    public int IsProduct { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }

    public int BottomCount { get; set; }

    #endregion

    #region Methods

    public static List<cMenu> GetMenuByTopId(int pTopId)
    {
        DataTable dt = new DataTable();
        List<cMenu> List = new List<cMenu>();

        dt = DAL.GetMenuByTopId(pTopId);

        foreach (DataRow row in dt.Rows)
        {
            cMenu item = new cMenu();
            {
                item.Id = row.Field<int>("Id");
                item.TopId = row.Field<int>("TopId");
                item.MenuName = row.Field<string>("MenuName");
                item.MenuNameEn = row.Field<string>("MenuNameEn");
                item.Link = row.Field<string>("Link");
                item.IsProduct = row.Field<int>("IsProduct");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");

                item.BottomCount = (int)row.Field<Int64>("BottomCount");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cMenu> GetMenuByAll()
    {
        DataTable dt = new DataTable();
        List<cMenu> List = new List<cMenu>();

        dt = DAL.GetMenuByAll();

        foreach (DataRow row in dt.Rows)
        {
            cMenu item = new cMenu();
            {
                item.Id = row.Field<int>("Id");
                item.TopId = row.Field<int>("TopId");
                item.MenuName = row.Field<string>("MenuName");
                item.MenuNameEn = row.Field<string>("MenuNameEn");
                item.Link = row.Field<string>("Link");
                item.IsProduct = row.Field<int>("IsProduct");
                item.InsertBy = row.Field<int>("InsertBy");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.UpdateBy = row.Field<int?>("UpdateBy");
                item.UpdateDate = row.Field<DateTime?>("UpdateDate");
                item.Status = row.Field<int>("Status");
                item.BottomCount = int.Parse(row.Field<Int64>("BottomCount").ToString());
            }
            List.Add(item);
        }
        return List;
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetMenuByTopId(int pTopId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetMenuByTopId,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pTopId));
    }
    public DataTable GetMenuByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetMenuByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
}