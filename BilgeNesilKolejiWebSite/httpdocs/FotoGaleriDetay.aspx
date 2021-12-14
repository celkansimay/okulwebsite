<%@ Page Title="Fotoğraf Galerisi Detay | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="FotoGaleriDetay.aspx.cs" Inherits="FotoGaleriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- head section -->
    <section class="page-title parallax3 parallax-fix page-title-large">
        <div class="opacity-medium bg-black"></div>
        <img class="parallax-background-img" src="assets/images/resim1.png" alt="">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-sm-12 text-center animated fadeInUp">
                    <div class="separator-line bg-yellow no-margin-top margin-four"></div>
                    <!-- page title -->
                    <h1 class="white-text">FOTOĞRAF GALERİSİ</h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="white-text"></span>
                    <!-- end title tagline -->
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
