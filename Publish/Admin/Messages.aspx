<%@ page title="" language="C#" masterpagefile="~/Admin/MasterPage.master" autoeventwireup="true" inherits="Admin_Messages, App_Web_jw0yzfwl" %>

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
        <!-- begin col-12 -->
        <div class="col-md-12 ui-sortable">
            <!-- begin panel -->
            <div class="panel panel-inverse">
                <div class="panel-heading">
                    <div class="panel-heading-btn">
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-default" data-click="panel-expand"><i class="fa fa-expand"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-success" data-click="panel-reload" data-original-title="" title=""><i class="fa fa-repeat"></i></a>
                        <a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-warning" data-click="panel-collapse"><i class="fa fa-minus"></i></a>
                        <%--<a href="javascript:;" class="btn btn-xs btn-icon btn-circle btn-danger" data-click="panel-remove" data-original-title="" title=""><i class="fa fa-times"></i></a>--%>
                    </div>
                    <h4 class="panel-title">Gelen Mesajlar
                    </h4>
                </div>
                <div class="panel-body">
                    <div id="data-table_wrapper" class="dataTables_wrapper form-inline dt-bootstrap no-footer">
                        <div class="row">
                            <div class="col-sm-12">
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
                </div>
            </div>
            <!-- end panel -->
        </div>
        <!-- end col-12 -->
    </div>

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

    <script src="assets/plugins/jquery/jquery-1.9.1.js"></script>
    <%--<script src="assets/plugins/bootstrap/js/bootstrap.min.js"></script>--%>

    <script src="assets/plugins/DataTables/media/js/jquery.dataTables.js"></script>
    <script src="assets/plugins/DataTables/media/js/dataTables.bootstrap.min.js"></script>
    <script src="assets/plugins/DataTables/extensions/Responsive/js/dataTables.responsive.min.js"></script>
    <script src="assets/js/table-manage-default.demo.js"></script>

</asp:Content>

