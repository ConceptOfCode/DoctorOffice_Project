var id = 1;
function generateID() {
    id++;
}
$('#addMedicine').click(function () {
    if (id == 1) {
        $('#medicineFinalList tbody').append('<tr>');
        // $('#medicineFinalList tbody').append('<td><input type="checkbox" id="' + id + 'check" </td>');
        $('#medicineFinalList tbody').append('<td><input type=text" class="form-control" name="medicines[' + (id - 1) + '].turnsID" value="' + $('#turnsID').text() + '"></td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].medicineName" value="' + $('#enterMedicine :text:first').val() + '"></td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].howUseText" value="' + $('#enterMedicine textarea').val() + '"></td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].fromDate" value="' + $('#fromDate').val() + ' "></td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].toDate" value="' + $('#toDate').val() + '"> </td>');
        $('#medicineFinalList tbody').append('</tr>');
    }
    else {
        // $('#medicineFinalList tbody').append('<tr>');
        // $('#medicineFinalList tbody').append('<td>' + id + '</td>');
        // $('#medicineFinalList tbody').append('<td>' + $('#' + id +' :text:first').val() + '</td>');
        // $('#medicineFinalList tbody').append('<td>' + $('#'+ id +' textarea').val() + '</td>');
        // $('#medicineFinalList tbody').append('<td> <a class="btn btn-danger btn-sm">حذف</a> </td>');
        // $('#medicineFinalList tbody').append('</tr>');
        $('#medicineFinalList tbody').append('<tr>');
        // $('#medicineFinalList tbody').append('<td><input type="checkbox" id="' + id + 'check" </td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].turnsID" value="' + $('#turnsID').text() + '"></td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].medicineName" value="' + $('#' + id + ' :text:first').val() + '"></td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].howUseText" value="' + $('#' + id + ' textarea').val() + '"></td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].fromDate" value="' + $('#' + id + 'fromDate').val() + ' "></td>');
        $('#medicineFinalList tbody').append('<td><input type="text" class="form-control" name="medicines[' + (id - 1) + '].toDate" value="' + $('#' + id + 'toDate').val() + '"> </td>');
        $('#medicineFinalList tbody').append('</tr>');
    }

    generateID();
    $('#contentMedicine').append(' <div id="' + id + '" class="row col-xl-6 col-md-6 col-sm-6 col-lg-6"><label>نام دارو : </label><input type="text" name="" id="" class="form-control"><label>طریقه مصرف دارو : </label><textarea name="" id="" cols="30" rows="10"class="form-control"></textarea><section class="col-xl-6 col-lg-6 col-md-6 col-sm-6"><input type="text" name="" id="' + id + 'fromDate" class="form-control" placeholder="از تاریخ : "></section><section class="col-xl-6 col-lg-6 col-md-6 col-sm-6" ><input type="text" name="" id="' + id + 'toDate" class="form-control" placeholder="تا تاریخ : "></section><br>');
});

$('#SavePrescription').click(function () {
    //var medicineData = [];
    //$.each($('#medicineFinalList tbody tr'), function (key, value) {
    //    medicineData[key] = {value}
    //});
    ////alert('dsd');

    $('#medicineInfo').submit();
});


function deleteMedicines(prescriptionID, turnsID) {
    $('#Modal').modal();
    $('#headerModal').addClass('alert alert-warning');
    $('#ModalTitle').html('هشدار!');
    $('#ModalBody').html('<p>آیا از حذف این نسخه اطمینان دارید؟</p>');
    $('#ModalBody').addClass('text-right');

    $('#AcceptDelete').click(function () {
        $.get('/DoctorPanel/DeleteMedicine/' + prescriptionID + '/' + turnsID, function (result) {
            if (result.statusCode == 200) {
                window.location.href = result.returnUrl;
            }
            else {
                $('#Modal').modal();
                $('#headerModal').addClass('alert alert-danger');
                $('#ModalTitle').html('خطا در حذف!');
                $('#ModalBody').html('<p>یک خطا هنگام حذف رخ داده است</p>');
                $('#ModalBody').addClass('text-right');
                $('#btns').html('');
            }
        });
    });
}


$('#searchButton').click(function () {
    var Content = $('#SearchPrescriptionValue').val();
    var tr = '';
    $.get('/DoctorPanel/SearchPrescription/' + Content, function (result) {

        $('#reserveList tbody').empty();
        if (result.statusCode == 200) {
            $.each(JSON.parse(result.responseText), function (key, value) {
                tr += '<tr>';

                tr += '<td>' + value.turnsID + '</td>';
                tr += '<td>' + ((value.patientFullName != '' || value.patientFullName != null) ? value.patientFullName : value.temporaryPatientFullName) + '</td>';
                tr += '<td>' + ((value.PatientNationalID != null) ? value.PatientNationalID : value.temporaryPatientNationalID) + '</td>';
                tr += '<td>' + value.createDateTime + '</td>';
                tr += '<td>' + value.doctorFullNasme + '</td>';
                tr += '<td><a href="/DoctorPanel/EditPrescription/' + value.PrescriptionsID + '" class="btn btn-sm btn-warning">ویرایش</a>  <a onClick="deleteMedicines(' + value.PrescriptionsID + ',' + value.turnsID + ')" class="btn btn-sm btn-danger">حذف</a></td>';
               // tr += '<td><a onClick="deleteMedicines(' + value.PrescriptionsID + ',' + value.turnsID + ')" class="btn btn-sm btn-danger">حذف</a></td>';

                tr += '</tr>';
            });

            $('#reserveList tbody').html(tr);
        }
        else {
            $('#Modal').modal();
            $('#headerModal').addClass('alert alert-primary');
            $('#ModalTitle').html('بدون نتیجه!');
            $('#ModalBody').html('<p>برای شماره ملی وارد شده هیچ نسخه ای وجود ندارد</p>');
            $('#ModalBody').addClass('text-right');   
            $('#btns').html('<button type="button" class="btn btn-secondary" data-dismiss="modal">بستن</button>');
        }
    });
});