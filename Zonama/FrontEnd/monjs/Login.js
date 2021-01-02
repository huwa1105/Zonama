$(document).ready(function () {
    $('#login').click(function (e) {
        e.preventDefault();
        var data_user = { "log_username": $("#login-username").val(), "log_password": $("#login-password").val() };
        $.ajax({
            type: "POST",
            url: "/Login/Connexion",
            data: data_user,
            dataType: "text",
            success: function () {
                window.location.href = '/Home/Index';
            },
            error: function () {
                alert("Mauvais login ou password");
            }
        });
    });
});