 <%@ Page Title="Video Galeri | Bilge Nesil Koleji" Language="C#" MasterPageFile="~/Bottom.master" AutoEventWireup="true" CodeFile="VideoGaleri.aspx.cs" Inherits="VideoGaleri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        iframe{
            width: 100% !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- content section -->
    <section class="wow fadeIn">
        <div class="container">
            <div class="row">
                <div class="col-md-7 col-sm-10 center-col text-center margin-ten no-margin-top xs-margin-bottom-seven">
                    <h6 class="no-margin-top margin-ten xs-margin-bottom-seven"><strong class="black-text">VİDEO GALERİ</strong></h6>
                </div>
            </div>
            <div class="row">
                    <asp:Repeater runat="server" ID="rptPhotoGallery">
                        <ItemTemplate>
                            <div class="col-md-6 col-sm-12">
                                <%#Eval("Url") %>
                            </div>
                        </ItemTemplate>

                    </asp:Repeater>

                   <%-- <iframe width="560" height="315" src="https://www.youtube.com/embed/6ZHfuEupNdk" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>--%>
                    <%--  <!-- vimeo video -->
                    <iframe src="https://player.vimeo.com/video/99585787?color=bb9b44&title=0&byline=0&portrait=0"height="281"></iframe>
                    <!-- end vimeo video -->--%>
                </div>
        </div>
    </section>
</asp:Content>

