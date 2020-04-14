$('#saveAddress').click(function(){
    var content = '';

    if($('#sat').prop('checked') == true){
        content += 'شنبه|';
    }
    if($('#sun').prop('checked') == true){
        content += 'یکشنبه|';
    }
    if($('#mon').prop('checked') == true){
        content += 'دوشنبه|';
    }
    if($('#thu').prop('checked') == true){
        content += 'سه شنبه|';
    }
    if($('#wen').prop('checked') == true){
        content += 'چهارشنبه|';
    }
    if($('#thur').prop('checked') == true){
        content += 'پنجشنبه|';
    }

    $('#weekDay').text(content);
});
