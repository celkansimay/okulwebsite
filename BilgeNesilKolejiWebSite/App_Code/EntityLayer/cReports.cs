using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cReports : DataAccess
{
    #region Properties

    public int BlogCount { get; set; }
    public int ReferencesCount { get; set; }
    public int ProductCount { get; set; }
    public int MessagesCount { get; set; }

    #endregion

    #region Methods

    public static List<cReports> GetReportsByAdminDefault()
    {
        DataTable dt = new DataTable();
        List<cReports> List = new List<cReports>();

        dt = DAL.GetReportsByAdminDefault();

        foreach (DataRow row in dt.Rows)
        {
            cReports item = new cReports();
            {
                item.BlogCount = int.Parse(row.Field<Int64>("BlogCount").ToString());
                item.ReferencesCount = int.Parse(row.Field<Int64>("ReferencesCount").ToString());// row.Field<int>("ReferencesCount");
                item.ProductCount = int.Parse(row.Field<Int64>("ProductCount").ToString());//row.Field<int>("ProductCount");
                item.MessagesCount = int.Parse(row.Field<Int64>("MessagesCount").ToString());// row.Field<int>("MessagesCount");
            }
            List.Add(item);
        }
        return List;
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetReportsByAdminDefault()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetReportsByAdminDefault,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
}