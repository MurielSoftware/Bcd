(function ($) {
    $.ajaxSetup({
        cache: false
    });

    $.fn.dialog = function () {
        return this.each(function (index, dialog) {
            $(dialog).click(function () {
                $("#modal-dialogs").load($(dialog).attr("href"), function (result) {
                    //initializePlugins("#modal-dialogs");
                    //_onInit(dialog);
                    var closeButton = $("#modal-dialogs").find(".btn-dialog-close");
                    var removeFileButton = $("#modal-dialogs").find(".btn-modal-remove-attachement");
                    var submitButton = $("#modal-dialogs").find(".asynchronous-form");

                    closeButton.click(_close);
                    removeFileButton.click(_removeFile);
                    submitButton.submit(_submit);
                });

            });
        });

        function _close() {
            $("#modal-dialogs").empty();
        }

        function _removeFile() {
            _onRemoveFile($(this));
        }

        function _submit(e) {
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
            e.preventDefault();
        }


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
                _onSuccess(data);
            } else {
                _onFail(data);
            }
        }

        function _onSuccess(data) {
            switch (data.RefreshMode) {
                case 1:
                case 2:
                    _onSuccessTable(data);
                    break;
                case 3:
                    _onSuccessTree(data);
                    break;
                case 3:
                    _onSuccessImageToRichTextBox(data);
                    break;
            }
        }

        function _onFail(data) {
            $("#" + data.TargetId).html(data.Message);
        }

        function _onSuccessTree(data) {
            $("#modal-dialogs").empty();
            $.expandTree(data.TargetId, true);
        }

        function _onSuccessImageToRichTextBox(data) {
            $("#modal-dialogs").empty();
            $.richTextBoxSetImage(data.ThumbnailPath, data.Path);
        }

        function _onSuccessTable(data) {
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