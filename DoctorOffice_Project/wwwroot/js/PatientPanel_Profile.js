var isSuccess = false;

$('#save').click(function () {
    var nationalId = $('#nationalNumber').val();
    var Email = $('#Email').val();
    var patientsID = $('#patientsID').val();

    $.get('/checkBeforeUpdatePatients/' + patientsID + '/' + nationalId + '/' + Email, function (result) {
        if (result) {
            isSuccess = true;
            $('#ptnForm').submit();
        }
        else {
            $('#Modal').modal();
            $('#ModalTitle').html('هشدار!');
            $('#headerModal').addClass('alert alert-danger');
            // $('#headerModal button').addClass('text-right');
            $('#ModalBody').html('<p>اطلاعات وارد شده در دیتابیس موجود و متعلق به شخص دیگیری است لظفا در ورود اطلاعات دقت کنید</p>');
            $('#ModalBody').addClass('text-right');
        }
    });
});