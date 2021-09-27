function validarText(valor){
    var valorinput = valor.value;
    var id_input = valor.id;
    if (valorinput == ""){
        document.getElementById(id_input).placeholder = "Ingrese "+ id_input;
        document.getElementById(id_input).style.border= "1px solid red";
    }else{
        document.getElementById(id_input).style.border= "";
    }
}