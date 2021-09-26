function ValidarFormulario() {

    
    var formulario = document.forms['formulario'];

    var cedula = formulario['inputCedula'].value;
    var nombre = formulario['inputNombre'].value;
    var apellido = formulario['inputApellido'].value;
    var telefono = formulario['inputTelefono'].value;


    if (cedula.length < 10 | cedula.length) {
        console.log("La longitud de la cedula debe tener 10 caracteres");
    }
    
}