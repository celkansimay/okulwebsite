using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Messages : BasePage
{
    List<cContactForm> ContactFormList
    {
        get { return (List<cContactForm>)ViewState["ContactFormList"]; }
        set { ViewState["ContactFormList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            Page.Title = "GELEN MESAJLAR | Alku Admin v3.0";

            ContactFormList = cContactForm.GetContactFormByStatus(1);
            rptContents.DataSource = ContactFormList;
            rptContents.DataBind();
        }
    }
}