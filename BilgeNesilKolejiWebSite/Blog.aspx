<%@ Page Title="Blog | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="Blog.aspx.cs" Inherits="Blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">BLOG</h1>
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
                        <li><a href="#">BLOG</a></li>

                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>

    <section class="wow fadeIn animated no-padding-top" style="visibility: visible; animation-name: fadeIn;">
        <div class="container">
            <div class="row blog-2col">
                <asp:Repeater runat="server" ID="rptBlog" OnItemDataBound="rptBlog_ItemDataBound">
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
                                    <a href='BlogDetay/<%#Eval("Id") %>/<%#createLinkText(Eval("Header").ToString()) %>'>
                                        <%#Eval("Header") %>
                                    </a>
                                </div>
                                <div class="blog-short-description">
                                    <asp:Literal runat="server" ID="ltrArticle"></asp:Literal></p>
                                <div class="separator-line bg-black no-margin-lr"></div>
                                    <a href='BlogDetay/<%#Eval("Id") %>/<%#createLinkText(Eval("Header").ToString()) %>' class="highlight-button-dark btn btn-small button xs-margin-bottom-five">Devamını Oku</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </section>
    <%--    <section id="blog" class="wow fadeIn bg-light-gray blog-post-style5">
        <div class="container-fluid padding-six-lr md-padding-15px-lr">
            <div class="row">
                <div class="col-12 px-3 p-md-0">
                    <ul class="blog-grid blog-5col gutter-large">
                        <li class="grid-sizer"></li>
                        <!-- start post item -->
                        <asp:ListView runat="server" ID="lvBlogs" OnItemDataBound="lvBlogs_ItemDataBound">
                            <ItemTemplate>
                                <li class="grid-item wow fadeInUp last-paragraph-no-margin">
                                    <div class="blog-post">
                                        <div class="blog-post-images overflow-hidden">
                                            <a href='<%#Eval("Link") %>'>
                                                <asp:Image runat="server" class="img-responsive" ID="img1" ImageUrl='<%#Eval("ImageUrl") %>' />
                                            </a>

                                        </div>
                                        <div class="post-details padding-40px-all bg-white md-padding-20px-all">
                                            <div class="blog-hover-color"></div>
                                            <a href='<%#Eval("Link") %>' class="alt-font post-title text-medium text-extra-dark-gray width-90 d-block lg-width-100 margin-5px-bottom">
                                                <asp:Literal runat="server" ID="ltrHeader"></asp:Literal></a>
                                            <div class="author">
                                                <span class="text-medium-gray text-uppercase text-extra-small d-inline-block"><a href="blog-grid.html" class="text-medium-gray"><%#Eval("NameSurname") %></a>&nbsp;&nbsp;|&nbsp;&nbsp;<%#DateTime.Parse(Eval("ReleaseDate").ToString()).ToString("dd MMM yyyy") %></span>
                                            </div>
                                            <div class="separator-line-horrizontal-full bg-medium-gray margin-seven-tb lg-margin-four-tb"></div>
                                            <p>
                                                <asp:Literal runat="server" ID="ltrArticle"></asp:Literal>
                                            </p>
                                            <asp:Literal runat="server" ID="ltrReadMore"></asp:Literal>
                                        </div>
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:ListView>
                        <!-- end post item -->
                    </ul>
                </div>
            </div>
            <!-- start slider pagination -->
            <div class=" text-center margin-100px-top md-margin-50px-top wow fadeInUp">
                <div class="pagination text-small text-uppercase text-extra-dark-gray">
                    <ul class="mx-auto">
                        <asp:DataPager ID="lvDataPager1" runat="server" PagedControlID="lvBlogs" PageSize="4">
                            <Fields>
                                <%-- <asp:TemplatePagerField>
                                <PagerTemplate>
                                    <b>
                                        <asp:Label runat="server" ID="TotalPagesLabel" Text="<%# Math.Ceiling ((double)Container.TotalRowCount / Container.PageSize) %>" />
                                        Sayfadan
                                                <asp:Label runat="server" ID="CurrentPageLabel" Text="<%# Container.TotalRowCount>0 ? (Container.StartRowIndex / Container.PageSize) + 1 : 0 %>" />. sayfa
                                    </b>
                                    <br />
                                    <br />
                                </PagerTemplate>
                            </asp:TemplatePagerField>--%>
    <%--<asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="btn-pager-text" ShowLastPageButton="false" PreviousPageText='<i class="fas fa-long-arrow-alt-left margin-5px-right d-none d-md-inline-block"></i>' FirstPageText="<<" ShowFirstPageButton="false" ShowPreviousPageButton="true" ShowNextPageButton="false" />

                                <asp:NextPreviousPagerField ButtonType="Link" ButtonCssClass="btn-pager-text" ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="false" NextPageText='<i class="fas fa-long-arrow-alt-right margin-5px-left d-none d-md-inline-block"></i>' />
                            </Fields>
                        </asp:DataPager>
                    </ul>
                </div>
            </div>
            <!-- end slider pagination -->
        </div>
    </section>
    <!-- end post content -->
    <script src="assets/js/jquery-2.2.4.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("body").addClass("blog-page");
        });
    </script>--%>

</asp:Content>

