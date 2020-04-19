$('#searchButton').click(function () {
    var Date = $('#dateBox').val();
    Date = Date.replace(/\//g, '$');
    var tr = '';
    $('#reserveList tbody').empty();

    $.get('/PatientsPanel/searchReserve/' + Date, function (result) {
        if (result.statusCode == 200) {
            $.each(JSON.parse(result.responseText), function (key, value) {

                tr += '<tr>';

                tr += '<td>' + value.turnsID + '</td>';
                tr += '<td>' + value.reserveDate + '</td>';
                tr += '<td>' + value.currentDate + '</td>';
                tr += '<td>' + value.doctorFullName + '</td>';
                tr += '<td><a href="/PatientsPanel/ReserveDetails/' + value.turnsID + '" class="btn btn-sm btn btn-primary">جزییات</a></td>';

                tr += '</tr>';
            });
            $('#reserveList tbody').html(tr);
        }
        else {
            var errorContent = '<div class="alert alert-danger text-center"><h4>هیچ داده ای یافت نشد!</h4></div>';
            $('#statusSearch').html(errorContent);
        }
    });
});