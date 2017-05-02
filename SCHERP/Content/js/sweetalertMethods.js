/**
 * Created by Femi Adesanya on 2017-03-23.
 */


function showInfoMessageWithHtml(title, type, html) {
    swal({
        title: title,
        type: type,
        html: html,
        showCloseButton: true,
        showCancelButton: false,
        confirmButtonText: '<i class="glyphicon glyphicon-ok"></i>&nbsp;OK',
        cancelButtonText: '<i class="glyphicon glyphicon-remove"> CANCEL</i>'
    })
}


function showPromptWithInputRequest(title, textMsg, textPlaceholder, type){
    swal({
        title: title,
        text: textMsg,
        type: type,
        inputPlaceholder: textPlaceholder,
        showCancelButton: true,
        closeOnConfirm: false,
    }, function (inputValue) {
        if (inputValue === false) return false;
        if (inputValue === "") {
            swal.showInputError("You need to write something!");
            return false
        }
        swal("Nice!", "You wrote: " + inputValue, "success");
    });
}