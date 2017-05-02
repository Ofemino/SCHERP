/**
 * Created by EntralogIT on 2017-05-01.
 */


$(document).ready(function () {

    var schoolStartTxt = $('input[name="SchoolStartTxt"]'); //our date input has the name "date"
    var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
    var options = {
        format: 'dd-mm-yyyy',
        container: container,
        todayHighlight: true,
        autoclose: true,
    };
    schoolStartTxt.datepicker(options);

    var schoolEndTxt = $('input[name="SchoolEndTxt"]'); //our date input has the name "date"
    var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
    var options = {
        format: 'dd-mm-yyyy',
        container: container,
        todayHighlight: true,
        autoclose: true,
    };
    schoolEndTxt.datepicker(options);



});

