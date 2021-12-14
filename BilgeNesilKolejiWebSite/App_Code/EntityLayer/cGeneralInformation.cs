using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cGeneralInformation : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Address1 { get; set; }
    public string Address1En { get; set; }
    public string Address2 { get; set; }
    public string Address2En { get; set; }
    public string Email { get; set; }
    public string AuthEmail { get; set; }
    public string Counter1TrHeader { get; set; }
    public string Counter1EnHeader { get; set; }
    public int Counter1 { get; set; }
    public string Counter2TrHeader { get; set; }
    public string Counter2EnHeader { get; set; }
    public int Counter2 { get; set; }
    public string Counter3TrHeader { get; set; }
    public string Counter3EnHeader { get; set; }
    public int Counter3 { get; set; }
    public string Counter4TrHeader { get; set; }
    public string Counter4EnHeader { get; set; }
    public int Counter4 { get; set; }

    #endregion

    #region Methods

    public static List<cGeneralInformation> GetGeneralInformation()
    {
        DataTable dt = new DataTable();
        List<cGeneralInformation> List = new List<cGeneralInformation>();

        dt = DAL.GetGeneralInformation();

        foreach (DataRow row in dt.Rows)
        {
            cGeneralInformation item = new cGeneralInformation();
            {
                item.Id = row.Field<int>("Id");
                item.Phone = row.Field<string>("Phone");
                item.Fax = row.Field<string>("Fax");
                item.Address1 = row.Field<string>("Address1");
                item.Address1En = row.Field<string>("Address1En");
                item.Address2 = row.Field<string>("Address2");
                item.Address2En = row.Field<string>("Address2En");
                item.Email = row.Field<string>("Email");
                item.AuthEmail = row.Field<string>("AuthEmail");
                item.Counter1TrHeader = row.Field<string>("Counter1TrHeader");
                item.Counter1EnHeader = row.Field<string>("Counter1EnHeader");
                item.Counter1 = row.Field<int>("Counter1");
                item.Counter2TrHeader = row.Field<string>("Counter2TrHeader");
                item.Counter2EnHeader = row.Field<string>("Counter2EnHeader");
                item.Counter2 = row.Field<int>("Counter2");
                item.Counter3TrHeader = row.Field<string>("Counter3TrHeader");
                item.Counter3EnHeader = row.Field<string>("Counter3EnHeader");
                item.Counter3 = row.Field<int>("Counter3");
                item.Counter4TrHeader = row.Field<string>("Counter4TrHeader");
                item.Counter4EnHeader = row.Field<string>("Counter4EnHeader");
                item.Counter4 = row.Field<int>("Counter4");
            }
            List.Add(item);
        }
        return List;
    }

    public static void UpdateGeneralInformation(int pId, string pPhone, string pFax, string pAddress1, string pAddress1En, string pAddress2, string pAddress2En, string pEmail, string pAuthEmail, string pCounter1TrHeader, string Counter1EnHeader, int pCounter1
        , string pCounter2TrHeader, string Counter2EnHeader, int pCounter2, string pCounter3TrHeader, string Counter3EnHeader, int pCounter3, string pCounter4TrHeader, string Counter4EnHeader, int pCounter4)
    {
        DAL.UpdateGeneralInformation(pId, pPhone, pFax, pAddress1, pAddress1En, pAddress2, pAddress2En, pEmail, pAuthEmail, pCounter1TrHeader, Counter1EnHeader, pCounter1, pCounter2TrHeader, Counter2EnHeader, pCounter2, pCounter3TrHeader,
            Counter3EnHeader, pCounter3, pCounter4TrHeader, Counter4EnHeader, pCounter4);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetGeneralInformation()
    {
        return (DataTable)UtilMySqlHelper.ExecuteDataTable(conString, CommandType.StoredProcedure, SpNameCollection.GetGeneralInformation,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters()));
    }
    public void UpdateGeneralInformation(int pId, string pPhone, string pFax, string pAddress1, string pAddress1En, string pAddress2, string pAddress2En, string pEmail, string pAuthEmail, string pCounter1TrHeader, string Counter1EnHeader, int pCounter1
        , string pCounter2TrHeader, string Counter2EnHeader, int pCounter2, string pCounter3TrHeader, string Counter3EnHeader, int pCounter3, string pCounter4TrHeader, string Counter4EnHeader, int pCounter4)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.UpdateGeneralInformation,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pId, pPhone, pFax, pAddress1, pAddress1En, pAddress2, pAddress2En, pEmail, pAuthEmail, pCounter1TrHeader, Counter1EnHeader,
            pCounter1, pCounter2TrHeader, Counter2EnHeader, pCounter2, pCounter3TrHeader, Counter3EnHeader, pCounter3, pCounter4TrHeader, Counter4EnHeader, pCounter4));
    }
}