using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DemoFormDetail : BasePage
{
    List<cDemoForm> DemoFormItem
    {
        get { return (List<cDemoForm>)ViewState["DemoFormItem"]; }
        set { ViewState["DemoFormItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;
            DemoFormItem = cDemoForm.GetDemoFormById(int.Parse(RouteData.Values["Id"].ToString()));

            Page.Title = DemoFormItem[0].Name + " " + DemoFormItem[0].Surname + " DEMO TALEBİ | Alku Admin v3.0";

            ltrCompanyName.Text = DemoFormItem[0].CompanyName;
            ltrNameSurname.Text = DemoFormItem[0].Name + " " + DemoFormItem[0].Surname;
            ltrPhone.Text = DemoFormItem[0].Phone;
            ltrEmail.Text = DemoFormItem[0].Email;
            ltrMessages.Text = DemoFormItem[0].Messages;

            ltrHeader.Text = DemoFormItem[0].Name + " " + DemoFormItem[0].Surname + " Demo talebi gönderdi";
        }
    }
}