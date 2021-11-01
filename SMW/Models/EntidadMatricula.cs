using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



public class EntidadMatricula
{
    public int Matricula_id { get; set; }

    [Display(Name = "Estudiante_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    public int Estudiante_id { get; set; }

    [Display(Name = "Gurpo_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    public int Grupo_id { get; set; }

    [Display(Name = "Curso_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    public int Curso_id { get; set; }

    [Display(Name = "Profesor_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    public int Profesor_id { get; set; }

    [Display(Name = "Horario_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    public int Horario_id { get; set; }

    [Display(Name = "Aula_id")]
    [Required(ErrorMessage = " Debe de seleccionar un id ")]
    public int Aula_id { get; set; }

    [Display(Name = "Comprobante")]
    [Required(ErrorMessage = " Debe de digitar el nombre comprobante ")]
    public string Matricula_comprobante { get; set; }


    [Display(Name = " Estado ")]
    public string Matricula_estado { get; set; }

    public List<EntidadProfesor> Profesor { get; set; }

    public List<EntidadEstudiante> Estudiante { get; set; }

    public List<EntidadCurso> Curso { get; set; }

    public List<EntidadGrupo> Grupo { get; set; }

    public List<EntidadAula> Aula { get; set; }

    public List<EntidadHorario> Horario { get; set; }
}
