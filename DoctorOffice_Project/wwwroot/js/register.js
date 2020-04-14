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

$('#Save').click(function(){

        Validator($('#firstName').val(), $('#lastName').val(), $('#fatherName').val(), 
        $('#nationalNumber').val(), $('#birthDate').val(), $('#phoneNumber').val(), )
});

function Validator(){

        for(var i = 0; i<arguments.length; i++)
        {
            if(arguments[i] == ''){
                $('#MainForm span.text-danger').eq(i).css('display', 'block');
                fieldArray[i] = false;
            }
            else{
                $('#MainForm span.text-danger').eq(i).css('display', 'none');
                fieldArray[i] = true;
            }
        }
        
        checkIsValid();
}