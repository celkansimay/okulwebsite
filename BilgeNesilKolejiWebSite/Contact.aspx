<%@ Page Title="İletişim | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <style type="text/css">
        #contact-form a {
            color: #252525;
            text-decoration: none;
        }

            #contact-form a:hover {
                color: #505050;
                text-decoration: none;
            }
    </style>
    <asp:ScriptManager runat="server" ID="sm1" />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <!-- head section -->
            <section class="content-top-margin page-title page-title-small border-top-light">
                <div class="container">
                    <div class="row">
                        <div class="col-md-8 col-sm-12 wow fadeInUp" data-wow-duration="300ms">
                            <!-- page title -->
                            <h2 class="black-text">
                                <asp:Literal runat="server" ID="ltrContactHeader"></asp:Literal></h2>
                            </h1>
                            <!-- end page title -->
                        </div>
                        <div class="col-md-4 col-sm-12 breadcrumb text-uppercase wow fadeInUp xs-display-none text-right" data-wow-duration="600ms">
                            <!-- breadcrumb -->
                            <ul>
                                <li><a href="#">ANASAYFA</a></li>
                                <li>İLETİŞİM</li>
                            </ul>
                            <!-- end breadcrumb -->
                        </div>
                    </div>
                </div>
            </section>
            <!-- end head section -->
            <!-- content section -->
            <section class="wow fadeIn no-padding">
                <div class="container-fuild">
                    <div class="row no-margin">
                        <div id="canvas1" class="col-md-12 col-sm-12 no-padding contact-map map">
                            <iframe id="map_canvas1" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2568.704298095927!2d32.90365065374743!3d40.0369986247652!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4082086d9590270f%3A0xf3fb5cbf0eeeab56!2sBilge%20Nesil%20Koleji!5e0!3m2!1str!2str!4v1594742543070!5m2!1str!2str"></iframe>
                        </div>
                    </div>
                </div>
            </section>

            <section id="contact-form" class="wow fadeIn">
                <div class="container">
                    <div class="row">
                        <div class="col-md-4 col-sm-6">
                            <div class="col-lg-12 margin-bottom-seven no-padding">
                                <div style="margin-right: 100px;" class="mx-0">
                                    <h2>İLETİŞİM </h2>
                                </div>
                            </div>
                            <p class="text-med">
                                <asp:Literal runat="server" ID="ltrAddress"></asp:Literal>
                                <asp:Literal runat="server" ID="ltrAddress1"></asp:Literal>
                                <br />
                                <asp:Literal runat="server" ID="ltrAddress2"></asp:Literal>
                                <br />
                                <strong>P:</strong>
                                <asp:Literal runat="server" ID="ltrPhone"></asp:Literal>
                                <%=GeneralInformation.Phone %><br>
                                <strong>E:</strong> <a href="mailto:bilgenesilkoleji@gmail.com">bilgenesilkoleji@gmail.com</a>
                            </p>
                        </div>

                        <div class="col-md-6 col-sm-6  col-md-offset-2">
                            <form id="project-contact-form" action="javascript:void(0)" method="post">
                                <div class="row">
                                    <div class="col-lg-12 margin-bottom-seven">
                                        <div id="success-project-contact-form" style="margin-right: 100px;" class="mx-0">
                                            <h2>İLETİŞİM FORMU</h2>
                                        </div>
                                    </div>
                                    <div class="col-lg-6 col-xs-12">
                                        <asp:TextBox runat="server" ID="txtName" placeholder="Adınız" CssClass="bg-transparent border-color-medium-dark-gray medium-input" ClientIDMode="Static"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6 col-xs-12">
                                        <asp:TextBox runat="server" ID="txtSurname" placeholder="Soyadınız" CssClass="bg-transparent border-color-medium-dark-gray medium-input" ClientIDMode="Static"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6 col-xs-12">
                                        <asp:TextBox runat="server" ID="txtPhone" placeholder="Telefon" CssClass="bg-transparent border-color-medium-dark-gray medium-input" ClientIDMode="Static"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-6 col-xs-12">
                                        <asp:TextBox runat="server" ID="txtEmail" placeholder="Email" CssClass="bg-transparent border-color-medium-dark-gray medium-input" ClientIDMode="Static"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-12">
                                        <asp:TextBox runat="server" ID="txtHeader" placeholder="Mesajınızın Konusu" CssClass="bg-transparent border-color-medium-dark-gray medium-input" ClientIDMode="Static"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-12">
                                        <asp:TextBox runat="server" ID="txtMessage" placeholder="Mesajınız" CssClass="bg-transparent border-color-medium-dark-gray medium-textarea" Height="100" TextMode="MultiLine" ClientIDMode="Static"></asp:TextBox>
                                    </div>
                                    <div class="col-lg-12 text-center">
                                        <asp:LinkButton runat="server" ID="btnSend" class="highlight-button-black-border btn-block text-center btn btn-very-small button xs-no-margin" Text="Gönder" OnClick="btnSend_Click"></asp:LinkButton>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </section>

            <!-- Contact Form Section Ends -->
            <div class="modal modal-message fade out" id="mdlError" style="display: none;">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                            <h4 class="modal-title">
                                <asp:Literal runat="server" ID="ltrPopupHeader"></asp:Literal></h4>
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
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
