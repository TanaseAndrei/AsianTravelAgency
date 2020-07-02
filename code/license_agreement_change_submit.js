$(function () {
    $('#checkbox').click(function () {
        if ($(this).is(':checked')) {
            $('#button').prop('disabled', false);
        } else {
            $('#button').prop('disabled', true)
        }
    });
});
