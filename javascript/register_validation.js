// const loginName = document.getElementById("name-input");
const loginEmail = document.getElementById("email-input");
const loginPassword = document.getElementById("password-input");
const loginConfirm = document.getElementById("confirm-input");
const loginCheck = document.getElementById("checkbox-input");
const form = document.getElementById("regis-form");

form.onsubmit = function(e){

    e.preventDefault();
    
    email = loginEmail.value;
    password = loginPassword.value;
    confirm = loginConfirm.value;
    check = loginCheck.checked;

    // name = loginName.value;
    // if(name === '' || name == null){
    //     alert("You must fill out your name!");
    //     return;
    // }

    if(email.length < 4){
        alert("Email address must be minimal 4 characters!");
        return;
    }

    if(email.indexOf("@") == -1){
        alert("Email address must contain @!");
        return;
    }

    let count = 0;
    for(let i = 0; i < email.length; i++){
        if(email[i] == '@'){
            count++;
        }
        if(count > 1){
            alert("You can't have more than 1 @ in an email address!");
            return;
        }
    }

    if(email.indexOf('@')+1 == email.length){
        alert("You can't put @ at the end of an email address!");
        return;
    }

    if(password.length < 8){
        alert("Password must be minimal 8 characters!");
        return;
    }

    count = 0;
    for(let i = 0; i < password.length; i++){
        if(password[i] >= 'A' && password[i] <= 'Z'){
            count++;
        }
    }
    if(count == 0){
        alert("Password must contain at least 1 capital letters!");
        return;
    }

    count = 0;
    for(let i = 0; i < password.length; i++){
        if(!isNaN(password[i])){
            count++;
        }
    }
    if(count == 0){
        alert("Password must contain at least 1 number!");
        return;
    }
    
    count = 0;
    for(let i = 0; i < password.length; i++){
        if((password[i] >= ' ' && password[i] <= '/') || (password[i] >= ':' && password[i] <= '@') || (password[i] >= '[' && password[i] <= '`') || (password[i] >= '{' && password[i] <= '~')){
            count++;
        }
    }
    if(count == 0){
        alert("Password must contain at least 1 special character!");
        return;
    }
    count = 0;

    if(password != confirm){
        alert("Make sure that your confirmation password is the same as your password!");
        return;
    }

    if(check == false){
        alert("Please agree to the terms and conditions");
        return;
    }
    else{
        alert("Register successful");
        return;
    }
    
}