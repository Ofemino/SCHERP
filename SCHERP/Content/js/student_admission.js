/**
 * Created by Femi Adesanya on 2017-03-23.
 */


doAlert();
function doAlert() {
    $(function () {
        //showPromptWithInputRequest("This is a test in admission","", "Enter a value", "input")
    });
}

$(document).ready(function () {

    var date_input = $('input[name="Dob"]'); //our date input has the name "date"
    var container = $('.bootstrap-iso form').length > 0 ? $('.bootstrap-iso form').parent() : "body";
    var options = {
        format: 'dd-mm-yyyy',
        container: container,
        todayHighlight: true,
        autoclose: true
    };
    date_input.datepicker(options);

    // with plugin options
    $("#Avatar").fileinput({
        //'showUpload': false,
        'previewFileType': 'any'
    });



});





