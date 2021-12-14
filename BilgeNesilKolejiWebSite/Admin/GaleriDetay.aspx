<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPage.master" AutoEventWireup="true" CodeFile="GaleriDetay.aspx.cs" Inherits="Admin_GaleriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="assets/plugins/DataTables/media/css/dataTables.bootstrap.min.css" rel="stylesheet" />
    <link href="assets/plugins/DataTables/extensions/Responsive/css/responsive.bootstrap.min.css" rel="stylesheet" />

    <style type="text/css">
        .col-lg-3 {
            float: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                    <h4 class="panel-title"><i class="fa fa-plus"></i>&nbsp;Resim Ekle</h4>
                </div>
                <div class="panel-body">
                    <div role="form" class="form-horizontal">
                        <table class="table table-bordered">
                            <thead>
                                <tr>
                                    <th></th>
                                    <th>Türkçe</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td style="vertical-align: middle;">Görsel</td>
                                    <td colspan="2">
                                        <asp:FileUpload runat="server" ID="fuFile" /></td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td colspan="2">
                                        <asp:LinkButton runat="server" ID="btnSave" Text="Güncelle" CssClass="btn btn-primary" OnClick="btnSave_Click"></asp:LinkButton></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- begin #content -->
    <!-- begin page-header -->
    <h1 class="page-header">Foto Galeri</h1>
    <!-- end page-header -->


    <div id="gallery" class="gallery">
        <asp:Literal runat="server" ID="ltrNoData" Visible="false"></asp:Literal>
        <asp:Repeater runat="server" ID="rptPhotoGallery" OnItemCommand="rptPhotoGallery_ItemCommand">
            <ItemTemplate>
                <div class="image col-lg-3">
                    <div class="image-inner">
                        <a href='<%#Eval("ImgUrl") %>' data-lightbox="GG" runat="server">
                            <img src='<%#Eval("ImgUrl") %>' runat="server" alt="" />
                        </a>
                    </div>
                    <div class="image-info">
                        <%--<h5 class="title"><%#Eval("Header") %></h5>
                        <div class="desc">
                            <%#Eval("Content") %>
                        </div>--%>
                        <div class="desc">
                            Ekleyen: <%#Eval("InsertName") %> - <%#Eval("InsertDate") %>
                        </div>
                        <div class="row">
                            <div class="col-lg-12">
                                <asp:LinkButton runat="server" ID="btnDelete" Text="Sil" CommandName="Delete" CommandArgument='<%#Eval("Id") %>' CssClass="btn btn-block btn-danger btn-sm m-r-5"></asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <!-- end #content -->




    <div class="modal modal-message fade out" id="mdlError" style="display: none;">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                    <h4 class="modal-title">HATA!</h4>
                </div>
                <div class="modal-body">
                    <p>
                        <asp:Literal runat="server" ID="ltrHeaderText"></asp:Literal>
                    </p>
                    <p>
                        <asp:Literal runat="server" ID="ltrErrorText"></asp:Literal>
                    </p>
                </div>
                <div class="modal-footer">
                    <a href="javascript:;" class="btn btn-sm btn-white" data-dismiss="modal">Kapat</a>
                </div>
            </div>
        </div>
    </div>


    <script src="assets/plugins/isotope/jquery.isotope.min.js"></script>
    <script src="assets/plugins/lightbox/js/lightbox-2.6.min.js"></script>
    <script src="assets/js/gallery.demo.min.js"></script>
    <script src="assets/js/apps.min.js"></script>


    <script>
        $(document).ready(function () {
            App.init();
            Gallery.init();
        });
	</script>
</asp:Content>

