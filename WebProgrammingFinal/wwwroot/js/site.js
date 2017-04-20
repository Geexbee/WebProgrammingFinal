function validateEmail(email)
{
    var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
}

function validateName(name)
{
    var re = /^(([A-Za-z]+[\-\']?)*([A-Za-z]+)?\s)+([A-Za-z]+[\-\']?)*([A-Za-z]+)?$/
    return re.test(name)
}

function validate()
{

    var name = $("#name").val();
    if (validateEmail(name))
    {
    }
    else
    {
        alert("Please enter a valid Name");
    }

  var email = $("#email").val();
  if (validateEmail(email))
  {
  }
  else
  {
      alert("Please enter a valid E-Mail Address");
  }

 
  return false;
}

$("#validate").bind("click", validate);