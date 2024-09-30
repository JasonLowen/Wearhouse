const loginEmail = document.getElementById("email-input");
const loginPassword = document.getElementById("password-input");
const form = document.getElementById("login-form");

form.onsubmit = function (e) {

    e.preventDefault();

    email = loginEmail.value;
    password = loginPassword.value;

    if (email.length < 4) {
        alert("Email address must be minimal 4 characters!");
        return;
    }

    if (email.indexOf("@") == -1) {
        alert("Email address must contain @!");
        return;
    }

    let count = 0;
    for (let i = 0; i < email.length; i++) {
        if (email[i] == '@') {
            count++;
        }
        if (count > 1) {
            alert("You can't have more than 1 @ in an email address!");
            return;
        }
    }

    if (email.indexOf('@') + 1 == email.length) {
        alert("You can't put @ at the end of an email address!");
        return;
    }

    if (password.length < 8) {
        alert("Password must be minimal 8 characters!");
        return;
    }

    document.getElementById("login-form").submit();

}