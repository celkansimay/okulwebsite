<%@ page title="Haber Detay | Bilge Nesil Koleji" language="C#" masterpagefile="~/Bottom.master" autoeventwireup="true" inherits="HaberDetay, App_Web_bln2rj34" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">
                        <asp:Literal runat="server" ID="ltrHeader"></asp:Literal>
                        <br />
                        <span class="blog-date">Yazar, <a><%=NewsItem[0].NameSurname %></a>&nbsp;&nbsp;|&nbsp;&nbsp;<%= NewsItem[0].ReleaseDate.ToString("dd/MM/yyyy") %></span>
                    </h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="xs-display-none"></span>
                    <!-- end title tagline -->
                    <div class="separator-line margin-three bg-black no-margin-lr sm-margin-top-three sm-margin-bottom-three no-margin-bottom xs-display-none"></div>
                </div>
                <div class="col-lg-6 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="#">ANASAYFA</a></li>
                        <li><a href="#">HABERLER</a></li>
                        <li><a href="#">
                            <asp:Literal ID="ltrBreadHeader" runat="server"></asp:Literal></a></li>
                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>
    <section class="wow fadeIn animated no-padding-top" style="visibility: visible; animation-name: fadeIn;">
        <div class="container">
            <div class="row">
                <div class="col-md-12">

                    <div class="blog-image margin-eight no-margin">
                        <asp:Image runat="server" class="img-responsive" ID="imgUrl" />
                    </div>
                    <div class="blog-details-text">
                        <p class="text-large">
                            <%=NewsItem[0].Article %>
                        </p>
                    </div>
                </div>
                <%--</ItemTemplate>
                    </asp:Repeater>--%>
            </div>
        </div>


    </section>
</asp:Content>

