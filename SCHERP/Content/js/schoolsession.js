/**
 * Created by Femi Adesanya on 2017-03-23.
 */
$(document).ready(function () {
    //alert("Working");
    var postSession = function (session, year, term, description, urlString) {
        var sessionData = {
            Session: session,
            Year: year,
            Term: term,
            Description: description
        };

        $.ajax({
            url: urlString,
            type: "POST",
            data: JSON.stringify(sessionData),
            dataType: "json",
            traditional: true,
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.msg == "1") {
                    swal({
                        title: "Success!",
                        text: data.Reason,
                        type: "success",
                        confirmButtonText: "Ok",
                        timer: 2000,
                        showConfirmButton: true
                    });
                } else if (data.msg == "0") {
                    swal({
                        title: "Warning!",
                        text: data.Reason,
                        type: "warning",
                        confirmButtonText: "Ok",
                        timer: 2000,
                        showConfirmButton: true
                    });
                }
            },
            error: function (data) {
                swal({
                    title: "Error!",
                    text: data.Reason,
                    type: "error",
                    confirmButtonText: "Ok",
                    timer: 2000,
                    showConfirmButton: true
                });
            }
        });
    }
    $("#btnSession").click(function (e) {
        e.preventDefault();
        postSession($("#Session").val(), $("#Year").val(), $("#Term").val(), $("#Description").val(), $("#TxtUrl").val());


    });




});