/// <reference path="jquery-1.7.2-vsdoc.js" />
//Paging current pagesize is set to 5
function Paging(moduleId, pageSize) {
    this.next = next;
    this.Previuos = Previous;
    this.index = document.getElementById('index');

    var btnNext = new Render().Button("next", "Next", "next");
    var btnPrev = new Render().Button("prev", "Previous", "prev", "previous()");


    /* Fetch current page and add 1 for paging, handler for next button, 
    create, remove and add Next and Previous buttons with handler.*/
    function next() {
        $("#next").remove();
        $('#pageing').append(btnNext);
        var prev = parseInt($("#currentPage").val());
        $('#next').click(function () {
            var newPage = parseInt($('#currentPage').val()) + 1;
            $("#currentPage").val(newPage);
            if ($("#index").text().length > 0) {
                $("#index").empty();
                var newNext = new IndexValue().GetIndexValue(moduleId, newPage, pageSize);
            }
        });
        if (prev >= 1) {
            $("#prev").die('click');
            Previous();
        }
    }
    function Previous() {
        $("#prev").remove();
        if (parseInt($("#currentPage").val()) > 1) {
            $('#pageing').append(btnPrev);
            $('#prev').live('click', function () {
                var prevPage = parseInt($('#currentPage').val()) - 1;
                $("#currentPage").val(prevPage);
                if ($("#index").text().length > 0) {
                    $("#index").empty();
                }
                if (prevPage >= 1) {
                    var prev = new IndexValue().GetIndexValue(moduleId, prevPage, pageSize);
                }
            });
        }
    }
}