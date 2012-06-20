/// <reference path="jquery-1.7.2-vsdoc.js" />
function IndexValue() {
    
    this.GetIndexValue = GetIndexValue;
    this.RenderIndex = RenderIndex;

    
    //Fetch index of documents for each module
    function GetIndexValue(moduleId, pageNumber, pageSize) {
        this.moduleId = moduleId;

        var module = { 'moduleId': this.moduleId, 'pageSize': pageSize, 'pageNumber': pageNumber };
        $.ajax({
            url: "WebService.asmx/IndexService",
            data: JSON.stringify(module),
            success: function (msg) {
                var paging = new Paging(moduleId, pageSize);
                if (msg.d.length > 0 && msg.d.length <= 5) {
                    RenderIndex(msg.d);
                    paging.next();
                    if (msg.d.length < 5) {
                        $("#next").remove();
                    }
                }
                else {
                    return false;
                }
            }


        });
        
    }

    function RenderIndex(indexValues) {
        $("#caption").empty();

        RenderCaption(indexValues);
        
        var docs = {};
        var fields = {};
        $("#index").empty();
        $("#newPage").empty();
        for (var i = 0; i < indexValues.length; i++) {
            $("#index").append('<div id="Valfield' + indexValues[i].documentId + '">');
            for (var j = 0; j < 2; j++) {
                for (var k in indexValues[i].fields[j].value) {
                    $('#Valfield'+ indexValues[i].documentId).append('<div class="index">'+ indexValues[i].fields[j].value[k] +'<div>');
                }
            }
            $('#Valfield' + indexValues[i].documentId).append('</div><br />');
            //$("#show").append('<div id="show' + indexValues[i].documentId + '" class="show"></div>');
            
            $("#index").append(new Render().Button(indexValues[i].documentId, "Vis", "vis" ,"show"));
        }
        this.visButtonClick = $("input[name=vis]").die('click').live('click', function () {
            var view = new View(indexValues).RenderView(this.id);
        });
    }

    function RenderCaption(indexValues) {
        var caption = new GetTemplateCaption().TemplateCaptionAjax(indexValues[0].moduleId);
        for (var f in caption) {
            var captionFields = caption.documents[0].fields;
        }
        for (var c = 0; c < 2; c++) {
            $("#caption").append('<div class="left">' + captionFields[c].caption + '</div>');
        }
        $("#caption").append('<br>');
    }
}
