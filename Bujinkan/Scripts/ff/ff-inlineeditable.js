(function ($) {
    $.fn.inlineEditable = function () {
        $(this).click(function () {
            $(this).css("display", "none");
            $(this).next().css("display", "block");
        });
    }
}(jQuery));