<%@ page title="Anasayfa | Bilge Nesil Koleji" language="C#" masterpagefile="~/Default.master" autoeventwireup="true" inherits="_Default, App_Web_bln2rj34" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!-- slider -->
    <section id="slider" class="no-padding">
        <div id="owl-demo" class="owl-carousel owl-theme light-pagination square-pagination dark-pagination-without-next-prev-arrow main-slider">
            <asp:Literal runat="server" ID="ltrSlider"></asp:Literal>
            <%--<asp:Repeater runat="server" ID="rptSlider">
                <ItemTemplate>
                    <div class="item owl-bg-img" style='background-image: url(Assets/images/kapak2.jpg);'>
                        <div class="opacity-full bg-dark-gray"></div>
                        <div class="container full-screen position-relative">
                            <div class="slider-typography text-center">
                                <div class="slider-text-middle-main">
                                    <div class="slider-text-middle slider-text-middle6 padding-left-right-px wow fadeInUp">
                                        <span class="slider-title-big6 white-text text-uppercase font-weight-600 letter-spacing-1">
                                           <%#Eval("Header") %></span>
                                        <span class="white-text text-med  letter-spacing-3 margin-three no-margin-bottom display-block xs-letter-spacing-6">
                                            <%#Eval("Description") %></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <%--<!-- slider item -->
            <div class="item owl-bg-img" style="background-image: url('Assets/images/kapak2.jpg');">
                <div class="opacity-full bg-dark-gray"></div>
                <div class="container full-screen position-relative">
                    <div class="slider-typography text-center">
                        <div class="slider-text-middle-main">
                            <div class="slider-text-middle slider-text-middle6 padding-left-right-px wow fadeInUp">
                                <span class="slider-title-big6 white-text text-uppercase font-weight-600 letter-spacing-1">
                                    <asp:Literal runat="server" ID="sliderText1"></asp:Literal></span>
                                <span class="white-text text-small text-uppercase letter-spacing-10 margin-three no-margin-bottom display-block xs-letter-spacing-6">
                                    <asp:Literal runat="server" ID="sliderDesc1"></asp:Literal></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- end slider item -->
            <!-- slider item -->
            <div class="item owl-bg-img" style="background-image: url('Assets/images/kapak1.jpg');">
                <div class="opacity-full bg-dark-gray"></div>
                <div class="container full-screen position-relative">
                    <div class="slider-typography text-center">
                        <div class="slider-text-middle-main">
                            <div class="slider-text-middle slider-text-middle6 padding-left-right-px wow fadeInUp">
                                <span class="slider-title-big6 white-text text-uppercase font-weight-700 letter-spacing-3">
                                    <asp:Literal runat="server" ID="sliderText2"></asp:Literal></span>
                                <span class="white-text text-small text-uppercase letter-spacing-10 margin-three no-margin-bottom display-block">
                                    <asp:Literal runat="server" ID="sliderDesc2"></asp:Literal></span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- end slider item -->--%>--%>

        </div>
    </section>
    <!-- end slider -->
    <!-- services section -->
    <section class="corporate-standards no-padding-bottom wow fadeIn">
        <div class="container">
            <div class="row">
                <!-- section title -->
                <div class="col-md-12 text-center">
                    <h3 class="section-title no-padding-bottom">EĞİTİM PLANLARIMIZ</h3>
                </div>
                <!-- end section title -->
            </div>
        </div>
        <div class="container-fluid margin-five no-margin-bottom no-padding">
            <div class="row no-margin">
                <!-- tab -->
                <div class="col-md-12 col-sm-12 center-col text-center no-padding" id="animated-tab">
                    <!-- tab navigation -->
                    <ul class="nav nav-tabs margin-five no-margin-top xs-margin-bottom-seven">
                        <li class="nav active"><a href="#tab6_sec1" data-toggle="tab" class="xs-min-height-inherit xs-no-padding"><span><i class="icon-scissors"></i></span></a>
                            <br>
                            <span class="text-small text-uppercase letter-spacing-3 margin-five font-weight-600 xs-letter-spacing-none xs-display-none">Anaokulu</span></li>
                        <li class="nav"><a href="#tab6_sec2" data-toggle="tab" class="xs-min-height-inherit xs-no-padding"><span><i class="icon-tools"></i></span></a>
                            <br>
                            <span class="text-small text-uppercase letter-spacing-3 margin-five font-weight-600 xs-letter-spacing-none xs-display-none">İlkokul</span></li>
                        <li class="nav"><a href="#tab6_sec3" data-toggle="tab" class="xs-min-height-inherit xs-no-padding"><span><i class="icon-mobile"></i></span></a>
                            <br>
                            <span class="text-small text-uppercase letter-spacing-3 margin-five font-weight-600 xs-letter-spacing-none xs-display-none">Ortaokul</span></li>
                        <li class="nav"><a href="#tab6_sec4" data-toggle="tab" class="xs-min-height-inherit xs-no-padding"><span><i class="icon-pencil"></i></span></a>
                            <br>
                            <span class="text-small text-uppercase letter-spacing-3 margin-five font-weight-600 xs-letter-spacing-none xs-display-none">Anadolu Lisesi</span></li>
                        <li class="nav"><a href="#tab6_sec5" data-toggle="tab" class="xs-min-height-inherit xs-no-padding"><span><i class="icon-magnifying-glass"></i></span></a>
                            <br>
                            <span class="text-small text-uppercase letter-spacing-3 margin-five font-weight-600 xs-letter-spacing-none xs-display-none">Fen Lisesi</span></li>
                    </ul>
                    <!-- end tab navigation -->
                    <!-- tab content section -->
                    <div class="tab-content">
                        <!-- tab content -->
                        <div id="tab6_sec1" class="text-center center-col tab-pane fade in active">
                            <div class="tab-pane fade in">
                                <div class="col-lg-6 col-md-6 no-padding corporate-standards-img cover-background position-relative" style="background-image: url('Assets/images/anaokuluanasayfa.jpg');">
                                    <div class="opacity-medium bg-dark-gray"></div>
                                    <p class="title-small text-uppercase corporate-standards-title white-text letter-spacing-7">
                                        <span class="title-extra-large no-letter-spacing yellow-text"></span>
                                        <br>
                                        Anaokulu
                                    </p>
                                </div>
                                <div class="col-lg-6 col-md-6 corporate-standards-text sm-margin-lr-four sm-margin-top-four xs-padding-tb-ten">
                                    <div class="img-border-small-fix border-gray"></div>
                                    <i class="icon-tools large-icon yellow-text"></i>
                                    <h1 class="margin-ten no-margin-bottom">ANAOKULU</h1>
                                    <p class="text-med margin-ten width-80 center-col xs-width-100">Anaokullarımızda öğrencilerimiz yaparak ve yaşayarak öğrenirler.</p>
                                    <a class="text-small highlight-link text-uppercase bg-black white-text" href="Anaokulu.aspx">Devamı.. <i class="fa fa-long-arrow-right extra-small-icon white-text"></i></a>
                                </div>
                            </div>
                        </div>
                        <!-- end tab content -->
                        <!-- tab content -->
                        <div id="tab6_sec2" class="text-center center-col tab-pane fade in">
                            <div class="tab-pane fade in">
                                <div class="col-lg-6 col-md-6 no-padding corporate-standards-img cover-background position-relative" style="background-image: url('Assets/images/ilkokul.jpg');">
                                    <div class="opacity-medium bg-dark-gray"></div>
                                    <p class="title-small text-uppercase corporate-standards-title white-text letter-spacing-7">
                                        <span class="title-extra-large no-letter-spacing yellow-text"></span>
                                        <br>
                                        İlkokul
                                    </p>
                                </div>
                                <div class="col-lg-6 col-md-6 corporate-standards-text sm-margin-lr-four sm-margin-top-four xs-padding-tb-ten">
                                    <div class="img-border-small-fix border-gray"></div>
                                    <i class="icon-tools large-icon yellow-text"></i>
                                    <h1 class="margin-ten no-margin-bottom">İlkokul</h1>
                                    <p class="text-med margin-ten width-80 center-col">Ortaokul için gerekli olan akademik altyapıya sahip olurlar.</p>
                                    <a class="text-small highlight-link text-uppercase bg-black white-text" href="Ilkokul.aspx">Devamı.. <i class="fa fa-long-arrow-right extra-small-icon white-text"></i></a>
                                </div>
                            </div>
                        </div>
                        <!-- end tab content -->
                        <!-- tab content -->
                        <div id="tab6_sec3" class="text-center center-col tab-pane fade in">
                            <div class="tab-pane fade in">
                                <div class="col-lg-6 col-md-6 no-padding corporate-standards-img cover-background position-relative" style="background-image: url('Assets/images/ortaokulanasayfa.jpg');">
                                    <div class="opacity-medium bg-dark-gray"></div>
                                    <p class="title-small text-uppercase corporate-standards-title white-text letter-spacing-7">
                                        <span class="title-extra-large no-letter-spacing yellow-text"></span>
                                        <br>
                                        Ortaokul
                                    </p>
                                </div>
                                <div class="col-lg-6 col-md-6 corporate-standards-text sm-margin-lr-four sm-margin-top-four xs-padding-tb-ten">
                                    <div class="img-border-small-fix border-gray"></div>
                                    <i class="icon-tools large-icon yellow-text"></i>
                                    <h1 class="margin-ten no-margin-bottom">Ortaokul</h1>
                                    <p class="text-med margin-ten width-80 center-col">Tam Öğrenme Modeli ile temel bilimlerde altyapısı güçlü bireyler olarak yetişirler.</p>
                                    <a class="text-small highlight-link text-uppercase bg-black white-text" href="Ortaokul.aspx">Devamı.. <i class="fa fa-long-arrow-right extra-small-icon white-text"></i></a>
                                </div>
                            </div>
                        </div>
                        <!-- end tab content -->
                        <!-- tab content -->
                        <div id="tab6_sec4" class="text-center center-col tab-pane fade in">
                            <div class="tab-pane fade in">
                                <div class="col-lg-6 col-md-6 no-padding corporate-standards-img cover-background position-relative" style="background-image: url('Assets/images/anadolulisesi.jpg');">
                                    <div class="opacity-medium bg-dark-gray"></div>
                                    <p class="title-small text-uppercase corporate-standards-title white-text letter-spacing-7">
                                        <span class="title-extra-large no-letter-spacing yellow-text"></span>
                                        <br>
                                        Anadolu Lisesi
                                    </p>
                                </div>
                                <div class="col-lg-6 col-md-6 corporate-standards-text sm-margin-lr-four sm-margin-top-four xs-padding-tb-ten">
                                    <div class="img-border-small-fix border-gray"></div>
                                    <i class="icon-tools large-icon yellow-text"></i>
                                    <h1 class="margin-ten no-margin-bottom">Anadolu Lisesi</h1>
                                    <p class="text-med margin-ten width-80 center-col">Liselerimizde öğrencilerin bir ya da bir kısmı değil, hepsi üniversiteye gider.</p>
                                    <a class="text-small highlight-link text-uppercase bg-black white-text" href="AnadoluLisesi.aspx">Devamı.. <i class="fa fa-long-arrow-right extra-small-icon white-text"></i></a>
                                </div>
                            </div>
                        </div>
                        <!-- end tab content -->
                        <!-- tab content -->
                        <div id="tab6_sec5" class="text-center center-col tab-pane fade in">
                            <div class="tab-pane fade in">
                                <div class="col-lg-6 col-md-6 no-padding corporate-standards-img cover-background position-relative" style="background-image: url('Assets/images/fenlisesi.jpg');">
                                    <div class="opacity-medium bg-dark-gray"></div>
                                    <p class="title-small text-uppercase corporate-standards-title white-text letter-spacing-7">
                                        <span class="title-extra-large no-letter-spacing yellow-text"></span>
                                        <br>
                                        Fen Lisesi
                                    </p>
                                </div>
                                <div class="col-lg-6 col-md-6 corporate-standards-text sm-margin-lr-four sm-margin-top-four xs-padding-tb-ten">
                                    <div class="img-border-small-fix border-gray"></div>
                                    <i class="icon-tools large-icon yellow-text"></i>
                                    <h1 class="margin-ten no-margin-bottom">Fen Lisesi</h1>
                                    <p class="text-med margin-ten width-80 center-col">Liselerimizde öğrencilerin bir ya da bir kısmı değil, hepsi üniversiteye gider.</p>
                                    <a class="text-small highlight-link text-uppercase bg-black white-text" href="FenLisesi.aspx">Devamı.. <i class="fa fa-long-arrow-right extra-small-icon white-text"></i></a>
                                </div>
                            </div>
                        </div>
                        <!-- end tab content -->
                    </div>
                    <!-- end tab content section -->
                </div>
                <!-- end tab -->
            </div>
        </div>
    </section>
    <!-- end services section -->
    <!-- highlight section -->
    <section class="bg-fast-yellow no-padding wow fadeInUp">
        <div class="container">
            <div class="row padding-five sm-text-center">
                <div class="col-md-1">
                    <i class=""></i>
                </div>
                <div class="col-md-6 no-padding">
                    <span class="text-med text-uppercase letter-spacing-2 margin-two black-text font-weight-600 xs-margin-top-six xs-margin-bottom-six display-block">Bilge Nesil Kolejine Kayıt Olmak İçin</span>
                </div>
                <div class="col-md-5 no-padding">
                    <a class="highlight-button-dark btn btn-medium button xs-margin-bottom-five xs-no-margin-right" href="ErkenKayit">Erken Kayıt</a>
                    <a class="highlight-button btn btn-medium button xs-margin-bottom-five xs-no-margin-right" href="SinavBasvuru">Sınav Başvuru</a>
                </div>
            </div>
        </div>
    </section>
    <!-- end highlight section -->
    <!-- features section -->
    <section id="features" class="features wow fadeIn padding-bottom-0">
        <div class="container">
            <div class="row">
                <!-- section title -->
                <div class="col-md-12 text-center">
                    <h3 class="section-title">NEDEN BİLGE NESİL KOLEJİ ?
                    </h3>
                </div>
                <!-- end section title -->
            </div>
            <div class="row">
                <div class="col-md-4 col-sm-12">
                    <!-- features item -->
                    <div class="features-section col-md-12 col-sm-6 no-padding wow fadeInUp">
                        <div class="col-md-3 col-sm-2 col-xs-2 no-padding"><i class="icon-desktop medium-icon"></i></div>
                        <div class="col-md-9 col-sm-9 col-xs-9 no-padding text-left f-right">
                            <h3>
                                <asp:Literal runat="server" ID="ltrHeader"></asp:Literal></h3>
                            <div class="separator-line bg-yellow"></div>
                            <p>
                                <asp:Literal runat="server" ID="ltrContent1"></asp:Literal>
                            </p>
                        </div>
                    </div>
                    <!-- end features item -->
                </div>
                <div class="col-md-4 col-sm-12">
                    <!-- features item -->
                    <div class="features-section col-md-12 col-sm-6 no-padding wow fadeInUp">
                        <div class="col-md-3 col-sm-2 col-xs-2 no-padding"><i class="icon-trophy medium-icon"></i></div>
                        <div class="col-md-9 col-sm-9 col-xs-9 no-padding text-left f-right">
                            <h3>
                                <asp:Literal runat="server" ID="ltrHeader2"></asp:Literal></h3>
                            <div class="separator-line bg-yellow"></div>
                            <p>
                                <asp:Literal runat="server" ID="ltrContent2"></asp:Literal>
                            </p>
                        </div>
                    </div>
                    <!-- end features item -->

                </div>
                <div class="col-md-4 col-sm-12">
                    <!-- features item -->
                    <div class="features-section col-md-12 col-sm-6 no-padding wow fadeInUp">
                        <div class="col-md-3 col-sm-2 col-xs-2 no-padding"><i class="icon-hotairballoon medium-icon"></i></div>
                        <div class="col-md-9 col-sm-9 col-xs-9 no-padding text-left f-right">
                            <h3>
                                <asp:Literal runat="server" ID="ltrHeader3"></asp:Literal></h3>
                            <div class="separator-line bg-yellow"></div>
                            <p>
                                <asp:Literal runat="server" ID="ltrContent3"></asp:Literal>
                            </p>
                        </div>
                    </div>
                    <!-- end features item -->

                </div>
            </div>
        </div>
    </section>
    <!-- end features section -->

    <!-- blog section -->
    <section id="blog" class="wow fadeIn padding-top-0">
        <div class="container">
            <div class="row">
                <!-- section title -->
                <div class="col-md-12 text-center">
                    <h3 class="section-title">TÜM YAZILAR</h3>
                </div>
                <!-- end section title -->
            </div>
            <div class="row">
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
            <!-- end blog item -->
            <div class="row">
                <div class="col-md-12 text-center wow fadeInUp" data-wow-duration="1200ms">
                    <a class="btn btn-black btn-small margin-four no-margin-bottom" href="Blog">TÜMÜNÜ GÖR</a>
                </div>
            </div>
        </div>
    </section>
    <!-- end blog section -->
</asp:Content>

