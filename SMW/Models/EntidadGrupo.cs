using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadGrupo
{
    public int Grupo_id { get; set; }

    [Display(Name = "Descripcion")]
    [Required(ErrorMessage = " Debe de digitar la descripcion ")]
    public string Grupo_descripcion { get; set; }

    [Display(Name = " Estado ")]
    public string Grupo_estado { get; set; }
}
