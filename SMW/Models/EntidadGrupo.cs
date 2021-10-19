using System.ComponentModel.DataAnnotations;


public class EntidadGrupo
{
    int Grupo_id { get; set; }

    [Display(Name = "Descripcion")]
    [Required(ErrorMessage = " Debe de digitar la descripcion ")]
    string Grupo_descripcion { get; set; }

    [Display(Name = " Estado ")]
    string Grupo_estado { get; set; }
}
