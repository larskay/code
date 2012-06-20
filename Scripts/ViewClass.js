/// <reference path="jquery-1.7.2-vsdoc.js" />
function View(values) {

    this.RenderView = RenderView;
    this.GetCaption = GetCaption;
    this.GetValues = GetValues;
    this.ClearPage = ClearPage;
    this.values = values;

    var documents = {},fields = {},tempFields = {},value = {},tempId = {},cap = {};
    var captions = new GetTemplateCaption(this.values).TemplateCaptionAjax(this.values[0].moduleId);
    ClearPage('caption');

    function ClearPage(div) {
        switch(div)
        {
            case 'pageing': $("#pageing").hide();
                break;
            case 'caption': $("#caption").empty();
                break;
            case 'index': $("#index").empty();
                break;
        }
    }

    function GetCaption() {
        
        fields = captions.documents[0].fields;
            for (var c in fields) {
                cap[c] = fields[c].caption;
            }
        return cap;
    }

    function GetValues() {

        for (var f in values) {
            for (var i in values[f].fields) {
                value[i] = values[f].fields[i].value;
            }
        }
        return value;
    }

    function RenderView(docId) {
        ClearPage('index');
        ClearPage('pageing');
        
        var tempCap = GetCaption();
        var indValue = GetValues();
        var type = {};
        console.log(fields);
        console.log(values);
        for (var c in tempCap) {
            $('#index').append('<div id="lblfield' + fields[c].fieldId + '">' + tempCap[c] + '</div>');
        }
        for (var v in indValue) {
            $('#lblfield' + fields[v].fieldId).append('<div id="valfield' + fields[v].fieldId + '">' + indValue[v] + '</div>');
        }
        $("#index").append(new Render().Button(docId, 'Edit', 'edit', 'edit'));
        $("input[name=edit]").click(function () {
            var edit = new EditDocClass(fields, values);
            var label = edit.EditCaption();
            type = edit.EditType();
            console.log(type);
            $("#index").empty();
            var div = document.getElementById('newPage');
            for (var i in type) {
                $(div).append('<label for="valfield' + fields[i].fieldId + '">' + fields[i].caption + '</label>');
                $(div).append(type[i]);
            }
        });
        

    }
}