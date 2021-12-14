using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Reflection;

/// <summary>
/// Summary description for DataAccessLayer
/// </summary>
public partial class DataAccessLayer
{
	public DataAccessLayer()
	{}

    public static string conString
    {
        get
        {
            string cs = "Server=185.131.49.115;Port=3306;Database=bilgenesil_ws;Uid=bilgenesiluser;Password=?0Ze88qq;Charset=utf8";
            return cs;
        }
    }
}

public sealed class MySQLParameterGeneratorEx
{
    private const string ReturnValueParameterName = "RETURN_VALUE";

    public static MySqlParameter[] GenerateParam(ParameterInfo[] methodParameters, params object[] Values)
    {
        int length = methodParameters.Length;
        MySqlParameter[] sqlParams = new MySqlParameter[length];

        for (int i = 0; i < length; i++)
        {
            MySqlParameter parameter = new MySqlParameter();
            parameter.ParameterName = "@" + methodParameters[i].Name;
            parameter.Value = Values[i];
            sqlParams[i] = parameter;
        }

        return sqlParams;
    }
}