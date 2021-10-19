using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


public class EntidadHorario
{
    int Horario_id { get; set; }

    [Display(Name = "Descripcion")]
    [Required(ErrorMessage = " Debe de digitar la descripcion ")]
    string Horario_descripcion { get; set; }

    [Display(Name = " Dia ")]
    [Required(ErrorMessage = " Debe de digitar el dia ")]
    string Horario_dia { get; set; }

    [Display(Name = " Hora inicio ")]
    [Required(ErrorMessage = " Debe de digitar la hora inicio")]
    string Horario_horainicio { get; set; }

    [Display(Name = " Hora fin ")]
    [Required(ErrorMessage = " Debe de digitar la hora fin")]
    string Horario_horafin { get; set; }

    [Display(Name = " Estado ")]
    string Horario_estado { get; set; }
}
