using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EarlySaved : BasePage
{
    protected List<cFormClass> FormClassList;// = new List<cFormClass>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            FormClassList = cFormClass.GetFormClassByAll();
            ddlClass.DataSource = FormClassList;
            ddlClass.DataBind();
        }
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtPhone.Text) &&
               ddlClass.SelectedValue != "-1" && !string.IsNullOrEmpty(txtParentName.Text) && !string.IsNullOrEmpty(txtParentPhone.Text))
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(GeneralInformation.AuthEmail);
            //mail.To.Add("info@cagrihanhalilkuru.com.tr");
            mail.From = new MailAddress("flamingookul@yandex.com");
            mail.Subject = txtName.Text + " " + txtSurname.Text + " erkenkayit.seviyekurslari.com/basvuru adresinden bir adet sınav başvurusu geldi.";
            mail.Body =
                  "SEVİYE KURSLARI ERKEN KAYIT FORMU " +
                  //"<br />Kimlik Numarası: " + txtTCIdentifyNumber.Text +
                  //"<br />Şube: " + ddlBranchs.SelectedItem.Text +
                  "<br />Sınıfı: " + FormClassList[ddlClass.SelectedIndex].Name +
                  "<br />Adı Soyadı: " + txtName.Text + " " + txtSurname.Text +
                  "<br />Telefon: " + txtPhone.Text +
                  //"<br />Okulu: " + txtSchool.Text +
                  "<br />Veli Adı: " + txtParentName.Text +
                  "<br />Veli Telefonu: " + txtParentPhone.Text;

            mail.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.yandex.com", 587);
            client.EnableSsl = true;
            NetworkCredential credentials = new NetworkCredential("flamingookul@yandex.com", "chk#1987124");

            client.Credentials = credentials;

            try
            {
                cEarlySaved.InsertEarlySaved(int.Parse(ddlClass.SelectedValue), txtName.Text, txtSurname.Text, txtPhone.Text, txtParentName.Text, txtParentPhone.Text);

                client.Send(mail);

                ddlClass.Enabled = false;
                txtName.Text = string.Empty;
                txtParentName.Text = string.Empty;
                txtParentPhone.Text = string.Empty;
                txtPhone.Text = string.Empty;
                txtSurname.Text = string.Empty;

                ltrHeaderText.Text = "BAŞARILI!";
                ltrErrorText.Text = "Erken kayıt başvurunuz alındı. En kısa sürede sizinle iletişime geçilecektir.";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
            }
            catch (Exception ex)
            {
                string errText = "Mesaj gönderilemedi. Hata Kodu: " + ex.ToString();
                ltrHeaderText.Text = "Mesaj Gönderilemedi!";
                ltrErrorText.Text = errText;
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
            }
        }
        else
        {
            ltrHeaderText.Text = "Eksik Bilgi.";
            ltrErrorText.Text = "Lütfen tüm alanları doldurup tekrar deneyiniz.";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
        }
    }
}