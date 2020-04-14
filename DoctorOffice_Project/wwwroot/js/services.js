var content = '';
var counter = 0;
// $('#fullTextServices').keydown(function(){
//     content = $('#fullTextServices').text();

//     for(var i = 0; i<content.length; i++){
//         $('#counter').text(i);
//     }
// });

$('#fullTextServices').keydown(function (event) {
    if (event.key == 'Backspace' || event.key == 'Delete') {
        if (counter != 0) {
            counter -= 1;
        }
    }
    else {
        counter++;
    }

    if (counter > 160) {
        $('#fullTextServices').addClass('text-danger');
    }
    if (counter <= 160) {
        $('#fullTextServices').removeClass('text-danger');
    }
});

var Accepted = false;

$('#SaveService').click(function () {
    var isActive = $('#showInPage').prop('checked');
    if (isActive == false) {
        Accepted = true;
        $('#insertServices').submit();
    }
    else {
        $.get('/getCountServices', function (result) {
            if (result >= 6) {
                $('#Modal').modal();
                $('#ModalTitle').html('هشدار!');
                $('#headerModal').addClass('alert alert-danger');
                $('#headerModal button').addClass('text-right');
                $('#ModalBody').append('<p>تعداد خدمات ثبت شده به اندازه 6 عدد میباشد در صورت ذخیره کردن با این شرایط. قدیمی ترین خدمت حذف میگردد</p>');
                $('#ModalBody').addClass('text-right');
            }
            else {
                Accepted = true;
                $('#insertServices').submit();
            }
        });
    }
});

$('#Accept').click(function () {
    Accepted = true;
    $('#insertServices').submit();
});

function updateService (serviceID) {
    $.get('/IsExistsInSet/' + serviceID, function (result) {
        if (result == true) {
            Accepted = true;
            $('#updateServices').submit();
        }
        else {
            var isActive = $('#showInPage').prop('checked');
            if (isActive == false) {
                Accepted = true;
                $('#updateServices').submit();
            }
            else {
                $.get('/getCountServices', function (result) {
                    if (result >= 6) {
                        $('#Modal').modal();
                        $('#ModalTitle').html('هشدار!');
                        $('#headerModal').addClass('alert alert-danger');
                        $('#headerModal button').addClass('text-right');
                        $('#ModalBody').append('<p>تعداد خدمات ثبت شده به اندازه 6 عدد میباشد در صورت ذخیره کردن با این شرایط. قدیمی ترین خدمت حذف میگردد</p>');
                        $('#ModalBody').addClass('text-right');
                    }
                    else {
                        Accepted = true;
                        $('#updateServices').submit();
                    }
                });
            }
        }
    });
}

$('#AcceptUpdate').click(function () {
    Accepted = true;
    $('#updateServices').submit();
});