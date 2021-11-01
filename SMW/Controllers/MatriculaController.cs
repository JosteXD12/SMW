using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMW.Controllers
{
    public class MatriculaController : Controller
    {
        // GET: Matricula
        public ActionResult MatriculaLista()
        {
            DALMatricula ObjMatricula = new DALMatricula();
            ModelState.Clear();

            return View(ObjMatricula.ListarMatricula());
        }
        public ActionResult InsertarMatricula(EntidadMatricula matricula)
        {
            List<EntidadProfesor> profesor = (new DALProfesor()).ListarProfesor();
            List<EntidadEstudiante> estudiante = (new DALEstudiante()).ListarEstudiante();
            List<EntidadCurso> curso = (new DLACurso()).ListarCurso();
            List<EntidadGrupo> grupo = (new DALGrupo()).ListarGrupo();
            List<EntidadAula> aula = (new DLAAula()).ListarAula();
            List<EntidadHorario> horario = (new DALHorario()).ListarHorario();
            EntidadMatricula cbxMatricula= new EntidadMatricula { Profesor = profesor,Estudiante = estudiante,Curso = curso, Grupo = grupo,Aula = aula, Horario = horario };
            try
            {
                if (ModelState.IsValid)
                {
                    DALMatricula ObjMatricula = new DALMatricula();

                    if (ObjMatricula.insertarMatricula(matricula))
                    {
                        ViewBag.Mensaje = "Matriucla a sido ingresado con éxto";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error en el ingreso del Aula";
                    }
                }
                return View(cbxMatricula);
            }
            catch (Exception ex)
            {
                ex = null;
            }
            return View();
        }
        public ActionResult modificarMatricula(int Matricula_id)
        {
            DALMatricula ObjMatricula = new DALMatricula();
            
            List<EntidadProfesor> profesor = (new DALProfesor()).ListarProfesor();
            List<EntidadEstudiante> estudiante = (new DALEstudiante()).ListarEstudiante();
            List<EntidadCurso> curso = (new DLACurso()).ListarCurso();
            List<EntidadGrupo> grupo = (new DALGrupo()).ListarGrupo();
            List<EntidadAula> aula = (new DLAAula()).ListarAula();
            List<EntidadHorario> horario = (new DALHorario()).ListarHorario();

            EntidadMatricula cbxMatricula = ObjMatricula.ListarMatricula().Find(est => est.Matricula_id == Matricula_id);
            
            cbxMatricula.Profesor = profesor;
            cbxMatricula.Estudiante = estudiante;
            cbxMatricula.Curso = curso;
            cbxMatricula.Grupo = grupo;
            cbxMatricula.Aula = aula;
            cbxMatricula.Horario = horario;
            return View(cbxMatricula);
        }

        [HttpPost]
        public ActionResult modificarMatricula(int Matricula_id, EntidadMatricula matricula)
        {
            DALMatricula ObjMatricula = new DALMatricula();

            ObjMatricula.ModificarMatricula(matricula);

            return RedirectToAction("MatriculaLista");

        }
        public ActionResult eliminarMatricula(int Matricula_id)
        {
            try
            {
                DALMatricula ObjMatricula = new DALMatricula();

                if (ObjMatricula.InactivarMatricula(Matricula_id))
                {
                    ViewBag.Mensaje = "Matricula eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Matricula";
                }

                return RedirectToAction("MatriculaLista");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult eliminarAdminMatricula(int Matricula_id)
        {
            try
            {
                DALMatricula ObjMatricula = new DALMatricula();

                if (ObjMatricula.EliminarMatricula(Matricula_id))
                {
                    ViewBag.Mensaje = "Matricula eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Matricula";
                }

                return RedirectToAction("ListadoInactivosmatricula");

            }
            catch
            {
                return View();
            }

        }

        public ActionResult ListadoInactivosmatricula()
        {
            DALMatricula ObjMatricula = new DALMatricula();
            ModelState.Clear();

            return View(ObjMatricula.ListarIncativoMatricula());
        }

        public ActionResult ActivarMatricula(int Matricula_id)
        {
            DALMatricula ObjMatricula = new DALMatricula();
            ModelState.Clear();
            ObjMatricula.ActivarMatricula(Matricula_id);
            return RedirectToAction("ListadoInactivosmatricula");

        }
    }
}