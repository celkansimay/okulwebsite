<%@ Page Title="Etkinlikler | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="Etkinlikler.aspx.cs" Inherits="Etkinlikler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .m-b-20 {
            margin-bottom: 20px;
        }

        .white-text a{
            color:#FFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">ETKİNLİKLER</h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="xs-display-none"></span>
                    <!-- end title tagline -->
                    <div class="separator-line margin-three bg-black no-margin-lr sm-margin-top-three sm-margin-bottom-three no-margin-bottom xs-display-none"></div>
                </div>
                <div class="col-lg-4 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated text-right" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="#">ANASAYFA</a></li>
                        <li><a href="#">ETKİNLİKLER</a></li>

                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>
    <section class="portfolio-short-description no-padding-top">
        <div class="container">
            <div class="row ">
                <asp:Literal runat="server" ID="ltrActivity"></asp:Literal>
                <%--<asp:Repeater runat="server" ID="rptActivity" OnItemDataBound="rptActivity_ItemDataBound">
                    <ItemTemplate>
                        <div class="col-md-12">
                            <div class="portfolio-short-description-bg pull-left" style='background-image:url(<%#Eval("ImageUrl")%>)' runat="server">
                                <a href='<%#Eval("Link") %>'>
                                    <img src='<%#Eval("ImageUrl").ToString().Substring(1) %>' class="img-responsive" />
                                </a>
                                <figure class="pull-right wow fadeInRight animated" style="visibility: visible; animation-name: fadeInRight;">
                                    <figcaption>
                                        <div class="separator-line bg-yellow no-margin-lr margin-ten no-margin-top"></div>
                                        <h3 class="white-text"><a href='EtkinlikDetay/<%#Eval("Id") %>/<%#createLinkText(Eval("Header").ToString()) %>'>
                                            <%#Eval("Header") %>
                                        </a></h3>
                                        <p class="light-gray-text">
                                            <asp:Literal runat="server" ID="ltrArticle"></asp:Literal>
                                        </p>
                                        <a href='EtkinlikDetay/<%#Eval("Id") %>/<%#createLinkText(Eval("Header").ToString()) %>' class="highlight-button-dark btn btn-small button xs-margin-bottom-five">Devamını Oku</a>
                                    </figcaption>
                                </figure>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>--%>
            </div>
        </div>
    </section>
    <script src="assets/js/jquery-2.2.4.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("body").addClass("blog-page");
        });
    </script>
</asp:Content>

