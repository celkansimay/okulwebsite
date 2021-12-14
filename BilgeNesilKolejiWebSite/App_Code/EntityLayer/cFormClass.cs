using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cFormClass : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string Name { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cFormClass> GetFormClassByAll()
    {

        DataTable dt = new DataTable();
        List<cFormClass> List = new List<cFormClass>();

        dt = DAL.GetFormClassByAll();

        foreach (DataRow row in dt.Rows)
        {
            cFormClass item = new cFormClass();
            {
                item.Id = row.Field<int>("Id");
                item.Name = row.Field<string>("Name");
                item.Status = row.Field<int>("Status");
            }
            List.Add(item);
        }
        return List;
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetFormClassByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetFormClassByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
}