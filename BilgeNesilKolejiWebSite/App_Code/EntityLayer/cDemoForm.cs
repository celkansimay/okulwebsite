using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cDemoForm : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Messages { get; set; }
    public DateTime SendDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cDemoForm> GetDemoFormByAll()
    {
        DataTable dt = new DataTable();
        List<cDemoForm> List = new List<cDemoForm>();

        dt = DAL.GetDemoFormByAll();

        foreach (DataRow row in dt.Rows)
        {
            cDemoForm item = new cDemoForm();
            {
                item.Id = row.Field<int>("Id");
                item.CompanyName = row.Field<string>("CompanyName");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.Phone = row.Field<string>("Phone");
                item.Email = row.Field<string>("Email");
                item.Messages = row.Field<string>("Messages");
                item.SendDate = row.Field<DateTime>("SendDate");
                item.Status = row.Field<int>("Status");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cDemoForm> GetDemoFormById(int pId)
    {
        DataTable dt = new DataTable();
        List<cDemoForm> List = new List<cDemoForm>();

        dt = DAL.GetDemoFormById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cDemoForm item = new cDemoForm();
            {
                item.Id = row.Field<int>("Id");
                item.CompanyName = row.Field<string>("CompanyName");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.Phone = row.Field<string>("Phone");
                item.Email = row.Field<string>("Email");
                item.Messages = row.Field<string>("Messages");
                item.SendDate = row.Field<DateTime>("SendDate");
                item.Status = row.Field<int>("Status");
            }
            List.Add(item);
        }
        return List;
    }

    public static void InsertDemoForm(string pCompanyName, string pName, string pSurname, string pPhone, string pEmail, string pMessages)
    {
        DAL.InsertDemoForm(pCompanyName, pName, pSurname, pPhone, pEmail, pMessages);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetDemoFormByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetDemoFormByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetDemoFormById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetDemoFormById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertDemoForm(string pCompanyName, string pName, string pSurname, string pPhone, string pEmail, string pMessages)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertDemoForm,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pCompanyName, pName, pSurname, pPhone, pEmail, pMessages));
    }
}