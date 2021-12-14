using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Activities : BasePage
{
    List<cActivity> ActiviyList
    {
        get { return (List<cActivity>)ViewState["ActiviyList"]; }
        set { ViewState["ActiviyList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            ActiviyList = cActivity.GetActivityByAll();
            rptActivity.DataSource = ActiviyList;
            rptActivity.DataBind();

            Page.Title = "ETKİNLİK YAZILARI | Alku Admin v3.0";
        }
    }
}