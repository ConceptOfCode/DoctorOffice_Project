$('#searchButton').click(function () {
    var fromDate = $('#fromDate').val();
    fromDate = fromDate.replace(/\//g, '$');
    var toDate = $('#toDate').val();
    toDate = toDate.replace(/\//g, '$');

    alert('fromDate ->' + fromDate + '%%' + 'toDate ->' + toDate);

    var tr = '';
    $('#noteList tbody').empty();

    $.get('/PatientPanel/SearchNote/' + (fromDate) + '/' + (toDate), function (result) {
        if (result.statusCode == 200) {

            $.each(JSON.parse(result.responseText), function (key, value) {

                tr += '<tr>';

                tr += '<td>' + value.NoteID + '</td>';
                tr += '<td>' + value.TurnsID + '</td>';
                tr += '<td>' + value.noteTitle + '</td>';
                tr += '<td>' + value.doctorFullName + '</td>';
                tr += '<td>' + value.createDateTime + '</td>';
                tr += '<td> <a href="/PatientPanel/Details/' + value.NoteID + '" class="btn btn-sm btn-primary">جزييات</a> </td>'

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
})

//function replace