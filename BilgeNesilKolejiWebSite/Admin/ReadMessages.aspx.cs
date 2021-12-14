using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ReadMessages : BasePage
{
    List<cContactForm> ContactFormItem
    {
        get { return (List<cContactForm>)ViewState["ContactFormItem"]; }
        set { ViewState["ContactFormItem"] = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (!Page.IsPostBack)
            {
                ltrBranchName.Text = companyName;

                ContactFormItem = cContactForm.GetContactFormById(int.Parse(RouteData.Values["Id"].ToString()));

                Page.Title = ContactFormItem[0].Name + " " + ContactFormItem[0].Surname + "MESAJ OKU | Alku Admin v3.0";

                if (ContactFormItem[0].ReadBy == null)
                {
                    cContactForm.ReadContactForm(ContactFormItem[0].Id, CurrentUsers.Id);

                    ContactFormItem = cContactForm.GetContactFormById(int.Parse(RouteData.Values["Id"].ToString()));
                }

                ltrNameSurname.Text = ContactFormItem[0].Name + " " + ContactFormItem[0].Surname;
                ltrPhone.Text = ContactFormItem[0].Phone;
                ltrEmail.Text = ContactFormItem[0].Email;
                ltrMessageHeader.Text = ContactFormItem[0].Header;
                ltrMessages.Text = ContactFormItem[0].Messages;
                ltrReadDate.Text = DateTime.Parse(ContactFormItem[0].ReadDate.ToString()).ToString("dd/MM/yyyy HH:mm");
                ltrReadBy.Text = ContactFormItem[0].ReadNameSurname;

                ltrHeader.Text = ContactFormItem[0].Name + " " + ContactFormItem[0].Surname + " Mesaj Gönderdi";
            }
        }
    }
}