var isSuccess = false;

$('#patientsSave').on('click', isExistsPatients);

function isExistsPatients() {
    var nationalID = $('#nationalNumber').val();
    $.get('/isExitsPatients/' + nationalID, function (result) {
        if (result == true) {
            $('#Modal').modal();
            $('#headerModal').addClass('alert alert-danger');
            $('#ModalTitle').html('هشدار!');
            $('#ModalBody').append('<p>یک مریض با همین مشخصات در بانک اطلاعاتی موجود میباشد</p>');
        }
        else {
            isSuccess = true;
            $('#insertPatients').submit();
        }
    });
}


$('#patientsEdit').on('click', checkForEdit);

function checkForEdit() {
    var patientsID = $('#patientsID').val();
    var nationalID = $('#nationalNumber').val();

    $.get('/checkForEdit/' + patientsID + '/' + nationalID, function (result) {
        if (result == false) {
            $('#Modal').modal();
            $('#headerModal').addClass('alert alert-danger');
            $('#ModalTitle').html('هشدار!');
            $('#ModalBody').append('<p>شماره ملی که شما قصد ثبت کردن آن را دارید متعلق به شخص دیگری است</p>');
        }
        else {
            isSuccess = true;
            $('#UpdatePatients').submit();
        }
    });
}

var patientsID = 0;
function deletePatients(patientsIDParam) {
    patientsID = patientsIDParam;
    $('#Modal').modal();
    $('#headerModal').addClass('alert alert-warning');
    $('#ModalTitle').html('هشدار!');
    $('#ModalBody').append('<p>آیا از حذف این پرونده اطمینان دارید؟</p>');
}

$('#AcceptDelete').on('click', deletePatientsFromDB);

function deletePatientsFromDB() {
    $.post('/DoctorPanel/DeletePatients/' + patientsID, function (result) {
        window.location.href = result;
    });
}

//@foreach(var item in Model)
//{
//    <tr>
//        <td>@item.patientsID</td>
//        <td><img src="~/uploadImages/@item.imageName" alt="عکس موجود نیست" title="عکس مریض" class="img-responsive img-thumbnail" style="max-width:5em !important; max-height:60px;" /></td>
//        <td>@item.nationalNumber</td>
//        <td>@item.firstName @item.lastName</td>
//        <td>@item.fatherName</td>
//        <td>@item.birthDate</td>
//        <td>
//            <a asp-controller="patients" asp-action="updateData" asp-area="secretaryPanel" asp-route-id="@item.patientsID" class="btn btn-sm btn btn-warning">ویرایش</a>
//            <a onclick="deletePatients(@item.patientsID)" class="btn btn-sm btn btn-danger" id="deletePatients">حذف</a>
//        </td>
//    </tr>
//}

$('#searchButton').on('click', fillTable);
function fillTable() {
    var searchContent = $('#searchContent').val();
    var tr = '';
    $('#reserveList tbody').empty();
    $.get('/searchPatients/' + searchContent, function (result) {
        $.each(result, function (key, value) {
            tr += '<tr>';

            tr += '<td>' + value.patientsID + '</td>';
            tr += '<td>' + '<img src="/uploadImages/' + value.imageName + '" alt="عکس موجود نیست" title="عکس مریض" class="img-responsive img-thumbnail" style="max-width:5em !important; max-height:60px;" />'  + '</td>';
            tr += '<td>' + value.nationalNumber + '</td>';
            tr += '<td>' + value.firstName + ' ' + value.lastName + '</td>';
            tr += '<td>' + value.fatherName + '</td>';
            tr += '<td>' + value.birthDate + '</td>';
            tr += '<td>' + '<a href="/Clinic/editPatients/' + value.patientsID + '" class="btn btn-sm btn btn-warning">ویرایش</a>  <a onclick="deletePatients(' + value.patientsID +')" class="btn btn-sm btn btn-danger" id="deletePatients">حذف</a> ' + '</td>';

            tr += '</tr>';

           // $('tbody img').load('~/uploadImages/' + value.imageName + '');
            
        });
        $('#reserveList tbody').append(tr);
        console.log(tr);
    });
}