var isValid = false;
var fieldArray = [];
function checkIsValid(){
    for(var i = 0; i<fieldArray.length; i++){
        if(fieldArray[i] == false){
            isValid = false;
            fieldArray = [];

            break;
        }
        else{
            isValid = true;
        }
    }
}

$('#haveFile').prop('checked',true);

function UnCheckOthers(currentID){
    var otherRadio = $('#' + currentID).siblings('input')
    otherRadio.each(function(key, value){
        //console.log($(value).attr('type') + $(value).attr('id'));

        $(value).prop('checked',false);
    });
}

$('#optionsSection input:radio').click(function(){
UnCheckOthers($(this).attr('id'));
}, );


$('#haveFile').click(function(){
    $('#mainPatients').css('display', 'block');
    $('#temporaryPatients').css('display', 'none');
})

$('#noFile').click(function(){
    $('#temporaryPatients').css('display', 'block');
    $('#mainPatients').css('display', 'none');
})

$('#Save').click(function(){
    if($('#haveFile').prop('checked') == true){
        Validator($('#patientsNationalNumber').val(), $('#patientsDoctorsList').val(), $('#patientsReserveDate').val(), $('#patientsEmail').val());
    }
    if($('#noFile').prop('checked') == true){
        Validator($('#firstName').val(), $('#lastName').val(), $('#fatherName').val(), 
        $('#temporaryPatientsNationalNumber').val(), $('#birthDate').val(), $('#phoneNumber').val(), 
        $('#temporaryPatientsDoctorsList').val(), $('#temporaryPatientsReserveDate').val(),
        $('#temporaryPatientsEmail').val() )
    }
});



function Validator(){

    if($('#haveFile').prop('checked') == true){
        for(var i = 0; i<arguments.length; i++)
        {
            if(arguments[i] == ''){
                $('#mainPatients span.text-danger').eq(i).css('display', 'block');
                fieldArray[i] = false;
            }
            else{
                $('#mainPatients span.text-danger').eq(i).css('display', 'none');
                fieldArray[i] = true;
            }
        }
        
        checkIsValid();
    }
    else if($('#noFile').prop('checked') == true){
        for(var i = 0; i<arguments.length; i++)
        {
            if(arguments[i] == ''){
                $('#temporaryPatients span.text-danger').eq(i).css('display', 'block');
                fieldArray[i] = false;
            }
            else{
                $('#temporaryPatients span.text-danger').eq(i).css('display', 'none');
                fieldArray[i] = true;
            }
        }

        checkIsValid();
    }
}