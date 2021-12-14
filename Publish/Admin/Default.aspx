<%@ page title="" language="C#" masterpagefile="~/Admin/MasterPage.master" autoeventwireup="true" inherits="Admin_Default, App_Web_jw0yzfwl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- begin breadcrumb -->
    <ol class="breadcrumb pull-right">
        <li class="breadcrumb-item active">Anasayfa</li>
    </ol>
    <!-- end breadcrumb -->
    <!-- begin page-header -->
    <h1 class="page-header">
        <asp:Literal runat="server" ID="ltrBranchName"></asp:Literal>
        <small>Alku Admin v3.0</small></h1>
    <!-- end page-header -->

    <!-- begin row -->
    <div class="row">
        <!-- begin col-3 -->
        <div class="col-lg-3 col-md-6">
            <div class="widget widget-stats bg-green">
                <div class="stats-icon"><i class="fa fa-file-alt"></i></div>
                <div class="stats-info">
                    <h4>BLOG YAZILARI</h4>
                    <p><asp:Literal runat="server" ID="ltrBlogText"></asp:Literal></p>
                </div>
                <div class="stats-link">
                    <a href="javascript:;">View Detail <i class="fa fa-arrow-alt-circle-right"></i></a>
                </div>
            </div>
        </div>
        <!-- end col-3 -->
        <!-- begin col-3 -->
        <div class="col-lg-3 col-md-6">
            <div class="widget widget-stats bg-orange">
                <div class="stats-icon"><i class="fa fa-handshake"></i></div>
                <div class="stats-info">
                    <h4>REFERANSLAR</h4>
                    <p><asp:Literal runat="server" ID="ltrReferences"></asp:Literal></p>
                </div>
                <div class="stats-link">
                    <a href="javascript:;">View Detail <i class="fa fa-arrow-alt-circle-right"></i></a>
                </div>
            </div>
        </div>
        <!-- end col-3 -->
        <!-- begin col-3 -->
        <div class="col-lg-3 col-md-6">
            <div class="widget widget-stats bg-grey-darker">
                <div class="stats-icon"><i class="fa fa-tags"></i></div>
                <div class="stats-info">
                    <h4>ÜRÜNLER</h4>
                    <p><asp:Literal runat="server" ID="ltrProducts"></asp:Literal></p>
                </div>
                <div class="stats-link">
                    <a href="javascript:;">View Detail <i class="fa fa-arrow-alt-circle-right"></i></a>
                </div>
            </div>
        </div>
        <!-- end col-3 -->
        <!-- begin col-3 -->
        <div class="col-lg-3 col-md-6">
            <div class="widget widget-stats bg-black-lighter">
                <div class="stats-icon"><i class="fa fa-envelope"></i></div>
                <div class="stats-info">
                    <h4>GELEN MESAJLAR</h4>
                    <p><asp:Literal runat="server" ID="ltrMessages"></asp:Literal></p>
                </div>
                <div class="stats-link">
                    <a href="javascript:;">View Detail <i class="fa fa-arrow-alt-circle-right"></i></a>
                </div>
            </div>
        </div>
        <!-- end col-3 -->
    </div>
    <!-- end row -->
    <!-- begin row -->
    <div class="row">
        <div class="col-lg-12">
            <!-- begin panel -->
            <div class="panel panel-inverse" data-sortable-id="index-6">
                <div class="panel-heading">
                    <div class="panel-heading-btn">
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-default" data-click="panel-expand"><i class="fa fa-expand"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-success" data-click="panel-reload"><i class="fa fa-redo"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-warning" data-click="panel-collapse"><i class="fa fa-minus"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-danger" data-click="panel-remove"><i class="fa fa-times"></i></a>
                    </div>
                    <h4 class="panel-title">Blog Yazıları</h4>
                </div>
                <div class="panel-body p-t-0">
                    <div id="data-table_wrapper" class="dataTables_wrapper form-inline dt-bootstrap no-footer">
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:Repeater runat="server" ID="rptBlogPost" ClientIDMode="Static">
                                    <HeaderTemplate>
                                        <table class="table table-striped table-bordered dataTable no-footer dtr-inline" id="savedReportsTable">
                                            <thead>
                                                <tr class="headings">
                                                    <th class="column-title" style="width: 5px;"></th>
                                                    <th class="column-title">Başlık</th>
                                                    <th class="column-title">Header</th>
                                                    <th class="column-title">Açıklama</th>
                                                    <th class="column-title">Description</th>
                                                    <th class="column-title">Durum</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr class="even pointer">
                                            <td class=" ">
                                                <div class="btn-group m-r-5 m-b-5">
                                                    <a href="javascript:;" data-toggle="dropdown" class="btn btn-primary btn-xs dropdown-toggle"></a>
                                                    <ul class="dropdown-menu pull-left">
                                                        <li><a href='YazıGüncelle-<%#Eval("Id") %>' class="btn-xs" style="font-size: 14px;"><i class="fa fa-pencil-alt"></i>&nbsp;Düzenle</a></li>
                                                    </ul>
                                                </div>
                                            </td>
                                            <td class=" "><%# Eval("Header") %></td>
                                            <td class=" "><%# Eval("HeaderEn") %></td>
                                            <td class=" " title='<%#ClearHtml(Eval("Article").ToString()) %>'><%# Eval("Article").ToString().Length > 100 ?  ClearHtml(Eval("Article").ToString().Substring(0,100)) + "..." : ClearHtml(Eval("Article").ToString()) %></td>
                                            <td class=" " title='<%#ClearHtml(Eval("ArticleEn").ToString()) %>'><%# Eval("ArticleEn").ToString().Length > 100 ?  ClearHtml(Eval("ArticleEn").ToString().Substring(0,100)) + "..." : ClearHtml(Eval("ArticleEn").ToString()) %></td>
                                            <td class=" "><%# Eval("StatusText") %></td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </tbody>
                                </table>
                                    </FooterTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- end panel -->
        </div>
        <!-- begin col-8 -->
        <div class="col-lg-6">
        <%--    <!-- begin panel -->
            <div class="panel panel-inverse" data-sortable-id="index-1">
                <div class="panel-heading">
                    <div class="panel-heading-btn">
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-default" data-click="panel-expand"><i class="fa fa-expand"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-success" data-click="panel-reload"><i class="fa fa-redo"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-warning" data-click="panel-collapse"><i class="fa fa-minus"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-danger" data-click="panel-remove"><i class="fa fa-times"></i></a>
                    </div>
                    <h4 class="panel-title">Ürünler</h4>
                </div>
                <div class="panel-body">
                    <asp:Repeater runat="server" ID="rptProducts" ClientIDMode="Static">
                        <HeaderTemplate>
                            <table class="table table-striped table-bordered dataTable no-footer dtr-inline" id="savedReportsTable">
                                <thead>
                                    <tr class="headings">
                                        <th class="column-title" style="width: 5px;"></th>
                                        <th class="column-title">Başlık</th>
                                        <th class="column-title">Açıklama</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr class="even pointer">
                                <td class=" ">
                                    <div class="btn-group m-r-5 m-b-5">
                                        <a href="javascript:;" data-toggle="dropdown" class="btn btn-primary btn-xs dropdown-toggle"></a>
                                        <ul class="dropdown-menu pull-left">
                                            <li><a href='ÜrünGüncelle-<%#Eval("Id") %>' class="btn-xs" style="font-size: 14px;"><i class="fa fa-pencil-alt"></i>&nbsp;Düzenle</a></li>
                                        </ul>
                                    </div>
                                </td>
                                <td class=" "><%# Eval("ProductName") %></td>
                                <td class=" " title='<%#ClearHtml(Eval("Description").ToString()) %>'><%# Eval("Description").ToString().Length > 100 ?  ClearHtml(Eval("Description").ToString().Substring(0,100)) + "..." : ClearHtml(Eval("Description").ToString()) %></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </tbody>
                                </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <!-- end panel -->--%>
        </div>
        <!-- end col-8 -->
        <!-- begin col-4 -->
        <div class="col-lg-6">
            <!-- begin panel -->
            <div class="panel panel-inverse" data-sortable-id="index-6">
                <div class="panel-heading">
                    <div class="panel-heading-btn">
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-default" data-click="panel-expand"><i class="fa fa-expand"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-success" data-click="panel-reload"><i class="fa fa-redo"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-warning" data-click="panel-collapse"><i class="fa fa-minus"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-danger" data-click="panel-remove"><i class="fa fa-times"></i></a>
                    </div>
                    <h4 class="panel-title">Gelen Mesajlar</h4>
                </div>
                <div class="panel-body p-t-0">
                    <div class="table-responsive">
                                <asp:Repeater runat="server" ID="rptContents" ClientIDMode="Static">
                                    <HeaderTemplate>
                                        <table class="table table-striped table-bordered dataTable no-footer dtr-inline" id="savedReportsTable">
                                            <thead>
                                                <tr class="headings">
                                                    <th class="column-title" style="width: 5px;"></th>
                                                    <th class="column-title">Adı Soyadı</th>
                                                    <th class="column-title">Telefon</th>
                                                    <th class="column-title">Email</th>
                                                    <th class="column-title">Mesajın Konusu</th>
                                                    <th class="column-title">Gönderildiği Tarih</th>
                                                    <th class="column-title" style="width: 5px;"></th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr class="even pointer">
                                            <td>
                                                <%#Eval("StatusIcon") %>
                                            </td>
                                            <td class=" "><%# Eval("Name") %>&nbsp;<%# Eval("Surname") %></td>
                                            <td class=" "><%# Eval("Phone") %></td>
                                            <td class=" "><%# Eval("Email") %></td>
                                            <td class=" "><%# Eval("Header") %></td>
                                            <td class=" "><%# DateTime.Parse(Eval("SendDate").ToString()).ToString("HH:mm dd/MM/yyyy") %></td>
                                            <td class=" ">
                                                <a href='MesajOku-<%#Eval("Id") %>' class="btn btn-primary btn-xs">Oku</a>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </tbody>
                                </table>
                                    </FooterTemplate>
                                </asp:Repeater>
                    </div>
                </div>
            </div>
            <!-- end panel -->
        </div>
        <!-- end col-4 -->
    </div>
    <!-- end row -->
</asp:Content>
