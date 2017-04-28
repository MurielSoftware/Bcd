$(document).ready(function () {
    $(".notification").fadeIn(1000);
    $(".notification").fadeOut(5000);

    $(".form-control-editable").inlineEditable();
    //$(".autocomplete").autocomplete();
    //$(".referencelist").referenceList();
    //$(".remotecontent").remoteContent();
    $(".remotecontent").remoteContent();
    //$("body").on("click", ".show-dialog", function () {
    //    $.openDialog($(this));
    //});
    //$(".show-dialog").dialog();
    //$("body").on("click", ".show-dialog", function () {
    //    $(this).dialog();
    //})
    
    initPluginsOnRemoteContent();
});

function initPluginsOnRemoteContent() {
    $(".autocomplete").autocomplete();
    $(".referencelist").referenceList();
    
}