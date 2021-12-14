<%@ page title="" language="C#" masterpagefile="~/Admin/MasterPage.master" autoeventwireup="true" inherits="Admin_DemoFormDetail, App_Web_jw0yzfwl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
                    <table class="table table-bordered m-b-0">
                        <tbody>
                            <tr>
                                <td>Şirket Adı</td>
                                <td><asp:Literal runat="server" ID="ltrCompanyName"></asp:Literal></td>
                            </tr>
                            <tr>
                                <td>Adı Soyadı</td>
                                <td><asp:Literal runat="server" ID="ltrNameSurname"></asp:Literal></td>
                            </tr>
                            <tr>
                                <td>Telefon Numarası</td>
                                <td><asp:Literal runat="server" ID="ltrPhone"></asp:Literal></td>
                            </tr>
                            <tr>
                                <td>E-Mail</td>
                                <td><asp:Literal runat="server" ID="ltrEmail"></asp:Literal></td>
                            </tr>
                            <%--<tr>
                                <td>Okunma Tarihi</td>
                                <td><asp:Literal runat="server" ID="ltrReadDate"></asp:Literal></td>
                            </tr>
                            <tr>
                                <td>Okuyan Kişi</td>
                                <td><asp:Literal runat="server" ID="ltrReadBy"></asp:Literal></td>
                            </tr>--%>
                           <%-- <tr>
                                <td>Mesajın Konusu</td>
                                <td><asp:Literal runat="server" ID="ltrMessageHeader"></asp:Literal></td>
                            </tr>--%>
                            <tr>
                                <td>Mesaj</td>
                                <td><asp:Literal runat="server" ID="ltrMessages"></asp:Literal></td>
                            </tr>
                        </tbody>
                    </table>
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

