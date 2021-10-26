using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadCurso
{
    public int Curso_id { get; set; }

    [Display(Name = " Nombre ")]
    [Required(ErrorMessage = " Debe de digitar el nombre ")]
    public string Curso_nombre { get; set; }

    [Display(Name = " Cantidad creditos ")]
    [Required(ErrorMessage = " Debe de digitar la cantidad de creditos ")]
    public string Curso_creditos { get; set; }

    [Display(Name = " Cantidad cupos ")]
    [Required(ErrorMessage = " Debe de digitar la cantidad de cupos")]
    public string Curso_cupo { get; set; }
    
    [Display(Name = " Estado ")]
    public string Curso_Estado { get; set; }

}
