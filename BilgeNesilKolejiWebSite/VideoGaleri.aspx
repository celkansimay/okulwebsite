 <%@ Page Title="Video Galeri | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="VideoGaleri.aspx.cs" Inherits="VideoGaleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        iframe{
            width: 100% !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">VIDEO GALERİ</h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="xs-display-none"></span>
                    <!-- end title tagline -->
                    <div class="separator-line margin-three bg-black no-margin-lr sm-margin-top-three sm-margin-bottom-three no-margin-bottom xs-display-none"></div>
                </div>
                <div class="col-lg-4 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated text-right" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="Anasayfa">ANASAYFA</a></li>
                        <li><a href="#">GALERİ</a></li>
                        <li><a href="#">VIDEO GALERİ</a></li>

                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>
    <!-- content section -->
    <section class="wow fadeIn">
        <div class="container">
            <div class="row">
                    <asp:Repeater runat="server" ID="rptPhotoGallery">
                        <ItemTemplate>
                            <div class="col-md-6 col-sm-12">
                                <%#Eval("Url") %>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                   <%-- <iframe width="560" height="315" src="https://www.youtube.com/embed/6ZHfuEupNdk" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>--%>
                    <%--  <!-- vimeo video -->
                    <iframe src="https://player.vimeo.com/video/99585787?color=bb9b44&title=0&byline=0&portrait=0"height="281"></iframe>
                    <!-- end vimeo video -->--%>
                </div>
        </div>
    </section>
</asp:Content>

