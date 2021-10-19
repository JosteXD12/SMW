using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadAula
{
    int Aula_id { get; set; }

    [Display(Name = "Descripcion")]
    [Required(ErrorMessage = " Debe de digitar la descripcion ")]
    string Aula_descripcion { get; set; }

    [Display(Name = " Capacidad ")]
    [Required(ErrorMessage = " Debe de digitar la capacidad del aula ")]
    string Aula_capacidad { get; set; }

    [Display(Name = " Estado ")]
    string Aula_Estado { get; set; }
}
