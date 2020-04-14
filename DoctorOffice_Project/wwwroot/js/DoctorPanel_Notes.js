
function deleteNote(id) {
    $('#Modal').modal();
    $('#headerModal').addClass('alert alert-warning');
    $('#ModalTitle').html('هشدار!');
    $('#ModalBody').addClass('text-right');
    $('#ModalBody').html('<p>آیا از حذف این پرونده اطمینان دارید؟</p>');

    $('#AcceptDelete').click(function () {
        $.get('/DoctorPanel/DeleteNote/' + id, function (result) {
            if (result.statusCode == 200) {
                window.location.href = result.returnUrl;
            }
            else {
                $('#Modal').modal();
                $('#headerModal').addClass('alert alert-danger');
                $('#ModalTitle').html('هشدار!');
                $('#ModalBody').html('<p>خطا در حذف یاداشت!</p>');
                $('#btns').html('');
            }
        });
    });
}

$('#searchButton').click(function () {
    var searchContent = $('#searchContent').val();
    var tr = '';
    $('#noteList tbody').empty();

    $.get('/DoctorPanel/SearchNotes/' + searchContent, function (result) {

        if (result.statusCode == 200) {


            $.each(JSON.parse(result.responseText), function (key, value) {

                tr += '<tr>';

                tr += '<td>' + value.NoteID + '</td>';
                tr += '<td>' + value.TurnsID + '</td>';
                tr += '<td>' + value.noteTitle + '</td>';
                tr += '<td>' + value.doctorFullName + '</td>';
                tr += '<td>' + value.createDateTime + '</td>';

                if (window.location.href == 'https://localhost:44399/PatientsPanel/NoteList') {

                    tr += '<td> <a href="/PatientPanel/Details/' + value.NoteID + '" class="btn btn-sm btn-primary">جزييات</a> </td>'
                }
                else {
                    tr += '<td> <a href="/DoctorPanel/EditNote/' + value.NoteID + '" class="btn btn-sm btn-warning">ويرايش</a> <a onClick="deleteNote(' + value.NoteID + ')" class="btn btn-sm btn-danger">حذف</a> <a href="/DoctorPanel/Details/' + value.NoteID + '" class="btn btn-sm btn-primary">جزييات</a></td>';
                }

                tr += '</tr>';

            });


            $('#notFound').remove();
            $('#noteList tbody').html(tr);
        }
        else {
            var notFound = '<div id="notFound" class="container alert alert-danger text-center"><h4>!هيچ داده اي يافت نشد</h4></div>';
            $('#statusSearch').html(notFound);
            //$('#noteList ').addClass('text-center');
        }
    });
});