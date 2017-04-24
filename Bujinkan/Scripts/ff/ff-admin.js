$(document).ready(function () {
    $(".form-control-editable").inlineEditable();
    $(".autocomplete").autocomplete();
    $(".referencelist").referenceList();
    $(".remotecontent").remoteContent();

    //$("body").on("click", ".show-dialog", function () {
    //    $.openDialog($(this));
    //});

    $(".show-dialog").dialog();
});