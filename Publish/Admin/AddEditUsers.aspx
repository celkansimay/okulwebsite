<%@ page title="" language="C#" masterpagefile="~/Admin/MasterPage.master" autoeventwireup="true" inherits="Admin_AddEditUsers, App_Web_jw0yzfwl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
                            <label class="col-md-2 control-label">Adı Soyadı</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtNameSurname" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label">Kullanıcı Adı</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label">Parola</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label">Parola Tekrar</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtPasswordReply" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-12 col-lg-offset-2">
                            <asp:LinkButton runat="server" ID="btnSave" Text="Güncelle" CssClass="btn btn-block btn-primary" OnClick="btnSave_Click"></asp:LinkButton>
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

