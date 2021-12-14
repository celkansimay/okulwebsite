using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DemoForms : BasePage
{
    List<cDemoForm> DemoFormList
    {
        get { return (List<cDemoForm>)ViewState["DemoFormList"]; }
        set { ViewState["DemoFormList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            Page.Title = "GELEN MESAJLAR | Alku Admin v3.0";

            DemoFormList = cDemoForm.GetDemoFormByAll();
            rptContents.DataSource = DemoFormList;
            rptContents.DataBind();
        }
    }
}