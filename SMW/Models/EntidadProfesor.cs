using System.ComponentModel.DataAnnotations;


public class EntidadProfesor
{
    public int Profesor_id { get; set; }

    [Display(Name = "Cedula")]
    [Required(ErrorMessage = " Debe de digitar la cédula ")]
    public string Profesor_cedula { get; set; }

    [Display(Name = " Nombre ")]
    [Required(ErrorMessage = " Debe de digitar el nombre ")]
    public string Profesor_nombre { get; set; }

    [Display(Name = " Primer Apellido ")]
    [Required(ErrorMessage = " Debe de digitar un apellido ")]
    public string Profesor_primerApellido { get; set; }


    [Display(Name = " Segundo Apellido ")]
    [Required(ErrorMessage = " Debe de digitar un apellido ")]
    public string Profesor_segundoApellido { get; set; }

    [Display(Name = " Teléfono ")]
    [Required(ErrorMessage = " Debe de digitar un numero de teléfono ")]
    public string Profesor_telefono { get; set; }

    [Display(Name = " Email ")]
    [Required(ErrorMessage = " Debe de digitar un correo electrónico ")]
    public string Profesor_correoElectronico { get; set; }

    [Display(Name = " Dirrección ")]
    [Required(ErrorMessage = " Debe de digitar su dirrección ")]
    public string Profesor_dirreccion { get; set; }

    [Display(Name = " Estado ")]
    public string Profesor_estado { get; set; }

}
