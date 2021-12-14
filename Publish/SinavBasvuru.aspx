<%@ page title="Sınav Başvuru | Bilge Nesil Koleji" language="C#" masterpagefile="~/Bottom.master" autoeventwireup="true" inherits="SinavBasvuru, App_Web_bln2rj34" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                <div class="col-lg-6 col-md-5 col-sm-12 breadcrumb text-uppercase sm-no-margin-top wow fadeInUp xs-display-none animated" data-wow-duration="600ms" style="visibility: visible; animation-duration: 600ms; animation-name: fadeInUp;">
                    <!-- breadcrumb -->
                    <ul>
                        <li><a href="#">ANASAYFA</a></li>
                        <li><a href="#">BASVURU</a></li>
                        <li><a href="#">SINAV BAŞVURU FORMU</a></li>
                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </section>
    <section class="wow fadeIn">
        <div class="container">
            <div class="row">
                <div class="col-md-7 col-sm-10 center-col text-center margin-ten no-margin-top xs-margin-bottom-seven">
                    <h1 class="no-margin-top margin-ten xs-margin-bottom-seven"><strong class="black-text">SINAV BAŞVURU FORMU</strong></h1>
                </div>
            </div>
            <div class="row">
                <div class="col-md-7 col-sm-10 center-col">
                    <div id="upt1">

                        <div id="pnlInformation">
                        </div>
                        <label class="control-label">Sınav Tarihleri <span class="text-danger">*</span></label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <select name="ddlExamDates" id="ddlExamDates" class="form-control">
                                    <option selected="selected" value="-1">Seçiniz...</option>
                                    <option value="2">22 Mart</option>

                                </select>
                            </div>
                        </div>
                        <label class="control-label">Sınav Seansları <span class="text-danger">*</span></label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <select name="ddlExamSessions" id="ddlExamSessions" class="form-control">
                                    <option selected="selected" value="-1">Seçiniz...</option>
                                    <option value="1">10:30</option>
                                    <option value="2">13:30</option>
                                    <option value="3">16:00</option>

                                </select>
                            </div>
                        </div>
                        <label class="control-label">Sınıfı <span class="text-danger">*</span></label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <select name="ddlClass" id="ddlClass" class="form-control">
                                    <option selected="selected" value="-1">Seçiniz...</option>
                                    <option value="1">6. Sınıf</option>
                                    <option value="2">7. Sınıf</option>
                                    <option value="3">9. Sınıf</option>
                                    <option value="4">10. Sınıf</option>
                                    <option value="5">11. Sınıf</option>

                                </select>
                            </div>
                        </div>
                        <div class="row row-space-10">
                            <div class="col-md-6 m-b-15">
                                <label class="control-label">Adınız <span class="text-danger">*</span></label>
                                <input name="txtName" type="text" id="txtName" class="form-control" placeholder="Adınız">
                            </div>
                            <div class="col-md-6 m-b-15">
                                <label class="control-label">Soyadınız <span class="text-danger">*</span></label>
                                <input name="txtSurname" type="text" id="txtSurname" class="form-control" placeholder="Soyadınız">
                            </div>
                        </div>
                        <label class="control-label">Telefon Numarası <span class="text-danger">*</span></label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <input name="txtPhone" type="text" id="txtPhone" class="form-control Phone" placeholder="Telefon Numarası">
                            </div>
                        </div>
                        <label class="control-label">Okulu <span class="text-danger">*</span></label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <input name="txtSchool" type="text" id="txtSchool" class="form-control" placeholder="Okulu">
                            </div>
                        </div>
                        <label class="control-label">Veli Adı <span class="text-danger">*</span></label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <input name="txtParentName" type="text" id="txtParentName" class="form-control" placeholder="Veli Adı">
                            </div>
                        </div>
                        <label class="control-label">Veli Telefon Numarası <span class="text-danger">*</span></label>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <input name="txtParentPhone" type="text" id="txtParentPhone" class="form-control Phone" placeholder="Telefon Numarası">
                            </div>
                        </div>
                        <div class="row m-b-15">
                            <div class="col-md-12">
                                <a id="btnSave" class="btn btn-primary btn-block btn-lg" href="javascript:__doPostBack('btnSave','')">Kaydol</a>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        </div>
    </section>

</asp:Content>

