<%@ page title="İlkokul | Bilge Nesil Koleji" language="C#" masterpagefile="~/Bottom.master" autoeventwireup="true" inherits="Ilkokul, App_Web_bln2rj34" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">
                        <asp:Literal runat="server" ID="ltrHeader1"></asp:Literal></h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="xs-display-none"></span>
                    <!-- end title tagline -->
                    <div class="separator-line margin-three bg-black no-margin-lr sm-margin-top-three sm-margin-bottom-three no-margin-bottom xs-display-none"></div>
                </div>
                <div class="col-lg-4 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="#">ANASAYFA</a></li>
                        <li><a href="#">EĞİTİM PLANLARI</a></li>
                        <li><a href="#">
                            <asp:Literal runat="server" ID="ltrBreadHeader1"></asp:Literal></a></li>

                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>
    <section class="no-padding-top bg-white">
        <div class="container">
            <div class="row">
                <asp:Image runat="server" ID="ImageIlkokul" CssClass="img-responsive" />
                <div class="col-md-12 col-sm-12 pull-left sm-margin-bottom-eight wow fadeInUp" data-wow-duration="300ms">
                    <h6 class="margin-three"><strong class="black-text">
                        <asp:Literal runat="server" ID="ltrHeader"></asp:Literal></strong></h6>
                    <p class="margin-right-seven no-margin-bottom">
                        <asp:Literal runat="server" ID="ltrContent1"></asp:Literal>
                    </p>
                </div>
            </div>
        </div>
    </section>
    <!-- end project description section -->
</asp:Content>

