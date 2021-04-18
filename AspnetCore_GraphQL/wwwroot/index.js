 function spaceToComma() {
    var input = $("#txtRange").val();
    var output = input.split(" ").join(',');
    $('#txtRange').val(output);
};