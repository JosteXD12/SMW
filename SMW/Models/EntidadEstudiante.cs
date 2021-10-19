using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadEstudiante
{
    int Estudiante_id { get; set; }

    [Display(Name = "Gurpo_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    int Grupo_id { get; set; }

    [Display(Name = "Cedula")]
    [Required(ErrorMessage = " Debe de digitar la cédula ")]
    string Estudiante_cedula { get; set; }

    [Display(Name = " Nombre ")]
    [Required(ErrorMessage = " Debe de digitar el nombre ")]
    string Estudiante_nombre { get; set; }

    [Display(Name = " Primer Apellido ")]
    [Required(ErrorMessage = " Debe de digitar un apellido ")]
    string Estudiante_primerApellido { get; set; }


    [Display(Name = " Segundo Apellido ")]
    [Required(ErrorMessage = " Debe de digitar un apellido ")]
    string Estudiante_segundoApellido { get; set; }

    [Display(Name = " Teléfono ")]
    [Required(ErrorMessage = " Debe de digitar un numero de teléfono ")]
    string Estudiante_telefono { get; set; }

    [Display(Name = " Email ")]
    [Required(ErrorMessage = " Debe de digitar un correo electrónico ")]
    string Estudiante_correoElectronico { get; set; }

    [Display(Name = " Dirrección ")]
    [Required(ErrorMessage = " Debe de digitar su dirrección ")]
    string Estudiante_dirreccion { get; set; }

    [Display(Name = " Estado ")]
    string Estudiante_estado { get; set; }

}
