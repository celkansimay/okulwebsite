using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_References : BasePage
{
    List<cReferences> ReferencesList
    {
        get { return (List<cReferences>)ViewState["ReferencesList"]; }
        set { ViewState["ReferencesList"] = value; }
    }

    public int minRank;
    public int maxRank;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;

            ReferencesList = cReferences.GetReferencesByAll();

            if (ReferencesList.Count > 0)
            {
                Page.Title = "REFERANSLAR | Alku Admin v3.0";

                minRank = ReferencesList[0].Rank;

                foreach (var item in ReferencesList)
                {
                    maxRank = item.Rank;
                }

                rptReferences.DataSource = ReferencesList;
                rptReferences.DataBind();

            }
        }
    }

    public static string ClearHtml(string text)
    {
        return Regex.Replace(text, @"<(.|\n)*?>", string.Empty);
    }

    protected void rptReferences_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        switch (e.CommandName)
        {
            case "DeleteRow":
                try
                {
                    cReferences.DeleteReferences(int.Parse(e.CommandArgument.ToString()), 0);
                    Response.Redirect("Referanslar");
                }
                catch (Exception ex)
                {
                    ltrHeaderText.Text = "HATA!";
                    ltrErrorText.Text = "Referans silinemedi. Hata kodu: " + ex.ToString();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
                }
                break;
            case "ReferencesDown":
                try
                {
                    cReferences.ReferencesRankChanger(ReferencesList[e.Item.ItemIndex].Id, ReferencesList[e.Item.ItemIndex + 1].Id, ReferencesList[e.Item.ItemIndex + 1].Rank, ReferencesList[e.Item.ItemIndex].Rank);

                    minRank = ReferencesList[0].Rank;

                    foreach (var item in ReferencesList)
                    {
                        maxRank = item.Rank;
                    }

                    ReferencesList = cReferences.GetReferencesByAll();
                    rptReferences.DataSource = ReferencesList;
                    rptReferences.DataBind();
                }
                catch (Exception ex)
                {
                    ltrHeaderText.Text = "HATA!";
                    ltrErrorText.Text = "Referans sıra güncellenemedi. Hata kodu: " + ex.ToString();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
                }
                break;
            case "ReferencesUp":
                try
                {
                    cReferences.ReferencesRankChanger(ReferencesList[e.Item.ItemIndex - 1].Id, ReferencesList[e.Item.ItemIndex].Id, ReferencesList[e.Item.ItemIndex].Rank, ReferencesList[e.Item.ItemIndex - 1].Rank);

                    minRank = ReferencesList[0].Rank;

                    foreach (var item in ReferencesList)
                    {
                        maxRank = item.Rank;
                    }

                    ReferencesList = cReferences.GetReferencesByAll();
                    rptReferences.DataSource = ReferencesList;
                    rptReferences.DataBind();
                }
                catch (Exception ex)
                {
                    ltrHeaderText.Text = "HATA!";
                    ltrErrorText.Text = "Referans sıra güncellenemedi. Hata kodu: " + ex.ToString();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
                }
                break;
        }
    }

    protected void rptReferences_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            LinkButton btnDown = (LinkButton)e.Item.FindControl("btnDown");
            LinkButton btnUp = (LinkButton)e.Item.FindControl("btnUp");

            if (minRank == ReferencesList[e.Item.ItemIndex].Rank)
            {
                btnDown.Visible = true;
                btnUp.Visible = false;
            }

            if (maxRank == ReferencesList[e.Item.ItemIndex].Rank)
            {
                btnDown.Visible = false;
                btnUp.Visible = true;
            }
        }
    }
}