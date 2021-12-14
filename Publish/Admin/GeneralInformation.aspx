<%@ page title="" language="C#" masterpagefile="~/Admin/MasterPage.master" autoeventwireup="true" inherits="Admin_GeneralInformation, App_Web_jw0yzfwl" %>

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
                            <label class="col-md-2 control-label">Telefon</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtPhone" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label">Fax</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtFax" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label">E-mail</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-2 control-label">Yetkili E-mail</label>
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtAuthEmail" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-lg-12">
                            <div class="row">
                                <div class="col-lg-3">
                                    <div class="form-group">
                                        <label class="control-label">Sayı 1</label>
                                        <asp:TextBox runat="server" ID="txtCounter1" CssClass="form-control" PlaceHolder="Sayı 1" ClientIDMode="Static" onkeypress="numericControl(this)"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3">
                                    <div class="form-group">
                                        <label class="control-label">Sayı 2</label>
                                        <asp:TextBox runat="server" ID="txtCounter2" CssClass="form-control" PlaceHolder="Sayı 2" ClientIDMode="Static" onkeypress="numericControl(this)"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3">

                                    <div class="form-group">
                                        <label class="control-label">Sayı 3</label>
                                        <asp:TextBox runat="server" ID="txtCounter3" CssClass="form-control" PlaceHolder="Sayı 3" ClientIDMode="Static" onkeypress="numericControl(this)"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-3">

                                    <div class="form-group">
                                        <label class="control-label">Sayı 4</label>
                                        <asp:TextBox runat="server" ID="txtCounter4" CssClass="form-control" PlaceHolder="Sayı 4" ClientIDMode="Static" onkeypress="numericControl(this)"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- begin nav-tabs -->
                        <ul class="nav nav-tabs">
                            <li class="nav-items m-l-20">
                                <a href="#default-tab-1" data-toggle="tab" class="nav-link active">
                                    <span class="d-sm-none">Tab 1</span>
                                    <span class="d-sm-block d-none">Türkçe</span>
                                </a>
                            </li>
                        </ul>
                        <!-- end nav-tabs -->
                        <!-- begin tab-content -->
                        <div class="tab-content">
                            <!-- begin tab-pane -->
                            <div class="tab-pane fade active show" id="default-tab-1">
                                <div class="form-group">
                                    <label class="col-md-2 control-label">Adres 1</label>
                                    <div class="col-md-12">
                                        <asp:TextBox runat="server" ID="txtAddress1" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-md-2 control-label">Adres 2</label>
                                    <div class="col-md-12">
                                        <asp:TextBox runat="server" ID="txtAddress2" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-lg-12">
                                    <div class="row">
                                        <div class="col-lg-3">
                                            <div class="form-group">
                                                <label class="control-label">Sayı 1 Başlık</label>
                                                <asp:TextBox runat="server" ID="txtCounter1TrHeader" CssClass="form-control" PlaceHolder="Sayı 1 Başlık"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3">
                                            <div class="form-group">
                                                <label class="control-label">Sayı 2 Başlık</label>
                                                <asp:TextBox runat="server" ID="txtCounter2TrHeader" CssClass="form-control" PlaceHolder="Sayı 2 Başlık"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3">

                                            <div class="form-group">
                                                <label class="control-label">Sayı 3 Başlık</label>
                                                <asp:TextBox runat="server" ID="txtCounter3TrHeader" CssClass="form-control" PlaceHolder="Sayı 3 Başlık"></asp:TextBox>
                                            </div>
                                        </div>
                                        <div class="col-lg-3">

                                            <div class="form-group">
                                                <label class="control-label">Sayı 4 Başlık</label>
                                                <asp:TextBox runat="server" ID="txtCounter4TrHeader" CssClass="form-control" PlaceHolder="Sayı 4 Başlık"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- end tab-pane -->
                        </div>
                        <!-- end tab-content -->
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

    <script type="text/javascript">


        function numericControl(value) {
            if (!event.which || (48 <= event.which && event.which <= 57)
                // 0 -> 48 // 1 -> 49 // 2 -> 50 // 3 -> 51 // 4 -> 52 // 5 -> 53 // 6 -> 54 // 7 -> 55 // 8 -> 56 // 9 -> 57 // , -> 44
            ) { // Opera assigns values for control keys.
                //var count = 0;
                var textvalue = $(taxnumber).val();
            } else {
                event.preventDefault();
            }
        }
    </script>
</asp:Content>

