using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cAdminUser : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string NameSurname { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public DateTime InsertDate { get; set; }
    public int Status { get; set; }
    public DateTime? LastLoginDate { get; set; }

    #endregion

    #region Methods

    public static List<cAdminUser> GetAdminUsersByAll()
    {
        DataTable dt = new DataTable();
        List<cAdminUser> List = new List<cAdminUser>();

        dt = DAL.GetAdminUsersByAll();

        foreach (DataRow row in dt.Rows)
        {
            cAdminUser item = new cAdminUser();
            {
                item.Id = row.Field<int>("Id");
                item.NameSurname = row.Field<string>("NameSurname");
                item.UserName = row.Field<string>("UserName");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.Status = row.Field<int>("Status");
                item.LastLoginDate = row.Field<DateTime?>("LastLoginDate");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cAdminUser> GetAdminUsersById(int pId)
    {
        DataTable dt = new DataTable();
        List<cAdminUser> List = new List<cAdminUser>();

        dt = DAL.GetAdminUsersById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cAdminUser item = new cAdminUser();
            {
                item.Id = row.Field<int>("Id");
                item.NameSurname = row.Field<string>("NameSurname");
                item.UserName = row.Field<string>("UserName");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.Status = row.Field<int>("Status");
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cAdminUser> AdminUserLogin(string pUserName, string pPassword)
    {
        DataTable dt = new DataTable();
        List<cAdminUser> List = new List<cAdminUser>();

        dt = DAL.AdminUserLogin(pUserName, pPassword);

        foreach (DataRow row in dt.Rows)
        {
            cAdminUser item = new cAdminUser();
            {
                item.Id = row.Field<int>("Id");
                item.NameSurname = row.Field<string>("NameSurname");
                item.UserName = row.Field<string>("UserName");
                item.InsertDate = row.Field<DateTime>("InsertDate");
                item.Status = row.Field<int>("Status");
            }
            List.Add(item);
        }
        return List;
    }

    public static void InsertAdminUser(string pNameSurname, string pUserName, string pPassword)
    {
        DAL.InsertAdminUser(pNameSurname, pUserName, pPassword);
    }

    public static void UpdateAdminUser(int pId, string pNameSurname, string pUserName, string pPassword)
    {
        DAL.UpdateAdminUser(pId, pNameSurname, pUserName, pPassword);
    }

    public static void DeleteAdminUser(int pId)
    {
        DAL.DeleteAdminUser(pId);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetAdminUsersByAll()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetAdminUsersByAll,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public DataTable GetAdminUsersById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetAdminUsersById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public DataTable AdminUserLogin(string pUserName, string pPassword)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.AdminUserLogin,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pUserName, pPassword));
    }

    public void InsertAdminUser(string pNameSurname, string pUserName, string pPassword)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertAdminUser,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pNameSurname, pUserName, pPassword));
    }

    public void UpdateAdminUser(int pId, string pNameSurname, string pUserName, string pPassword)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateAdminUser,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pNameSurname, pUserName, pPassword));
    }

    public void DeleteAdminUser(int pId)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.DeleteAdminUser,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
}