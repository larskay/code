<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AMSYSMobile._Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <script src="Scripts/jquery-1.7.2-vsdoc.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.7.2.js" type="text/javascript"></script>
    <link href="Scripts/AMSYSMobile.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/LoginClass.js" type="text/javascript"></script>
    <script src="Scripts/CreateModuleDropdownClass.js" type="text/javascript"></script>
    <script src="Scripts/RenderClass.js" type="text/javascript"></script>
    <script src="Scripts/IndexValueClass.js" type="text/javascript"></script>
    <script src="Scripts/PagingClass.js" type="text/javascript"></script>
    <script src="Scripts/ViewClass.js" type="text/javascript"></script>
    <script src="Scripts/GetTemplateCaptionClass.js" type="text/javascript"></script>
    <script src="Scripts/EditDocClass.js" type="text/javascript"></script>
    <script src="Scripts/EditFieldsClass.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
            $("#currentPage").val(1);
            $("#pageSize").val(5);
        });
    </script>
    <title></title>
</head>
<body>
    <div id="account"></div>
    <div id="cmbModulesDiv"></div>
    <form id="form1" runat="server">
    <div id="Login"></div>
    <div id="caption"></div>
    <div id="index"></div>
    <div id="newPage"></div>
    <div id="show" class="show"></div>
    </form>
    <div id="pageing"></div>
    <input type="hidden" id="currentPage" />
    <input type="hidden" id="pageSize" />
</body>
</html>
