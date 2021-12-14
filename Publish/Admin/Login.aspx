<%@ page language="C#" autoeventwireup="true" inherits="Admin_Login, App_Web_lgx2efhf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <!-- ================== BEGIN BASE CSS STYLE ================== -->
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700" rel="stylesheet" />
    <link href="assets/plugins/jquery-ui/jquery-ui.min.css" rel="stylesheet" />
    <link href="assets/plugins/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/plugins/font-awesome/5.0/css/fontawesome-all.min.css" rel="stylesheet" />
    <link href="assets/plugins/animate/animate.min.css" rel="stylesheet" />
    <link href="assets/css/default/style.min.css" rel="stylesheet" />
    <link href="assets/css/default/style-responsive.min.css" rel="stylesheet" />
    <link href="assets/css/default/theme/default.css" rel="stylesheet" id="theme" />
    <!-- ================== END BASE CSS STYLE ================== -->

    <!-- ================== BEGIN BASE JS ================== -->
    <script src="assets/plugins/pace/pace.min.js"></script>
    <!-- ================== END BASE JS ================== -->
</head>
<body class="pace-top">
    <form id="form1" runat="server">
        <div id="page-loader" class="fade show"><span class="spinner"></span></div>
        <!-- end #page-loader -->

        <div class="login-cover">
            <div class="login-cover-image" style="background-image: url(assets/img/login-bg/login-bg-15.jpg)" data-id="login-cover-image"></div>
            <div class="login-cover-bg"></div>
        </div>
        <!-- begin #page-container -->
        <div id="page-container" class="fade">
            <!-- begin login -->
            <div class="login login-v2" data-pageload-addclass="animated fadeIn">
                <!-- begin brand -->
                <div class="login-header">
                    <div class="brand">
                        <img src="assets/img/logo/logo.png" height="65" />
                        <%--<small>Alku Web Sitesi Yönetim Paneli</small>--%>
                    </div>
                    <div class="icon">
                        <i class="fa fa-lock"></i>
                    </div>
                </div>
                <!-- end brand -->
                <!-- begin login-content -->
                <div class="login-content">
                    <div role="form" class="margin-bottom-0">
                        <div class="form-group m-b-20">
                            <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control form-control-lg" PlaceHolder="Kullanıcı Adı"></asp:TextBox>
                        </div>
                        <div class="form-group m-b-20">
                            <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control form-control-lg" PlaceHolder="Parola" TextMode="Password"></asp:TextBox>
                        </div>
                        <%--<div class="checkbox checkbox-css m-b-20">
                            <input type="checkbox" id="remember_checkbox" />
                            <label for="remember_checkbox">
                                Remember Me
                       
                            </label>
                        </div>--%>
                        <div class="login-buttons">
                            <asp:LinkButton runat="server" ID="btnLogin" CssClass="btn btn-success btn-block btn-lg" Text="Giriş Yap" OnClick="btnLogin_Click"></asp:LinkButton>
                        </div>
                    </div>
                </div>
                <!-- end login-content -->
            </div>
            <!-- end login -->

        </div>
        <!-- end page container -->

        <!-- ================== BEGIN BASE JS ================== -->
        <script src="assets/plugins/jquery/jquery-3.2.1.min.js"></script>
        <script src="assets/plugins/jquery-ui/jquery-ui.min.js"></script>
        <script src="assets/plugins/bootstrap/4.0.0/js/bootstrap.bundle.min.js"></script>
        <!--[if lt IE 9]>
		<script src="assets/crossbrowserjs/html5shiv.js"></script>
		<script src="assets/crossbrowserjs/respond.min.js"></script>
		<script src="assets/crossbrowserjs/excanvas.min.js"></script>
	<![endif]-->
        <script src="assets/plugins/slimscroll/jquery.slimscroll.min.js"></script>
        <script src="assets/plugins/js-cookie/js.cookie.js"></script>
        <script src="assets/js/theme/default.min.js"></script>
        <script src="assets/js/apps.min.js"></script>
        <!-- ================== END BASE JS ================== -->

        <!-- ================== BEGIN PAGE LEVEL JS ================== -->
        <script src="assets/js/demo/login-v2.demo.min.js"></script>
        <!-- ================== END PAGE LEVEL JS ================== -->

        <script src="assets/plugins/bootstrap-sweetalert/sweetalert.min.js"></script>

        <script type="text/javascript">
		    $(document).ready(function() {
			    App.init();
			    LoginV2.init();
		    });
	    </script>

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

    </form>
</body>
</html>
