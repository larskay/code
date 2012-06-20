/// <reference path="jquery-1.7.2-vsdoc.js" />
$(function ($) {
    $.ajaxSetup({
        type: "post",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        timeout: 5000
    });

    this.Div = document.getElementById('Login');

    var txtUserInput = '<input type="text" id="txtUser" placeholder="Enter username" />';
    var pwdPassWord = '<input type="password" id="pswPass" placeholder="Enter password" /><br>';
    var btnLogin = '<input type="button" id="btnLogin" value="Login"  />';

    $(this.Div).append(txtUserInput, pwdPassWord, btnLogin);

    $("#btnLogin").live('click', function () {
        var usrName = $('#txtUser').val();
        var psw = $('#pswPass').val();
        var json = { 'UserName': usrName, 'PassWord': psw };
        $.ajax({
            url: "WebService.asmx/GetUserService",
            data: JSON.stringify(json),
            success: function (msg) {

                var user = msg.d;
                var companyId = user[0].company.companyId;
                var cmbModules = new ModuleDropdownClass(user)

                cmbModules.GetModules(companyId);

                $("#account").append('Bruker ' + user[0].UserName + ' er logget inn');
                $("#Login").remove();
            }
        });
    });
});