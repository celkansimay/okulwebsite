using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.UI;


public class BasePage : Page
{
    public string companyName = "Bilge Nesil Koleji";
    protected void Page_Init(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GeneralInformation2 = cGeneralInformation.GetGeneralInformation();
            GeneralInformation = GeneralInformation2[0];

            if (Session["Phone"] == null)
            {
                Session["Phone"] = GeneralInformation.Phone;
                Session["Fax"] = GeneralInformation.Fax;
                Session["AuthEmail"] = GeneralInformation.AuthEmail;
                Session["Address1"] = GeneralInformation.Address1;
                Session["Address1En"] = GeneralInformation.Address1En;
                Session["Address2"] = GeneralInformation.Address2;
                Session["Address2En"] = GeneralInformation.Address2En;
            }

            string url = Request.Url.AbsolutePath.ToLower();
            if (url.Contains("admin"))
            {
                if (CurrentUsers == null && !url.Contains("uyegirisi"))
                {
                    Response.Redirect("UyeGirisi");
                }
            }
        }
    }

    protected cAdminUser CurrentUsers
    {
        get { return (cAdminUser)Session["CurrentUsers"]; }
        set { Session["CurrentUsers"] = value; }
    }

    protected cGeneralInformation GeneralInformation
    {
        get { return (cGeneralInformation)Session["GeneralInformation"]; }
        set { Session["GeneralInformation"] = value; }
    }

    protected List<cGeneralInformation> GeneralInformation2
    {
        get { return (List<cGeneralInformation>)Session["GeneralInformation2"]; }
        set { Session["GeneralInformation2"] = value; }
    }

    public string MD5Olustur(string input)
    {
        MD5 md5Hasher = MD5.Create();
        byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        return sBuilder.ToString();
    }
    
    public string createLinkText(string text)
    {
        string retValue = text.ToLower().Replace(' ', '_').Replace('İ','i').Replace('I','i').Replace('Ü', 'u').Replace('ü', 'u').Replace('Ö', 'o').Replace('ö', 'o').Replace('Ç','c').Replace('ç', 'c').Replace('Ğ', 'g').Replace('ğ', 'g').Replace('Ş', 's').Replace('ş', 's').Replace('ı', 'i').Replace('-', '_');

        return retValue;
    }

    public static string ClearHtml(string text)
    {
        return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
    }

}