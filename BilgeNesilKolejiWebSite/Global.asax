<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        RegisterRoutes(System.Web.Routing.RouteTable.Routes);

        HttpCookie cookie;
        cookie = new HttpCookie("Language");
        cookie.Value = "tr-TR";
    }

    void Application_End(object sender, EventArgs e)
    {

    }

    void Application_BeginRequest(Object sender, EventArgs e)
    {
        HttpCookie cookie = Request.Cookies["Language"];
        if (cookie != null && cookie.Value != null)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(cookie.Value);
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture(cookie.Value);
        }
        else
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
        }
    }

    void Application_Error(object sender, EventArgs e)
    {
        //Response.Redirect("404");
    }

    void Session_Start(object sender, EventArgs e)
    {
    }

    void Session_End(object sender, EventArgs e)
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }

    void RegisterRoutes(System.Web.Routing.RouteCollection Routes)
    {
        Routes.MapPageRoute("Anasayfa", "Anasayfa", "~/Default.aspx");
        Routes.MapPageRoute("Hakkımızda", "Hakkımızda", "~/Hakkimizda.aspx");
        Routes.MapPageRoute("Etkinlikler", "Etkinlikler", "~/Etkinlikler.aspx");
        Routes.MapPageRoute("EtkinlikDetay", "EtkinlikDetay/{Id}/{Header}", "~/EtkinlikDetay.aspx");
        Routes.MapPageRoute("Anaokulu", "Anaokulu", "~/Anaokulu.aspx");
        Routes.MapPageRoute("Ilkokul", "Ilkokul", "~/Ilkokul.aspx");
        Routes.MapPageRoute("Ortaokul", "Ortaokul", "~/Ortaokul.aspx");
        Routes.MapPageRoute("AnadoluLisesi", "AnadoluLisesi", "~/AnadoluLisesi.aspx");
        Routes.MapPageRoute("FenLisesi", "FenLisesi", "~/FenLisesi.aspx");
        Routes.MapPageRoute("FotoGaleri", "FotoGaleri", "~/FotoGaleri.aspx");
        Routes.MapPageRoute("FotoGaleriDetay", "FotoGaleriDetay/{Id}", "~/FotoGaleriDetay.aspx");
        Routes.MapPageRoute("VideoGaleri", "VideoGaleri", "~/VideoGaleri.aspx");
        Routes.MapPageRoute("SinavBasvuru", "SinavBasvuru", "~/SinavBasvuru.aspx");
        Routes.MapPageRoute("ErkenKayit", "ErkenKayit", "~/EarlySaved.aspx");
        //Routes.MapPageRoute("Urun", "Urun-{Id}_{ProductName}", "~/Products.aspx");
        Routes.MapPageRoute("Referanslarımız", "Referanslarımız", "~/References.aspx");
        Routes.MapPageRoute("Blog", "Blog", "~/Blog.aspx");
        Routes.MapPageRoute("BlogDetay", "BlogDetay/{Id}/{Header}", "~/BlogDetail.aspx");
        //Routes.MapPageRoute("BlogDetay", "BlogDetay", "~/BlogDetail.aspx");
        Routes.MapPageRoute("İletişim", "İletişim", "~/Contact.aspx");
        Routes.MapPageRoute("Haberler", "Haberler", "~/Haberler.aspx"); 
        Routes.MapPageRoute("HaberDetay", "HaberDetay/{Id}/{Header}", "~/HaberDetay.aspx");
        Routes.MapPageRoute("DemoFormu", "DemoFormu", "~/DemoFormu.aspx");

        Routes.MapPageRoute("Admin/Anasayfa", "Admin/Anasayfa", "~/Admin/Default.aspx");
        Routes.MapPageRoute("Admin/UyeGirisi", "Admin/UyeGirisi", "~/Admin/Login.aspx");
        Routes.MapPageRoute("Admin/Slider", "Admin/Slider", "~/Admin/SliderList.aspx");
        Routes.MapPageRoute("Admin/SliderEkle", "Admin/SliderEkle", "~/Admin/AddEditSlider.aspx");
        Routes.MapPageRoute("Admin/SliderGüncelle", "Admin/SliderGüncelle-{Id}", "~/Admin/AddEditSlider.aspx");
        Routes.MapPageRoute("Admin/İçerikler", "Admin/İçerikler", "~/Admin/Contents.aspx");
        //Routes.MapPageRoute("Admin/İçerikEkle", "Admin/İçerikEkle", "~/Admin/AddEditContent.aspx");
        Routes.MapPageRoute("Admin/İçerikGüncelle", "Admin/İçerikGüncelle-{Id}", "~/Admin/AddEditContent.aspx");
        Routes.MapPageRoute("Admin/Etkinlikler", "Admin/Etkinlikler", "~/Admin/Activities.aspx");
        Routes.MapPageRoute("Admin/EtkinlikEkle", "Admin/EtkinlikEkle", "~/Admin/AddEditActivity.aspx");
        Routes.MapPageRoute("Admin/EtkinlikGüncelle", "Admin/EtkinlikGüncelle-{Id}", "~/Admin/AddEditActivity.aspx");
        Routes.MapPageRoute("Admin/Haberler", "Admin/Haberler", "~/Admin/Haberler.aspx");
        Routes.MapPageRoute("Admin/HaberEkle", "Admin/HaberEkle", "~/Admin/AddEditNews.aspx");
        Routes.MapPageRoute("Admin/HaberGüncelle", "Admin/HaberGüncelle-{Id}", "~/Admin/AddEditNews.aspx");
        Routes.MapPageRoute("Admin/Ürünler", "Admin/Ürünler", "~/Admin/Products.aspx");
        Routes.MapPageRoute("Admin/ÜrünEkle", "Admin/ÜrünEkle", "~/Admin/AddEditProduct.aspx");
        Routes.MapPageRoute("Admin/ÜrünGüncelle", "Admin/ÜrünGüncelle-{Id}", "~/Admin/AddEditProduct.aspx");
        Routes.MapPageRoute("Admin/Yazılar", "Admin/Yazılar", "~/Admin/BlogPosts.aspx");
        Routes.MapPageRoute("Admin/YazıEkle", "Admin/YazıEkle", "~/Admin/AddEditBlogPosts.aspx");
        Routes.MapPageRoute("Admin/YazıGüncelle", "Admin/YazıGüncelle-{Id}", "~/Admin/AddEditBlogPosts.aspx");
        Routes.MapPageRoute("Admin/Ayarlar", "Admin/Ayarlar", "~/Admin/GeneralInformation.aspx");
        Routes.MapPageRoute("Admin/GelenMesajlar", "Admin/GelenMesajlar", "~/Admin/Messages.aspx");
        Routes.MapPageRoute("Admin/MesajOku", "Admin/MesajOku-{Id}", "~/Admin/ReadMessages.aspx");
        Routes.MapPageRoute("Admin/404", "Admin/404", "~/Admin/404.aspx");
        Routes.MapPageRoute("Admin/ÇıkışYap", "Admin/ÇıkışYap", "~/Admin/LogOut.aspx");
        Routes.MapPageRoute("Admin/Kullanıcılar", "Admin/Kullanıcılar", "~/Admin/Users.aspx");
        Routes.MapPageRoute("Admin/KullanıcıEkle", "Admin/KullanıcıEkle", "~/Admin/AddEditUsers.aspx");
        Routes.MapPageRoute("Admin/KullanıcıGüncelle", "Admin/KullanıcıGüncelle-{Id}", "~/Admin/AddEditUsers.aspx");
        Routes.MapPageRoute("Admin/DemoFormları", "Admin/DemoFormları", "~/Admin/DemoForms.aspx");
        Routes.MapPageRoute("Admin/DemoFormDetay", "Admin/DemoFormDetay-{Id}", "~/Admin/DemoFormDetail.aspx");
        Routes.MapPageRoute("Admin/Fotoğraflar", "Admin/Fotoğraflar", "~/Admin/Galeri.aspx");
        Routes.MapPageRoute("Admin/FotoğrafGüncelle", "Admin/FotoğrafGüncelle-{Id}", "~/Admin/AddEditSGallery.aspx");
        Routes.MapPageRoute("Admin/GaleriDetay", "Admin/GaleriDetay-{GalleryId}", "~/Admin/GaleriDetay.aspx");
        Routes.MapPageRoute("Admin/GaleriDetayDuzenle", "Admin/GaleriDetayDuzenle-{GalleryId}-{Id}", "~/Admin/GaleriDetay.aspx");
        Routes.MapPageRoute("Admin/VideoGaleri", "Admin/VideoGaleri", "~/Admin/VideoGaleri.aspx");

        Routes.MapPageRoute("404", "404", "~/404.aspx");
    }

</script>
