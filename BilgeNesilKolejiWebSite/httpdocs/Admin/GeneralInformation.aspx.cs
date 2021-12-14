using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_GeneralInformation : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ltrBranchName.Text = companyName;
            ltrHeader.Text = "Genel Ayarlar";

            Page.Title = "GENEL AYARLAR | Alku Admin v3.0";

            txtPhone.Text = GeneralInformation.Phone;
            txtFax.Text = GeneralInformation.Fax;
            txtEmail.Text = GeneralInformation.Email;
            txtAuthEmail.Text = GeneralInformation.AuthEmail;
            txtAddress1.Text = GeneralInformation.Address1;
           // txtAddress1En.Text = GeneralInformation.Address1En;
            txtAddress2.Text = GeneralInformation.Address2;
            //txtAddress2En.Text = GeneralInformation.Address2En;

            txtCounter1.Text = GeneralInformation.Counter1.ToString();
            txtCounter2.Text = GeneralInformation.Counter2.ToString();
            txtCounter3.Text = GeneralInformation.Counter3.ToString();
            txtCounter4.Text = GeneralInformation.Counter4.ToString();

            txtCounter1TrHeader.Text = GeneralInformation.Counter1TrHeader;
            txtCounter2TrHeader.Text = GeneralInformation.Counter2TrHeader;
            txtCounter3TrHeader.Text = GeneralInformation.Counter3TrHeader;
            txtCounter4TrHeader.Text = GeneralInformation.Counter4TrHeader;

            //txtCounter1EnHeader.Text = GeneralInformation.Counter1EnHeader;
            //txtCounter2EnHeader.Text = GeneralInformation.Counter2EnHeader;
            //txtCounter3EnHeader.Text = GeneralInformation.Counter3EnHeader;
            //txtCounter4EnHeader.Text = GeneralInformation.Counter4EnHeader;
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtFax.Text) && !string.IsNullOrEmpty(txtAddress1.Text) && !string.IsNullOrEmpty(txtAddress2.Text) 
            && !string.IsNullOrEmpty(txtEmail.Text))
        {
            try
            {
                cGeneralInformation.UpdateGeneralInformation(GeneralInformation.Id, txtPhone.Text, txtFax.Text, txtAddress1.Text, "", txtAddress2.Text, "", txtEmail.Text, txtAuthEmail.Text,
                    txtCounter1TrHeader.Text, "", int.Parse(txtCounter1.Text),txtCounter2TrHeader.Text, "", int.Parse(txtCounter2.Text),
                    txtCounter3TrHeader.Text, "", int.Parse(txtCounter3.Text),txtCounter4TrHeader.Text, "", int.Parse(txtCounter4.Text));

                GeneralInformation2 = cGeneralInformation.GetGeneralInformation();
                GeneralInformation = GeneralInformation2[0];

                Response.Redirect("Ayarlar");
            }
            catch (Exception ex)
            {
                ltrHeaderText.Text = "HATA!";
                ltrErrorText.Text = "Bilgiler kaydedilemdi. Hata kodu: " + ex.ToString();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
            }
        }
        else
        {
            ltrHeaderText.Text = "Eksik Bilgi!";
            ltrErrorText.Text = "Lütfen tüm alanları girip tekrar deneyiniz.";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
        }
    }
}