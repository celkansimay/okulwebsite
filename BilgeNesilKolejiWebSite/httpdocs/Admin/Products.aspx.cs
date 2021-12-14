using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Products : BasePage
{
    List<cProducts> ProductsList
    {
        get { return (List<cProducts>)ViewState["ProductsList"]; }
        set { ViewState["ProductsList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            Page.Title = "ÜRÜNLER | Alku Admin v3.0";

            ProductsList = cProducts.GetProductsByAll();
            rptProducts.DataSource = ProductsList;
            rptProducts.DataBind();
        }
    }

    public static string ClearHtml(string text)
    {
        return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
    }
}