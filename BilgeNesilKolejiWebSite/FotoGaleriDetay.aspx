<%@ Page Title="Fotoğraf Galerisi Detay | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="FotoGaleriDetay.aspx.cs" Inherits="FotoGaleriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- head section -->
    <section class="page-title parallax3 parallax-fix page-title-large">
        <div class="opacity-medium bg-gray"></div>
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-7 col-sm-12 wow fadeInUp animated animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">
                        <asp:Literal runat="server" ID="ltrGalleryName"></asp:Literal></h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="xs-display-none"></span>
                    <!-- end title tagline -->
                    <div class="separator-line margin-three bg-black no-margin-lr sm-margin-top-three sm-margin-bottom-three no-margin-bottom xs-display-none"></div>
                </div>
                <div class="col-lg-4 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated animated" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="Anasayfa">ANASAYFA</a></li>
                        <li><a href="#">GALERİ</a></li>
                        <li><a href="#">FOTO GALERİ DETAY</a></li>

                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>
    <!-- end head section -->

    <section class="wow fadeIn animated" style="visibility: visible; animation-name: fadeIn;">
        <div class="container">
            <div class="row lightbox-gallery ">
                <asp:Repeater runat="server" ID="rptPhotoGallery">
                    <ItemTemplate>
                        <%-- <div class="col-md-4 col-sm-6 wow fadeIn animated" style="visibility: visible; animation-name: fadeIn;">
                            <!-- photo item -->
                            <a href="images\fashion-photoshots04.jpg">
                                <img src="images\fashion-photoshots04.jpg" alt="" class="project-img-gallery"></a>
                            <!-- end photo item -->
                        </div>--%>

                        <div class="col-md-4 col-sm-6 wow fadeIn animated" style="visibility: visible; animation-name: fadeIn;">
                            <!-- photo item -->
                            <a href='<%#Eval("ImgUrl").ToString().Substring(1) %>'>
                                <img src='<%#Eval("ImgUrl").ToString().Substring(1) %>' alt="" class="project-img-gallery"></a>
                            <!-- end photo item -->
                        </div>
                    </ItemTemplate>

                </asp:Repeater>
            </div>
        </div>
    </section>
    <!-- portfolio section -->

</asp:Content>
