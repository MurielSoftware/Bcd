(function ($) {
    $.ajaxSetup({
        cache: false
    });

    $.fn.dialog = function () {
        return this.each(function (index, dialog) {
            dialog.ready(function () {
            });

            dialog.on("click", ".btn-dialog-close", function (e) {
                $("#modal-dialogs").empty();
            });

            dialog.on("click", ".btn-modal-remove-attachement", function () {
                _onRemoveFile($(this));
            });


            dialog.on("submit", ".asynchronous-form", function (e) {
                var form = $(".asynchronous-form").get(0);
                var formData = new FormData(form);

                _appendFile(formData);

                var xhr = new XMLHttpRequest();
                xhr.open("post", form.action, true);
                xhr.upload.addEventListener('progress', function (event) {
                    if (event.lengthComputable) {
                        $("#modal-dialogs").find('.dialog-progress-bar').width((event.loaded / event.total) * 100 + "%");
                    }
                }, false);
                xhr.onreadystatechange = function () {
                    if (xhr.readyState == 4 && xhr.status == 200) {
                        _onFinish(JSON.parse(xhr.response), xhr.status, xhr);
                    }
                };
                xhr.send(formData);
            });
        });

        function _appendFile(formData) {
            var fileInput = document.getElementById("file-input");
            if (fileInput != null) {
                formData.append("file", fileInput.files[0]);
            }
        }

        function _onRemoveFile(removeButton) {
            $.post(removeButton.data("action"), { id: removeButton.data("id") }, function () {
                $(removeButton).parent().empty().append("<input type='file' name='file' id='file-input' />");
            })
        }

        function _onFinish(data, status, xhr) {
            if (data.Success) {
                _afterSuccess(data);
            } else {
                _afterFail(data);
            }
        }

        function _onSuccess(data) {
            switch (data.RefreshMode) {
                case 2:
                    _afterSuccessTree(data);
                    break;
                case 3:
                    _afterSuccessImageToRichTextBox(data);
                    break;
                default:
                    _afterSuccessTable(data);
                    break;
            }
        }

        function _afterFail(data) {
            $("#" + data.TargetId).html(data.Message);
        }

        function _afterSuccessTree(data) {
            $("#modal-dialogs").empty();
            $.expandTree(data.TargetId, true);
        }

        function _afterSuccessImageToRichTextBox(data) {
            $("#modal-dialogs").empty();
            $.richTextBoxSetImage(data.ThumbnailPath, data.Path);
        }

        function _afterSuccessTable(data) {
            if (data.TargetId != null) {
                $("#" + data.TargetId).html("<div id='loading'><i class='fa fa-circle-o-notch fa-spin'></i></div>");
                $.post(data.Action, function (result) {
                    $("#modal-dialogs").empty();
                    $("#" + data.TargetId).html(result);
                });
            } else {
                window.location.href = data.Action;
            }
        }
    }
}(jQuery));