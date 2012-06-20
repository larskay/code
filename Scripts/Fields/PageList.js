/// <reference path="../jquery-1.7.2-vsdoc.js" />
function PageList() {

    this.RenderPageName = RenderPageName;
    this.RenderStringLess255 = RenderStringLess255;
    this.RenderStringGreater255 = RenderStringGreater255;
    this.RenderNumber = RenderNumber;
    this.RenderGMSUserList = RenderGMSUserList;
    this.RenderGMSRadio = RenderGMSRadio;


    var pn = { 'type': type,
        'id': id,
        'value': value,
        'caption': caption,
        '_class': 'required'
    };

    function RenderPageName(id, caption, value) {
        $("#newPage").append('<div id="field'+ pn.id +'"><label for="' + pn.id + '"><input type="text" id="' + pn.id + '" class="' + pn._class + '" />' + + '</label></div>');
    }
    function RenderStringLess255(id, caption, value) {
        $("#newPage").append('<div id="field'+ pn.id +'"><label for="' + pn.id + '"><input type="text" id="' + pn.id + '" class="' + pn._class + '" />' + + '</label></div>');
    }
    function RenderStringGreater255(id, caption, value) {
        $("#newPage").append('<div id="field'+ pn.id +'"><label for="' + pn.id + '"><textarea id="' + pn.id + '" class="' + pn._class + '">' + + '</textarea></label></div>');
    }
    function RenderNumber(id, caption, value) {
        $("#newPage").append('<div id="field'+ pn.id +'"><label for="' + pn.id + '"><input type="number" id="' + pn.id + '" class="' + pn._class + '" />' + +'</label></div>');
    }
    function RenderGMSUserList(id, caption, value, dropdown) {
        $("#newPage").append('<div id="field'+ pn.id +'"><label for="' + pn.id + '"><select id="' + pn.id + '" class="' + pn._class + '">');
        for (var d in dropdown) {
            $(pn.id).append('<option id="' + dropdown[d].dropDownId + '">' + dropdown[d].dropDownValue + '</option>');
        }
        $(pn.id).append('</select></div>');
    }
    function RenderGMSRadio(id, caption, value) {
        
    }
}