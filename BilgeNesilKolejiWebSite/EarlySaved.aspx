<%@ Page Title="" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="EarlySaved.aspx.cs" Inherits="EarlySaved" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager runat="server" />
    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-6 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text">ERKEN KAYIT FORMU</h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="xs-display-none"></span>
                    <!-- end title tagline -->
                    <div class="separator-line margin-three bg-black no-margin-lr sm-margin-top-three sm-margin-bottom-three no-margin-bottom xs-display-none"></div>
                </div>
                <div class="col-lg-6 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated text-right" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="#">ANASAYFA</a></li>
                        <li><a href="#">BASVURU</a></li>
                        <li><a href="#">ERKEN KAYIT FORMU</a></li>
                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>

    <!-- form option #2 -->
    <section class="wow fadeIn">
        <div class="container">
            <div class="row">
                <div class="col-md-7 col-sm-10 center-col">
                    <div class="register-content" visible="true">
                        <label class="control-label">Sınıfı</label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <asp:DropDownList runat="server" ID="ddlClass" CssClass="form-control" AppendDataBoundItems="true" DataValueField="Id" DataTextField="Name">
                                    <asp:ListItem Text="Seçiniz..." Value="-1"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <label class="control-label">Adınız</label>
                        <div class="row row-space-10">
                            <div class="col-md-6 m-b-15">
                                <asp:TextBox runat="server" ID="txtName" CssClass="form-control" PlaceHolder="Adınız"></asp:TextBox>
                            </div>
                            <div class="col-md-6 m-b-15">
                                <asp:TextBox runat="server" ID="txtSurname" CssClass="form-control" PlaceHolder="Soyadınız"></asp:TextBox>
                            </div>
                        </div>
                        <label class="control-label">Telefon Numarası</label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtPhone" CssClass="form-control" PlaceHolder="Telefon Numarası"></asp:TextBox>
                            </div>
                        </div>

                        <label class="control-label">Veli Adı</label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtParentName" CssClass="form-control" PlaceHolder="Veli Adı"></asp:TextBox>
                            </div>
                        </div>
                        <label class="control-label">Veli Telefon Numarası</label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <asp:TextBox runat="server" ID="txtParentPhone" CssClass="form-control" PlaceHolder="Veli Telefon Numarası"></asp:TextBox>
                            </div>
                        </div>

                        <div class="register-buttons">
                            <asp:LinkButton runat="server" ID="btnRegister" CssClass="highlight-button-black-border btn-small btn button xs-no-margin btn-block text-center" Text="Kaydol" OnClick="btnRegister_Click"></asp:LinkButton>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <asp:UpdatePanel runat="server" ID="upt1">
        <ContentTemplate>
            <div class="modal modal-message fade out" id="mdlError" style="display: none;">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                            <h4 class="modal-title">
                                <asp:Literal runat="server" ID="ltrHeaderText"></asp:Literal></h4>
                        </div>
                        <div class="modal-body">
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
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

