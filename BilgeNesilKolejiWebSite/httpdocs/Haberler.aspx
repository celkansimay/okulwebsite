<%@ Page Title="Haberler | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="Haberler.aspx.cs" Inherits="Haberler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">HABERLER</h1>
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
                        <li><a href="#">HABERLER</a></li>

                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>


    <section class="wow fadeIn animated no-padding-top" style="visibility: visible; animation-name: fadeIn;">
        <div class="container">
            <div class="row blog-2col">
                <asp:Repeater runat="server" ID="rptBlog" OnItemDataBound="rptNews_ItemDataBound">
                    <ItemTemplate>
                        <!-- post item -->
                        <div class="col-md-6 col-sm-6 col-xs-6 blog-listing wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                            <div class="blog-image">
                                <a href='<%#Eval("Link") %>'>
                                    <asp:Image runat="server" class="img-responsive" ID="img1" ImageUrl='<%#Eval("ImageUrl") %>' />
                                </a>
                            </div>
                            <div class="blog-details">
                                <div class="blog-date">Yazar, <a href="blog-masonry-2columns.html"><%#Eval("NameSurname") %></a>&nbsp;&nbsp;|&nbsp;&nbsp;<%#DateTime.Parse(Eval("ReleaseDate").ToString()).ToString("dd MMM yyyy") %></div>
                                <div class="blog-title">
                                    <a href='HaberDetay/<%#Eval("Id") %>/<%#createLinkText(Eval("Header").ToString()) %>'>
                                        <%#Eval("Header") %>
                                    </a>
                                </div>
                                <div class="blog-short-description">
                                    <asp:Literal runat="server" ID="ltrArticle"></asp:Literal></p>
                                <div class="separator-line bg-black no-margin-lr"></div>
                                    <a href='HaberDetay/<%#Eval("Id") %>/<%#createLinkText(Eval("Header").ToString()) %>' class="highlight-button-dark btn btn-small button xs-margin-bottom-five">Devamını Oku</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>

    <%--<!-- pagination  -->
    <section class="">
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-sm-12 col-xs-12 wow fadeInUp">
                    <div class="pagination no-margin">
                        <a href="#">
                            <img src="images\arrow-pre-small.png" alt=""></a>
                        <a href="#"class="active">1</a>
                        <a href="#">2</a>
                        <a href="#" >3</a>
                        <a href="#">4</a>
                        <a href="#">5</a>
                        <a href="#">
                            <img src="images\arrow-next-small.png" alt=""></a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- end pagination  -->--%>
    <script src="assets/js/jquery-2.2.4.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("body").addClass("blog-page");
        });
    </script>
</asp:Content>

