function showDetailsMemories(memoriesID) {
    $.get('/secretaryPanel/MemoriesDetails/' + memoriesID, function (response) {
        $('#Modal').modal();
        // $('#headerModal').addClass('alert alert-warning');
        //$('#ModalTitle').html('هشدار!');
        // $('#ModalBody').addClass('text-right');
        $('#ModalBody').html(response);
    });
}

$(document).ready(function () {
    var tr = '';

    $.get('/secretaryPanel/getListMemories', function (responce) {
        if (responce.statusCode == 200) {

            //$.get('/secretaryPanel/getEnableMemories', function (result) {

            //});

            // alert(responce.responseText);

            $.each(JSON.parse(responce.responseText), function (key, value) {

                tr += '<tr>';

                tr += '<td>' + value.memoriesID + '</td>';
                tr += '<td>' + value.patientsID + '</td>';
                tr += '<td>' + value.fullNamePatient + '</td>';
                tr += '<td>' + value.PatientsNationalNumber + '</td>';
                tr += '<td>' + value.memoriesTitle + '</td>';
                tr += '<td>' + value.createDateTime + '</td>';

                tr += '<td> <a onClick="showDetailsMemories(' + value.memoriesID + ')" class="btn btn-sm btn-primary">جزییات</a>' + (value.memoriesTitle.includes('$%#')) ? ' <a class="btn btn-sm btn-success">انتشار نظر</a>' : ' <a class="btn btn-sm btn-danger">عدم انتشار</a>';

                if (value.memoriesTitle.includes('$%#') == false) {
                    tr += '<td> <a onClick="showDetailsMemories(' + value.memoriesID + ')" class="btn btn-sm btn-primary">جزییات</a> <a href="/secretaryPanel/rendering/' + value.memoriesID + '/true" class="btn btn-sm btn-success" >انتشار نظر</a >';
                }
                else {
                    tr += '<td> <a onClick="showDetailsMemories(' + value.memoriesID + ')" class="btn btn-sm btn-primary">جزییات</a> <a href="/secretaryPanel/rendering/' + value.memoriesID + '/false" class="btn btn-sm btn-danger" >عدم انتشار نظر</a >';
                }

                tr += '</tr>';

            });

          //  alert(tr);

            $('#memoriesList tbody').html(tr);
        }
    });
});