/// <reference path="jquery-1.7.2-vsdoc.js" />
function ModuleDropdownClass(json) {
    var pageSize = 0;
    this.json = json;
    this.RenderModulesDropdown = RenderModulesDropdown;
    this.GetModules = GetModules;
    this.ModulesHandler = ModulesHandler;

    function GetModules(companyId){
    var UserID = {'companyId' : companyId };
        $.ajax({
            url: "WebService.asmx/GetModulesService",
            data: JSON.stringify(UserID),
            success: function(msg){
                var modules = msg.d;
                RenderModulesDropdown(modules);
            }
        });
    }

    function RenderModulesDropdown(modules) {
        $("#cmbModulesDiv").append('<select id="cmbModule"><option id="0">Choose Module</option>');
        var options = [];

        for (var mod in modules[0].companyModules) {
            $("#cmbModule").append('<option id="' + modules[0].companyModules[mod].moduleId + '">' + modules[0].companyModules[mod].moduleName + '</option></select>');
        }
        ModulesHandler();
    }

    function ModulesHandler() {

        $('#cmbModule').change(function () {
        if($("#pageing").hide()){$("#pageing").show()};
            var selected = $(this).children(':selected').attr('id');
            var caption = new IndexValue();
            currentPage = parseInt($('#currentPage').val());
            pageSize = parseInt($('#pageSize').val());
            caption.GetIndexValue(selected, currentPage, pageSize);
        });    
    }
}