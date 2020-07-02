$(document).ready(function () {
    $('#register_form').submit(function (e) {
        //When pressing the submit button, stop the process of submitting :)
        e.preventDefault();
        //Delete the error class, if we have
        $('span + error').remove();

        let name = $('#name').val();
        let surname = $('#surname').val();
        let username = $('#username').val();
        let email = $('#email').val();
        let password = $('#password').val();
        let phone = $('#phone').val();

        //If there is not name added
        if (name.length < 1) {
            //And if there is already no added span for error
            if ($('#name + span').length < 1) {
                //Add the error
                $('#name').after('<span class="error">The name should not be empty</span>');
            }
        } else {
            //If the user adds a name, remove the error
            $('#name + span').remove();
        }
        //Repeat with the others the same way

        if (surname.length < 1) {
            if($('#surname + span').length < 1){
                $('#surname').after('<span class="error">The surname should not be empty</span>');
            }
        } else {
            $('#surname + span').remove();
        }

        if (username.length < 1) {
            if($('#username + span').length < 1){
                $('#username').after('<span class="error">The username should not be empty</span>');
            }
        } else {
            $('#username + span').remove();
        }

        if (email.length < 1) {
            if($('#email + span').length < 1){
                $('#email').after('<span class="error">The email should not be empty</span>');
            }
        } else {
            $('#email + span').remove();
        }

        if (password.length < 8) {
            if($('#password + span').length < 1){
                $('#password').after('<span class="error">The password should be at least 8 characters long</span>');
            }
        } else {
            $('#password + span').remove();
        }

        if (phone.length < 1) {
            if($('#phone + span').length < 1){
                $('#phone').after('<span class="error">The phone should not be empty</span>');
            }
        } else {
            $('#phone + span').remove();
        }
    });
});
