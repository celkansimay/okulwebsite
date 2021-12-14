<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="VideoGaleri.aspx.cs" Inherits="Admin_VideoGaleri" ValidateRequest="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="assets/plugins/DataTables/media/css/dataTables.bootstrap.min.css" rel="stylesheet" />
    <link href="assets/plugins/DataTables/extensions/Responsive/css/responsive.bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- begin breadcrumb -->
    <ol class="breadcrumb pull-right">
        <li class="breadcrumb-item"><a href="Anasayfa">Web Sitesi Yönetim Paneli</a></li>
        <li class="breadcrumb-item active">Slider</li>
    </ol>

    <!-- end breadcrumb -->
    <!-- begin page-header -->
    <h1 class="page-header">
        <asp:Literal runat="server" ID="ltrBranchName"></asp:Literal>&nbsp;<small>Web Sitesi Yönetim Paneli</small></h1>
    <!-- end page-header -->

    <div class="row">
        <div class="col-md-12 ui-sortable">
            <!-- begin panel -->
            <div class="panel panel-inverse" data-sortable-id="form-stuff-1">
                <div class="panel-heading">
                    <div class="panel-heading-btn">
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-default" data-click="panel-expand"><i class="fa fa-expand"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-success" data-click="panel-reload"><i class="fa fa-repeat"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-warning" data-click="panel-collapse"><i class="fa fa-minus"></i></a>
                    </div>
                    <h4 class="panel-title">
                        <asp:Literal runat="server" ID="ltrHeader"></asp:Literal></h4>
                </div>
                <div class="panel-body">
                    <div role="form" class="form-horizontal">
                        <div class="form-group">
                            <label class="col-md-2 control-label">Link</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtLink" CssClass="form-control" ClientIDMode="Static"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-12 col-lg-offset-2">
                            <asp:LinkButton runat="server" ID="btnSave" Text="Kaydet" CssClass="btn btn-block btn-primary" OnClick="btnSave_Click"></asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
            <!-- end panel -->
        </div>
    </div>

    <!-- begin page-header -->
    <h1 class="page-header">
        <asp:Literal runat="server" ID="Literal2"></asp:Literal>&nbsp;<small>KAYITLI VİDEOLAR</small></h1>
    <!-- end page-header -->

    <div class="row">
        <div class="col-md-12 ui-sortable">
            <!-- begin panel -->
            <div class="panel panel-inverse" data-sortable-id="form-stuff-1">
                <div class="panel-heading">
                    <div class="panel-heading-btn">
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-default" data-click="panel-expand"><i class="fa fa-expand"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-success" data-click="panel-reload"><i class="fa fa-repeat"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-warning" data-click="panel-collapse"><i class="fa fa-minus"></i></a>
                    </div>
                    <h4 class="panel-title">
                        <asp:Literal runat="server" ID="Literal1"></asp:Literal></h4>
                </div>
                <div class="panel-body">
                    <div id="data-table_wrapper" class="dataTables_wrapper form-inline dt-bootstrap no-footer">
                        <div class="row">
                            <div class="col-sm-12">
                                <asp:Repeater runat="server" ID="rptVideo" OnItemCommand="rptVideoGallery_ItemCommand" ClientIDMode="Static">
                                    <HeaderTemplate>
                                        <table class="table table-striped table-bordered dataTable no-footer dtr-inline" id="savedReportsTable">
                                            <thead>
                                                <tr class="headings">
                                                    <th class="column-title" style="width: 5px;"></th>
                                                    <th class="column-title">video</th>
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
                                                        <li><a href='FotoğrafGüncelle-<%#Eval("Id") %>' class="btn-xs" style="font-size: 14px;"><i class="fa fa-pencil-alt"></i>&nbsp;Düzenle</a>
                                                        </li>
                                                        <li>
                                                            <asp:LinkButton runat="server" ID="btnDelete" CommandName="DeleteRow" CommandArgument='<%#Eval("Id") %>'><i class="fa fa-times"></i>&nbsp;Sil</asp:LinkButton></li>
                                                    </ul>

                                                </div>
                                            </td>
                                            <td class=" "><%# Eval("Header") %></td>
                                            <td class=" " title='<%#ClearHtml(Eval("Url").ToString()) %>'><%# Eval("Url").ToString() %></td>

                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </tbody> 
                                        </div>
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
    </div>



    <div id="mdlError" class="swal-overlay swal-overlay--show-modal" tabindex="-1" style="display: none;">
        <div class="swal-modal" role="dialog">
            <div class="swal-icon swal-icon--error">
                <div class="swal-icon--error__x-mark">
                    <span class="swal-icon--error__line swal-icon--error__line--left"></span>
                    <span class="swal-icon--error__line swal-icon--error__line--right"></span>
                </div>
            </div>
            <div class="swal-title" style="">
                <asp:Literal runat="server" ID="ltrHeaderText"></asp:Literal>
            </div>
            <div class="swal-text" style="">
                <asp:Literal runat="server" ID="ltrErrorText"></asp:Literal>
            </div>
            <div class="swal-footer">
                <div class="swal-button-container">
                    <button class="swal-button swal-button--confirm btn btn-danger">Vazgeç</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

