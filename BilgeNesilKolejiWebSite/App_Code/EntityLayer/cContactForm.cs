using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class  cContactForm : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Header { get; set; }
    public string Messages { get; set; }
    public DateTime SendDate { get; set; }
    public int? ReadBy { get; set; }
    public DateTime? ReadDate { get; set; }
    public int Status { get; set; }

    public string StatusIcon { get; set; }
    public string ReadNameSurname { get; set; }

    #endregion

    #region Methods

    public static List<cContactForm> GetContactFormByStatus(int pStatus)
    {
        DataTable dt = new DataTable();
        List<cContactForm> List = new List<cContactForm>();

        dt = DAL.GetContactFormByStatus(pStatus);

        foreach (DataRow row in dt.Rows)
        {
            cContactForm item = new cContactForm();
            {
                item.Id = row.Field<int>("Id");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.Phone = row.Field<string>("Phone");
                item.Email = row.Field<string>("Email");
                item.Header = row.Field<string>("Header");
                item.Messages = row.Field<string>("Messages");
                item.SendDate = row.Field<DateTime>("SendDate");
                item.ReadBy = row.Field<int?>("ReadBy");
                item.ReadDate = row.Field<DateTime?>("ReadDate");
                item.Status = row.Field<int>("Status");

                item.StatusIcon = item.ReadDate != null ? "<i class=\"fa fa-envelope-open\"></i>" : "<i class=\"fa fa-envelope\"></i>";
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cContactForm> GetContactFormById(int pId)
    {
        DataTable dt = new DataTable();
        List<cContactForm> List = new List<cContactForm>();

        dt = DAL.GetContactFormById(pId);

        foreach (DataRow row in dt.Rows)
        {
            cContactForm item = new cContactForm();
            {
                item.Id = row.Field<int>("Id");
                item.Name = row.Field<string>("Name");
                item.Surname = row.Field<string>("Surname");
                item.Phone = row.Field<string>("Phone");
                item.Email = row.Field<string>("Email");
                item.Header = row.Field<string>("Header");
                item.Messages = row.Field<string>("Messages");
                item.SendDate = row.Field<DateTime>("SendDate");
                item.ReadBy = row.Field<int?>("ReadBy");
                item.ReadDate = row.Field<DateTime?>("ReadDate");
                item.Status = row.Field<int>("Status");
                item.ReadNameSurname = row.Field<string>("ReadNameSurname");
            }
            List.Add(item);
        }
        return List;
    }

    public static void InsertContactForm(string pName, string pSurname, string pPhone, string pEmail, string pHeader, string pMessages)
    {
        DAL.InsertContactForm(pName, pSurname, pPhone, pEmail, pHeader, pMessages);
    }

    public static void ReadContactForm(int pId, int pReadBy)
    {
        DAL.ReadContactForm(pId, pReadBy);
    }

    public static void UpdateStatusContactForm(int pId, int pStatus)
    {
        DAL.UpdateStatusContactForm(pId, pStatus);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetContactFormByStatus(int pStatus)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetContactFormByStatus,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pStatus));
    }
    public DataTable GetContactFormById(int pId)
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetContactFormById,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId));
    }
    public void InsertContactForm(string pName, string pSurname, string pPhone, string pEmail, string pHeader, string pMessages)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertContactForm,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pName, pSurname, pPhone, pEmail, pHeader, pMessages));
    }
    public void ReadContactForm(int pId, int pReadBy)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.ReadContactForm,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pReadBy));
    }
    public void UpdateStatusContactForm(int pId, int pStatus)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateStatusContactForm,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pStatus));
    }
}