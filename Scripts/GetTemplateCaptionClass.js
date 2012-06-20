/// <reference path="jquery-1.7.2-vsdoc.js" />
function GetTemplateCaption(values) {

    this.TemplateCaptionAjax = TemplateCaptionAjax;
    this.values = values;
    var documents = {};
    var fields = {};
    var captions = {};

    function TemplateCaptionAjax(moduleId) {
        var jsonObject = { 'moduleId': moduleId };
        var json = {};
        $.ajax({
            url: "WebService.asmx/GetTemplateCaptionService",
            data: JSON.stringify(jsonObject),
            async: false,
            success: function (msg) {
                json = msg.d;
                for (var d in json) {
                    documents = json[d].documents;
                }
                for (var f in documents) {
                    fields = documents[f].fields;
                }
                for (var c in fields) {
                    captions[c] = fields[c].caption;
                }
            }
        });
        return json[0];
    }
}
