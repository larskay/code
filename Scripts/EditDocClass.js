/// <reference path="jquery-1.7.2-vsdoc.js" />
function EditDocClass(fields, values) {

    this.EditCaption = EditCaption;
    this.EditType = EditType;
    this.EditValues = EditValues;
    this.BuildDropDownList = BuildDropDownList;

    var caption = {}, labels = {}, vals = {}, types = {};
    var page = {};

    function EditCaption() {
        for (var c in fields) {
            caption[c] = fields[c].caption;
        }
        for (var l in caption) {
            labels[l] = '<div id="field' + fields[l].fieldId + '><div id="lblfield' + fields[l].fieldId + '>' + caption[l] + '</div></div>';
        }
        return labels;
    }
    function EditType() {
        for (var t in fields) {
            types[t] = fields[t].type;
        }
        for (var l in types) {
            switch (types[l]) {
                case "String<=255": var stringValue = EditValues(fields[l].fieldId, values);
                    page[l] = '<input type="text" id="valfield' + fields[l].fieldId + '" value="'+ stringValue +'" /><br>';
                    break;
                case "String>=255": var textAreaValue = EditValues(fields[l].fieldId, values);
                    page[l] = '<textarea id="valfield' + fields[l].fieldId + '">'+ textAreaValue +'</textarea><br>';
                    break;
                case "Number": var numberValue = EditValues(fields[l].fieldId, values);
                    page[l] = '<input type="number" id="valfield' + fields[l].fieldId + '" value="'+ numberValue +'" /><br>';
                    break;
                case "GMSList": var gmsList = EditValues(fields[l].fieldId, values);
                    page[l] = '<select id="valfield' + fields[l].fieldId + '"><option id="' + gmsList + '">' + gmsList + '</option></select><br>';
                    gmsListValues = BuildDropDownList(fields[l].fieldId, fields);
                    var options = {};
                    for (var i in gmsListValues) {
                        options[i] = gmsListValues[i].dropdownValue;
                    }
                    for (var v in options) {
                        page[l] += '<option id="' + options[i] + '">' + options[i] + '</option>';
                    }
                    break;
                case "GMSRadio": page[l] = '<input type="radio" id="valfield' + fields[l].fieldId + '" /><br>';
                    break;
                case "GMSCheckList": page[l] = '<input type="checkbox" id="valfield' + fields[l].fieldId + '" /><br>';
                    break;
                case "GMSDate": var date = EditValues(fields[l].fieldId, values);
                    page[l] = '<input type="date" id="valfield' + fields[l].fieldId + '" value="' + date + '" /><br>';
                    break;
            }
        }
        return page;
    }
    function EditValues(fieldId, values) {
        for (var f in values) {
            var fields = values[f].fields;
        }
        for (var v in fields) {
            if (fields[v].fieldId === fieldId) {
                return fields[v].value;           
            }
        }
    }
    function BuildRadioButtons(radioField, radioValue) {
        console.log(radioField);
        console.log(radioValue);
    }
    function BuildCheckButtons(fieldId) { 
        console.log(fieldId);
    }
    function BuildDropDownList(fieldId, fields) {
        console.log(fields);
        var dvalue = {};
        dvalue = fields[fieldId].dropdowns;
        console.log(dvalue);
        return dvalue;
    }
}