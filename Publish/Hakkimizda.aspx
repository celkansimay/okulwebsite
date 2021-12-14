<%@ page title="" language="C#" masterpagefile="~/Bottom.master" autoeventwireup="true" inherits="Hakkimizda, App_Web_bln2rj34" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- head section -->
    <section class="content-top-margin page-title-small border-bottom-light border-top-light">
        <div class="container">
            <div class="row">
                <div class="col-md-8 col-sm-12 wow fadeInUp" data-wow-duration="300ms">
                    <!-- page title -->
                    <h1 class="black-text">
                        <asp:Literal runat="server" ID="ltrHeader"></asp:Literal></h1>
                    <!-- end page title -->
                </div>
                <div class="col-md-4 col-sm-12 breadcrumb text-uppercase wow fadeInUp xs-display-none" data-wow-duration="600ms">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="#">ANASAYFA</a></li>
                        <li>HAKKIMIZDA</li>
                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>
    <!-- end head section -->
    <!-- content section -->
    <section class="wow fadeIn cover-background" style="background-image: url('assets/images/slider1.jpg');">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-sm-8">
                    <div class="separator-line bg-yellow no-margin-lr no-margin-top"></div>
                    <div class="white-text slider-subtitle1 bg-inherit no-margin text-left no-padding">
                        <asp:Literal runat="server" ID="ltrHeader1"></asp:Literal>
                    </div>

                </div>
            </div>
        </div>
    </section>
    <section class="border-bottom-light sm-text-center">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <p class="title-small font-weight-300">
                        <span style="padding: 20px;">
                            <asp:Image runat="server" ID="Image" CssClass="img-responsive" />
                        </span>
                        <asp:Literal runat="server" ID="ltrcContent1"></asp:Literal>
                    </p>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

