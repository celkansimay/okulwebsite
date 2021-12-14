using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TextBoxReloadPlaceHolder();
        HttpCookie cookie = Request.Cookies["Language"];
        if (cookie == null)
        {
            cookie = new HttpCookie("Language");
            cookie.Value = "tr-TR";
        }
        if (cookie.Value == "tr-TR")//tr lang
        {
            //Page.Title = "İLETİŞİM | LOBİTEK YAZILIM A.Ş.";

            ltrContactHeader.Text = "İLETİŞİM BİLGİLERİ";
            ltrAddress1.Text = GeneralInformation.Address1;
            ltrAddress2.Text = GeneralInformation.Address2;
            //ltrHeader.Text = "<span>Düşüncelerİnİz Önemlİ</span>";
            //ltrHeader2.Text = "Daha Fazla Bİlgİ Almak İçİn Aşağıdakİ Form'u Doldurun";
            ltrPhone.Text = "Telefon : ";
            ltrAddress.Text = "Adres : ";

            btnSend.Text = "Gönder";
        }
        else if (cookie.Value == "en-US")//eng lang
        {
            Page.Title = "CONTACT US | BİLGE NESİL KOLEJİ";

            ltrContactHeader.Text = "CONTACT INFORMATION";
            ltrAddress1.Text = GeneralInformation.Address1En;
            ltrAddress2.Text = GeneralInformation.Address2En;
            //ltrHeader.Text = "<span>CONTACT FORM</span>";
            //ltrHeader2.Text = "YOU CAN SEND YOUR REQUEST AND COMPLAINTS TO US.";
            ltrPhone.Text = "Phone : ";
            ltrAddress.Text = "Address : ";

            btnSend.Text = "Send";
        }
    }


    //private void TextBoxReloadPlaceHolder()
    //{
    //    HttpCookie cookie = Request.Cookies["Language"];
    //    if (cookie == null)
    //    {
    //        cookie = new HttpCookie("Language");
    //        cookie.Value = "tr-TR";
    //    }
    //    if (cookie.Value == "tr-TR")//tr lang
    //    {
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox", "$(\"#txtName\").attr(\"placeholder\", \"Adınız\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox2", "$(\"#txtSurname\").attr(\"placeholder\", \"Soyadınız\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox3", "$(\"#txtPhone\").attr(\"placeholder\", \"Telefon\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox4", "$(\"#txtEmail\").attr(\"placeholder\", \"E-mail\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox5", "$(\"#txtHeader\").attr(\"placeholder\", \"Mesajınızın Konusu\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox6", "$(\"#txtMessage\").attr(\"placeholder\", \"Mesajınız\");", true);
    //    }
    //    else if (cookie.Value == "en-US")//eng lang
    //    {
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox", "$(\"#txtName\").attr(\"placeholder\", \"Name\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox2", "$(\"#txtSurname\").attr(\"placeholder\", \"Surname\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox3", "$(\"#txtPhone\").attr(\"placeholder\", \"Phone\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox4", "$(\"#txtEmail\").attr(\"placeholder\", \"E-mail\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox5", "$(\"#txtHeader\").attr(\"placeholder\", \"Subject Of Your Message\");", true);
    //        ScriptManager.RegisterStartupScript(this, typeof(Page), "textbox6", "$(\"#txtMessage\").attr(\"placeholder\", \"Your Message\");", true);
    //    }
    //}

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtHeader.Text) && !string.IsNullOrEmpty(txtMessage.Text))
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(GeneralInformation.AuthEmail);
                mail.From = new MailAddress("alkuyonetimpaneli@gmail.com");
                mail.Subject = txtName.Text + " " + txtSurname.Text + " alku.com.tr iletişim formundan bir mesaj gönderdi.";
                mail.Body = "Bilgenesilkoleji.com Web sitesi üzerinden mesaj gönderildi. <br /><br />Adı: " + txtName.Text + " <br />Soyadı: " + txtSurname.Text + "<br />E-mail: " + txtEmail.Text
                    + "<br />Telefon:" + txtPhone.Text + "<br />Mesajın Konusu: " + txtHeader.Text
                    + "<br />Mesaj: " + txtMessage.Text + "<br />Mesaj Gönderim Saati: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                NetworkCredential credentials = new NetworkCredential("alkuyonetimpaneli@gmail.com", "ilker1987124");
                client.Credentials = credentials;

                try
                {
                    client.Send(mail);

                    cContactForm.InsertContactForm(txtName.Text, txtSurname.Text, txtPhone.Text, txtEmail.Text, txtHeader.Text, txtMessage.Text);

                    txtName.Text = string.Empty;
                    txtSurname.Text = string.Empty;
                    txtPhone.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtHeader.Text = string.Empty;
                    txtMessage.Text = string.Empty;

                    ltrPopupHeader.Text = "BAŞARILI!";
                    ltrHeaderText.Text = "Mesaj Gönderildi!";
                    ltrErrorText.Text = "Mesaj Gönderildi. Size en kısa sürede dönüş yapılacaktır!";


                    ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
                }
                catch (Exception ex)
                {
                    ltrPopupHeader.Text = "HATA!";
                    ltrHeaderText.Text = "Mesaj Gönderilemedi!";
                    ltrErrorText.Text = "Mesaj Gönderilemedi. Lütfen tekrar deneyiniz!";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
                }
            }
            catch (Exception ex)
            {
                HttpCookie cookie = Request.Cookies["Language"];
                if (cookie == null)
                {
                    cookie = new HttpCookie("Language");
                    cookie.Value = "tr-TR";
                }
                if (cookie.Value == "tr-TR")//tr lang
                {
                    ltrPopupHeader.Text = "HATA!";
                    ltrHeaderText.Text = "Mesaj Gönderilemedi!";
                    ltrErrorText.Text = "Mesaj Gönderilemedi. Lütfen tekrar deneyiniz!";
                }
                ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
            }
        }
        else
        {

            ltrPopupHeader.Text = "HATA!";
            ltrHeaderText.Text = "Eksik bilgi!";
            ltrErrorText.Text = "Lütfen tüm alanları doldurup tekrar deneyiniz!";

            ScriptManager.RegisterStartupScript(this, typeof(Page), "ShowModal", "$(\"#mdlError\").modal(\"show\");", true);
        }
    }
}