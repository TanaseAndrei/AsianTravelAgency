$(document).ready(function(){
    $('#login_form').submit(function(e){
        //When pressing the submit button, stop the process of submitting :)
        e.preventDefault();
        //Delete the error class, if we have
        $('span + error').remove();
        let username = $('#username').val();
        let password = $('#password').val();
        if(username.length < 1){
            if($('#username + span').length < 1){
                $('#username').after('<span class="error">The username should not be empty</span>');
            }
        } else {
            $('#username + span').remove();
        }

        if(password.length < 8){
            if($('#password + span').length < 1){
                $('#password').after('<span class="error">The password should be at least 8 characters long</span>');
            }
        } else {
            $('#password + span').remove();
        }
    });
});