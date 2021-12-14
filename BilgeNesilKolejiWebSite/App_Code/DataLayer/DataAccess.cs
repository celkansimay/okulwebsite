using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


[Serializable]
public class DataAccess
{
	public DataAccess()
	{	}

    private static DataAccessLayer dal;
    protected static DataAccessLayer DAL
    {
        get
        {
            if (dal == null)
                dal = new DataAccessLayer();
            return dal;
        }
    }
}