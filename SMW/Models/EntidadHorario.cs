using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadHorario
{
    public int Horario_id { get; set; }

    [Display(Name = "Descripcion")]
    [Required(ErrorMessage = " Debe de digitar la descripcion ")]
    public string Horario_descripcion { get; set; }

    [Display(Name = " Dia ")]
    [Required(ErrorMessage = " Debe de digitar el dia ")]
    public string Horario_dia { get; set; }

    [Display(Name = " Hora inicio ")]
    [Required(ErrorMessage = " Debe de digitar la hora inicio")]
    public string Horario_horainicio { get; set; }

    [Display(Name = " Hora fin ")]
    [Required(ErrorMessage = " Debe de digitar la hora fin")]
    public string Horario_horafin { get; set; }

    [Display(Name = " Estado ")]
    public string Horario_estado { get; set; }
}
