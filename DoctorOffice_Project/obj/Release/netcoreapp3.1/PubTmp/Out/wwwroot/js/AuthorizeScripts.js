var IsSuccess = false;

$('#save').click(function () {
    var email = $('#email').val();
    $.get("/checkUserBeforCreate/" + email, function (result) {
        if (result == true) {
            $('#Modal').modal();
            $('#ModalTitle').text('هشدار!');
            $('#ModalTitle').addClass('text-danger');
            $('#ModalBody').html('<p>یک کاربر با همین مشخصات در سیستم موجود است</p>');
        }
        else {
            IsSuccess = true;
            $('#usersForm').submit();
        }
    });
});