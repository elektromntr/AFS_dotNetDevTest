$('#translate-btn').click(function (e) {
    e.preventDefault();
    var input = document.getElementById('text').value;
    $.getJSON("//api.funtranslations.com/translate/leetspeak.json?text=" + input, function (data) {
        $('#translated').attr('value', data.contents.translated);
    });
}
        );