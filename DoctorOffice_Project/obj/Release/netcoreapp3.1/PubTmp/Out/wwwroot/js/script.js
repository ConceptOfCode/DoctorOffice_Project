$(document).ready(function(){
    $('[data-toggle="tooltip"]').tooltip();
});

$(window).resize(function(event){
    if($(window).width() < 1191){
        $('#img img').css('display', 'none');
    }
    else{
        $('#img img').css('display', 'block');
    }
});