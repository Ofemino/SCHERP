/**
 * Created by Femi Adesanya on 2017-03-23.
 */
$(document).ready(function () {
    //alert("ready");

});



$("#btnSession").click(function (e) {
    e.preventDefault();
    alert("Clicked!");
    $("#divLoader").show();
    postSession($("#SessionL").val(), $("#YearL").val(), $("#Term").val(), $("#SchoolStart").val(), $("#SchoolEnd").val(), $("#Description").text(), $("#TxtUrl").val());
    $("#divLoader").hide();
});
var postSession = function (session_, year, term, schoolstart, schoolend, description, urlString) {
    var session = {
        SessionL: session_,
        YearL: year,
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
            //$("#btnSession").addClass("disabled");
        },
        done: function () {
            //hide Progress bar here
            //$("#btnSession").removeClass("disabled");
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
};


$("#btnUpdateSession").click(function (e) {
    e.preventDefault();
    alert("Clicked!");
    $("#divLoader").show();
    updateSession($("#SessionL").val(), $("#YearL").val(), $("#Term").val(), $("#SchoolStart").val(), $("#SchoolEnd").val(), $("#Description").text(), $("#TxtUrl").val());
    $("#divLoader").hide();
});
var updateSession = function (session_1, year1, term1, schoolstart1, schoolend1, description1, urlString1) {
    var uSession = {
        SessionL: session_1,
        YearL: year1,
        Term: term1,
        SchoolStart: schoolstart1,
        SchoolEnd: schoolend1,
        Description: description1
    };

    $.ajax({
        url: urlString1,
        type: "POST",
        data: JSON.stringify(uSession),
        dataType: "json",
        traditional: true,
        contentType: "application/json; charset=utf-8",
        beforeSend: function () {
            //display Progress bar here
            //$("#btnSession").addClass("disabled");
        },
        done: function () {
            //hide Progress bar here
            //$("#btnSession").removeClass("disabled");
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
};



var schoolStart = $('input[name="SchoolStart"]'); //our date input has the name "date"
var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
var options = {
    format: 'mm/dd/yyyy',
    container: container,
    todayHighlight: true,
    autoclose: true
};
schoolStart.datepicker(options);

var schoolEnd = $('input[name="SchoolEnd"]'); //our date input has the name "date"
var container1 = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
var options1 = {
    format: 'mm/dd/yyyy',
    container: container1,
    todayHighlight: true,
    autoclose: true
};
schoolEnd.datepicker(options1);





