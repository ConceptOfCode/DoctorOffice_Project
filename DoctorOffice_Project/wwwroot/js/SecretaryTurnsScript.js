$('#TurnssearchButton').click(function () {
    var searchContent = $('#TurnsDateBoxSearch').val();
    var tr = '';
    $('#reserveList tbody').empty();
    $.get('/searchListTurns/' + searchContent, function (result) {
        $.each(result, function (key, value) {
            tr += '<tr>';

            tr += '<td>' + value.turnsID + '</td>';
            tr += '<td>' + value.reserveDate + '</td>';
            tr += '<td>' + value.currentDate + '</td>';
            tr += '<td>' + value.doctorFullName + '</td>';
            tr += '<td><a href="/doctorPanel/reserveDetails/' + value.turnsID + '" class="btn btn-sm btn btn-primary">جزییات</a></td>';
            tr += '<td><a href="/DoctorPanel/newNote/' + value.turnsID + '" class="btn btn-sm btn btn-primary">ثبت یاداشت</a></td>';
            tr += '<td><a href="/Clinic/' + value.turnsID + '" class="btn btn-sm btn btn-primary">ثبت نسخه</a></td>';

            tr += '</tr>';
        });
        $('#reserveList tbody').append(tr);
    });
});