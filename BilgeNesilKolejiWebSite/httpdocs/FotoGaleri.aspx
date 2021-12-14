<%@ Page Title="Fotoğraf Galerisi | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Default.master" AutoEventWireup="true" CodeFile="FotoGaleri.aspx.cs" Inherits="FotoGaleri" %>

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
            <div class="row ">
                <asp:Repeater runat="server" ID="rptPhotoGallery" OnItemDataBound="rptPhotoGallery_ItemDataBound">
                    <ItemTemplate>
                        <div class="col-md-4 col-sm-6">
                            <!-- photo item -->
                            <h2><a href='FotoGaleriDetay/<%#Eval("Id") %>'>
                                <%#Eval("Header") %>
                            </a></h2>
                            <a href='/FotoGaleriDetay/<%#Eval("Id") %>'>
                                <img src='<%#Eval("Url").ToString().Substring(1) %>' alt="" class="project-img-gallery"></a>
                            <!-- end photo item -->
                        </div>
                    </ItemTemplate>

                </asp:Repeater>
            </div>
        </div>
    </section>
    <!-- portfolio section -->


</asp:Content>

