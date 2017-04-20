
$(document).ready(function () {
    var suggestions = [
        { id: "1", label: "Alaska" },
        { id: "2", label: "Alabama" },
        { id: "3", label: "Arkansas" },
        { id: "4", label: "Arizona" },
        { id: "5", label: "California" },
        { id: "6", label: "Colorado" }
    ];

    var autocomplete = $(".autocomplete > .input-autocomplete-frame");
    var input = $(".autocomplete > .input-autocomplete-frame > .input-autocomplete");
    var hidden = $(".autocomplete > .input-autocomplete-hidden");
    var list = $(".autocomplete > .input-autocomplete-frame > ul");

    var selectedIndex = -1;
    var selectedLiTag = "";
    var selectedObjects = {};

    input.keyup(function (e) {
        var str = $(this).val();
        list.css("width", autocomplete.width());
        list.css("display", "block");

        if (event.which == 40) {
            if (selectedLiTag == "") {
                selectedLiTag = $(list.find("li")[0]);
                selectedLiTag.addClass("select");
                selectedIndex++;
            } else {
                var next = $(selectedLiTag.next("li"));
                if (next.length != 0) {
                    selectedLiTag.removeClass("select");
                    next.addClass("select");
                    selectedLiTag = next;
                    selectedIndex++;
                    scrollToAnchor(selectedLiTag);
                }
            }
            return;
        }
        else if (event.which == 38) {
            if (selectedLiTag != "") {
                var prev = $(selectedLiTag.prev("li"));
                if (prev.length != 0) {
                    selectedLiTag.removeClass("select");
                    prev.addClass("select");
                    selectedLiTag = prev;
                    selectedIndex--;
                    scrollToAnchor(selectedLiTag);
                }
            }
            return;
        }
        else if (event.which == 13) {
            if (selectedLiTag != "") {
                attachToContainer(input, suggestions[selectedIndex].id, suggestions[selectedIndex].label);
                selectedObjects[suggestions[selectedIndex].id] = suggestions[selectedIndex].label;
                updateIds(hidden, selectedObjects);
                list.empty();
                input.val("");
                input.focus();
                selectedLiTag = "";
                selectedIndex = -1;
                list.css("display", "none");
            }
            return;
        }
        else if (event.which == 8) {
            if (str == "") {
                var prev = $(this).prev(".autocomplete-item");
                delete selectedObjects[prev.val()];
                prev.remove();
                updateIds(hidden, selectedObjects);
                list.css("display", "none");
                return;
            }
        }
        else if (event.which == 27) {
            list.css("display", "none");
        }

        list.empty();
        if (str !== "") {
            $.each(suggestions, function (index, item) {
                if (item.label.toLowerCase().indexOf(str.toLowerCase()) !== -1) {
                    list.append("<li>" + item.label + "</li>");
                }
            });

            $(".autocomplete li").click(function () {
                selectedIndex = $(this).index();
                attachToContainer(input, suggestions[selectedIndex].id, suggestions[selectedIndex].label);
                selectedObjects[suggestions[selectedIndex].id] = suggestions[selectedIndex].label;
                updateIds(hidden, selectedObjects);
                input.val("");
                input.focus();
                list.empty();
                selectedLiTag = "";
                selectedIndex = -1;
                list.css("display", "none");
            });
        }
    });
});

function attachToContainer(input, id, label) {
    $("<div></div>")
        .addClass("autocomplete-item")
        .val(id)
        .append(label)
        .append(
            $("<i></i>")
                .addClass("autocomplete-remove fa fa-remove")
                .click(function () {
                    var item = $(this).parent();
                    delete selectedObjects[id];
                    item.remove();
                    updateIds(hidden, selectedObjects);
                  //  list.css("display", "none");
                })
            )
        .insertBefore(input);
}

function updateIds(hidden, items) {
    var ids = "";
    for (id in items) {
        ids = ids + id + ":" + items[id] + ";"
    }
    hidden.val(ids);
}

function scrollToAnchor(aid) {
    $(".autocomplete ul").animate({ scrollTop: aid.position().top }, "fast");
} 