var isSuccess = false;

$('#save').click(function () {
    var nationalId = $('#nationalNumber').val();
    var Email = $('#Email').val();
    var empID = $('#employeeID').val();
   // var returnUrl = $('#returnUrl').val();

    if (empID == null || empID == undefined || empID == '') {
        $.get('/checkBeforeInsertEmployee/' + nationalId + '/' + Email, function (result) {
            if (result == true) {
                $('#empForm').attr('action', '/InsertEmployee');
                isSuccess = true;
                $('#empForm').submit();
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
    }
    else {
        $('#empForm').attr('action', '/UpdateEmployee');
        $.get('/checkBeforeUpdateEmployee/' + empID + '/' + nationalId + '/' + Email, function (result) {
            if (result) {
                isSuccess = true;
                $('#empForm').submit();
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
    }
});