(function ($) {
    $.fn.inlineEditable = function () {
        $(this).click(function () {
            _set($(this));
        });

        function _set(obj) {
            $(obj).css("display", "none");
            $(obj).next().css("display", "block");

            var input = $(obj).next().find("input");
            $(input).focus();

            $(input).keydown(function (e) {
                if (e.keyCode == 9) {
                    var fields = $(this).parents('form:eq(0),body').find('.form-control-editable');
                    var index = fields.index($(obj));
                    if (index > -1 && (index + 1) < fields.length) {
                        _set(fields.eq(index + 1));
                    }
                    e.preventDefault();
                }
            });
        }

        $(".form-control-editable").mouseenter(function () {
            $(this).prev().slideToggle();
        });
        $(".form-control-editable").mouseleave(function () {
            $(".form-control-editable-icon").hide();
            //$(this).prev().hide();
        });
    }
}(jQuery));