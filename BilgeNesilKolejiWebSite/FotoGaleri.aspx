<%@ Page Title="Fotoğraf Galerisi | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="FotoGaleri.aspx.cs" Inherits="FotoGaleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .pt-20{
            padding-top:30px !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">FOTO GALERİ</h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="xs-display-none"></span>
                    <!-- end title tagline -->
                    <div class="separator-line margin-three bg-black no-margin-lr sm-margin-top-three sm-margin-bottom-three no-margin-bottom xs-display-none"></div>
                </div>
                <div class="col-lg-4 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="Anasayfa">ANASAYFA</a></li>
                        <li><a href="#">GALERİ</a></li>
                        <li><a href="#">FOTO GALERİ</a></li>
                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>

    <section class="work-4col masonry wide no-margin-top content-section container pt-20">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-12 grid-gallery overflow-hidden no-padding">
                    <div class="tab-content">
                        <!-- work grid -->

                        <asp:Repeater runat="server" ID="rptPhotoGallery" OnItemDataBound="rptPhotoGallery_ItemDataBound">
                            <HeaderTemplate>
                                <ul class="grid masonry-items" style="position: relative; height: 894px;">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <!-- work item ( external page ) -->
                                <li style="position: absolute; left: 0px; top: 0px;">
                                    <figure>
                                        <div class="gallery-img">
                                            <a href='FotoGaleriDetay/<%#Eval("Id") %>'>
                                                <img src='<%#Eval("Url").ToString().Substring(1) %>' alt=""></a>
                                        </div>
                                        <figcaption>
                                            <i class="icon-attachment"></i>
                                            <h3><%#Eval("Header") %></h3>
                                            <%--<p>External Page</p>--%>
                                        </figcaption>
                                    </figure>
                                </li>
                            </ItemTemplate>
                            <FooterTemplate>
                                </ul>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>

                </div>
            </div>
        </div>
    </section>
</asp:Content>

