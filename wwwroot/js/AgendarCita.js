function ValidarFormulario() {

    
    const formulario = document.forms['formulario'];

    var cedula = formulario['inputCedula'].value;
    var nombre = formulario['inputNombre'].value;
    var apellido = formulario['inputApellido'].value;
    var telefono = formulario['inputTelefono'].value;




    if (cedula.length < 10 | cedula.length > 10) {

        var nota = "La longitud de la cedula debe ser de 10 caracteres";
        const elemento = document.getElementById("alertaCel").innerHTML = nota;
    }

    if (telefono.length < 10 | telefono.length > 10) {

         var nota = "La longitud del telefono debe ser de 10 caracteres";
         const elemento = document.getElementById("alertaTel").innerHTML = nota;
    }
   
}
