using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadAula
{
    public int Aula_id { get; set; }

    [Display(Name = "Descripcion")]
    [Required(ErrorMessage = " Debe de digitar la descripcion ")]
    public string Aula_descripcion { get; set; }

    [Display(Name = " Capacidad ")]
    [Required(ErrorMessage = " Debe de digitar la capacidad del aula ")]
    public string Aula_capacidad { get; set; }

    [Display(Name = " Estado ")]
    public string Aula_Estado { get; set; }
}
