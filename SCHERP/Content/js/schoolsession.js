/**
 * Created by Femi Adesanya on 2017-03-23.
 */
$(document).ready(function () {
    //alert("Working");
    var postSession = function (session_, year, term, schoolstart, schoolend, description, urlString) {
        var session = {
            Session: session_,
            Year: year,
            Term: term,
            SchoolStart: schoolstart,
            SchoolEnd: schoolend,
            Description: description
        };

        $.ajax({
            url: urlString,
            type: "POST",
            data: JSON.stringify(session),
            dataType: "json",
            traditional: true,
            contentType: "application/json; charset=utf-8",
            beforeSend: function () {
                //display Progress bar here
                $("#btnSession").addClass("disabled");
            },
            done: function () {
                //hide Progress bar here
                $("#btnSession").removeClass("disabled");
            },
            success: function (data) {
                if (data.msg == "1") {
                    swal({
                        title: "Success!",
                        text: data.Reason,
                        type: "success",
                        confirmButtonText: "Ok",
                        timer: 4000,
                        showConfirmButton: true
                    });
                } else if (data.msg == "0") {
                    swal({
                        title: "Warning!",
                        text: data.Reason,
                        type: "warning",
                        confirmButtonText: "Ok",
                        timer: 4000,
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
        console.log($("#Session").val() + ", " + $("#Year").val() + ", " + $("#Term").val() + ", " + $("#SchoolStart").val() + ", " + $("#SchoolEnd").val() + ", " + $("#TxtUrl").val());
        postSession($("#Session").val(), $("#Year").val(), $("#Term").val(), $("#SchoolStart").val(), $("#SchoolEnd").val(), $("#Description").val(), $("#TxtUrl").val());
    });


    var schoolStart = $('input[name="SchoolStart"]'); //our date input has the name "date"
    var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
    var options = {
        format: 'dd-mm-yyyy',
        container: container,
        todayHighlight: true,
        autoclose: true
    };
    schoolStart.datepicker(options);

    var schoolEnd = $('input[name="SchoolEnd"]'); //our date input has the name "date"
    var container1 = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
    var options1 = {
        format: 'dd-mm-yyyy',
        container: container1,
        todayHighlight: true,
        autoclose: true
    };
    schoolEnd.datepicker(options1);

});