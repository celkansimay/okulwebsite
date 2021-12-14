using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Users : BasePage
{
    List<cAdminUser> AdminUserList
    {
        get { return (List<cAdminUser>)ViewState["AdminUserList"]; }
        set { ViewState["AdminUserList"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            AdminUserList = cAdminUser.GetAdminUsersByAll();
            rptBlogPost.DataSource = AdminUserList;
            rptBlogPost.DataBind();

            Page.Title = "YÖNETİCİLER | Alku Admin v3.0";
        }
    }
}