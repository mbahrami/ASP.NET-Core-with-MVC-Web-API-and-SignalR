// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function toggleLED1() {
    var dto = {
        "id": 1,
        "name": "LED1",
        "value": 0
    };

    if (document.getElementById("chkLED1").checked) {
        dto.value = 1;
    }

    $.ajax({
        type: "PUT",
        url: "/api/led1",
        data: JSON.stringify(dto),
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    });
}

