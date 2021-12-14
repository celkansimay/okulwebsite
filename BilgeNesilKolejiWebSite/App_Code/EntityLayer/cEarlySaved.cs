using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Utilities;

[Serializable]
public class cEarlySaved : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int ClassId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string ParentName { get; set; }
    public string ParentPhone { get; set; }
    public DateTime SendDate { get; set; }
    public int? ReadBy { get; set; }
    public DateTime? ReadDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static void InsertEarlySaved(int pClassId, string pName, string pSurname, string pPhone, string pParentName, string pParentPhone)
    {
        DAL.InsertEarlySaved(pClassId, pName, pSurname, pPhone, pParentName, pParentPhone);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public void InsertEarlySaved(int pClassId, string pName, string pSurname, string pPhone, string pParentName, string pParentPhone)
    {
        UtilMySqlHelper.ExecuteNonQuery(conString, CommandType.StoredProcedure, SpNameCollection.InsertEarlySaved,
            MySQLParameterGeneratorEx.GenerateParam(((MethodInfo)MethodBase.GetCurrentMethod()).GetParameters(), pClassId, pName, pSurname, pPhone, pParentName, pParentPhone));
    }
}