function checkName() {

    var textField = document.getElementById("name");
    var regexField = /^[a-zA-Z ]+$/;

    if (textField.value.match(RegExp(regexField))) {
        return true;
    }
    else {
        alert("Please enter a valid name");
        return false;
    }
}


function checkEmail() {

    var textField = document.getElementById("email");
    var regexField = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;

    if (textField.value.match(RegExp(regexField))) {
        return true;
    }
    else {
        alert("Please enter a valid E-Mail Address");
        return false;
    }
}

function checkContactForm() {
    checkName();
    checkEmail();
   }