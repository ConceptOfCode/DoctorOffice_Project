
var CountRendered = false;

$(document).scroll(function () {

  // $('#turgetFacts p').html($(this).scrollTop());

    if ($(this).scrollTop() > 1234) { 
        if (CountRendered == false) {
            renderCount();
            CountRendered = true;
        }
    }
});


function getCount() {
    var outPut = {};
    $.get('/getCountDoctorEmployees', function (response) {
        if (response > 0) {
            outPut['EmpCount'] = response;
        }
        else {
            outPut['EmpCount'] = 0;
        }
    });
      
    $.get('/getCountPatients', function (response) {
        if (response > 0) {
            outPut['PatientCount'] = response;
        }
        else {
            outPut['PatientCount'] = 0;
        }
    });

    $.get('/getCountTurns', function (response) {
        if (response > 0) {
            outPut['TurnsCount'] = response;
        }
        else {
            outPut['TurnsCount'] = 0;
        }
    });

    $.get('/getCountHappyPatients', function (response) {
        if (response > 0) {
            outPut['HP'] = response;
        }
        else {
            outPut['HP'] = 0;
        }
    });

    return outPut;
}

function renderCount() {
    var data = getCount();
    var ExpDoctorElm = $('#ExpertDoctorCount');
    var patientFolderElm = $('#PatientsFolderCount');
    var reservesElm = $('#TurnsCount');
    var hpElm = $('#HappyPatientsCount');

    var ExpDoctorCounter = 0;
    var patientFolderCounter = 0;
    var reservesCounter = 0;
    var hpCounter = 0;

    var IntDoctor = setInterval(doctorCounter, 120);
    function doctorCounter() {
        if (data['EmpCount'] > 0) {
            if (data['EmpCount'] != ExpDoctorCounter) {
                ExpDoctorCounter++;
                ExpDoctorElm.html(ExpDoctorCounter);
            }
            else {
                setTimeout(IntDoctor);
            }
        }
    }

    var IntPatient = setInterval(patientsCounter, 120);
    function patientsCounter() {
        if (data['PatientCount'] > 0) {
            if (data['PatientCount'] != patientFolderCounter) {
                patientFolderCounter++;
                patientFolderElm.html(patientFolderCounter);
            }
            else {
                setTimeout(IntPatient);
            }
        }
    }

    var IntTurns = setInterval(turnsCounter, 120);
    function turnsCounter() {
        if (data['TurnsCount'] > 0) {
            if (data['TurnsCount'] != reservesCounter) {
                reservesCounter++;
                reservesElm.html(reservesCounter);
            }
            else {
                setTimeout(IntTurns);
            }
        }
    }

    var Inthp = setInterval(happyPatientsCounter, 120);
    function happyPatientsCounter() {
        if (data['HP'] > 0) {
            if (data['HP'] != hpCounter) {
                hpCounter++;
                hpElm.html(hpCounter);
            }
            else {
                setTimeout(Inthp);
            }
        }
    }
}