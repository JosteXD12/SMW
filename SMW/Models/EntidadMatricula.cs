using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



public class EntidadMatricula
{
    int Matricula_id { get; set; }

    [Display(Name = "Estudiante_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    int Estudiante_id{ get; set; }

    [Display(Name = "Gurpo_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    int Grupo_id { get; set; }

    [Display(Name = "Curso_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    int Curso_id { get; set; }

    [Display(Name = "Profesor_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    int Profesor_id { get; set; }

    [Display(Name = "Horario_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    int Horario_id { get; set; }

    [Display(Name = "Aula_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    int Aula_id{ get; set; }

    [Display(Name = "Comprobante")]
    [Required(ErrorMessage = " Debe de digitar el nombre comprobante ")]
    string Matricula_comprobante { get; set; }


    [Display(Name = " Estado ")]
    string Matricula_estado { get; set; }
}
