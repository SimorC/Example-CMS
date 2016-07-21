function callAlert(title, msg, isSuccess) {
    var idAlert = isSuccess ? "#alert-success" : "#alert-danger";

    $(".alert-title").html(title);
    $(".alert-message").html(msg);

    $(idAlert).fadeTo(500, 1000).fadeOut(10000, function () {
        $(idAlert).alert("close");
    });
}