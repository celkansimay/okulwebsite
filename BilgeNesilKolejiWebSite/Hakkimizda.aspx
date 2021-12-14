<%@ Page Title="Hakkımızda | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="Hakkimizda.aspx.cs" Inherits="Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    
    <section class="content-top-margin page-title bg-gray">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-md-7 col-sm-12 wow fadeInUp animated" data-wow-duration="300ms" style="visibility: visible; animation-duration: 300ms; animation-name: fadeInUp;">
                    <!-- page title -->
                    <h1 class="black-text"><asp:Literal runat="server" ID="ltrHeader"></asp:Literal></h1>
                    <!-- end page title -->
                    <!-- page title tagline -->
                    <span class="xs-display-none"></span>
                    <!-- end title tagline -->
                    <div class="separator-line margin-three bg-black no-margin-lr sm-margin-top-three sm-margin-bottom-three no-margin-bottom xs-display-none"></div>
                </div>
                <div class="col-lg-4 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated text-right" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="#">ANASAYFA</a></li>
                        <li><a href="#">HAKKIMIZDA</a></li>

                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>
    <!-- end head section -->
    <section class="no-padding-top bg-white">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <p class="title-small font-weight-300">
                        <span style="padding: 20px;">
                            <asp:Image runat="server" ID="Image" CssClass="img-responsive" />
                        </span>
                        <asp:Literal runat="server" ID="ltrcContent1"></asp:Literal>
                    </p>
                </div>
            </div>
        </div>
    </section>
</asp:Content>

