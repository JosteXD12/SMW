using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadUsuario
{
    public int Usuario_id { get; set; }

    public string Usuario_Area { get; set; }

    public string Usuario_Nombre { get; set; }

    [Display(Name = " Nombre de usuario ")]
    [Required(ErrorMessage = " Debe de digitar el Nombre de usuario ")]
    public string Usuario_nick { get; set; }

    [Display(Name = " Contraseña ")]
    [Required(ErrorMessage = " Debe de digitar la Conrtraseña ")]
    public string Usuario_Contrasenna { get; set; }
}
