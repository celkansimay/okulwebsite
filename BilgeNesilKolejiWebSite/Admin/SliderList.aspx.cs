using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_SliderList : BasePage
{
    List<cSliders> SlidersList
    {
        get { return (List<cSliders>)ViewState["SlidersList"]; }
        set { ViewState["SlidersList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            Page.Title = "SLIDER GÖRSELLERİ | Alku Admin v3.0";

            SlidersList = cSliders.GetSlidersByAll();
            rptSliders.DataSource = SlidersList;
            rptSliders.DataBind();
        }
    }
}