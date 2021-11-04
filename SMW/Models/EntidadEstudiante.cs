using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadEstudiante
{
   
    public int Estudiante_id { get; set; }

    [Display(Name = "Gurpo_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    public int Grupo_id { get; set; }

    [Display(Name = "Cedula")]
    [Required(ErrorMessage = " Debe de digitar la cédula ")]
    public string Estudiante_cedula { get; set; }

    [Display(Name = " Nombre ")]
    [Required(ErrorMessage = " Debe de digitar el nombre ")]
    public string Estudiante_nombre { get; set; }

    [Display(Name = " Primer Apellido ")]
    [Required(ErrorMessage = " Debe de digitar un apellido ")]
    public string Estudiante_primerApellido { get; set; }


    [Display(Name = " Segundo Apellido ")]
    [Required(ErrorMessage = " Debe de digitar un apellido ")]
    public string Estudiante_segundoApellido { get; set; }

    [Display(Name = " Teléfono ")]
    [Required(ErrorMessage = " Debe de digitar un numero de teléfono ")]
    public string Estudiante_telefono { get; set; }

    [Display(Name = " Email ")]
    [Required(ErrorMessage = " Debe de digitar un correo electrónico ")]
    public string Estudiante_correoElectronico { get; set; }

    [Display(Name = " Dirrección ")]
    [Required(ErrorMessage = " Debe de digitar su dirrección ")]
    public string Estudiante_dirreccion { get; set; }

    [Display(Name = " Estado ")]
    public string Estudiante_estado { get; set; }

    public List<EntidadGrupo> Grupo { get; set; }

    public List<EntidadUsuario> User { get; set; }

}
