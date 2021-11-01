using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMW.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult EstudianteListado()
        {
            DALEstudiante ObjEstudiante = new DALEstudiante();
            ModelState.Clear();

            return View(ObjEstudiante.ListarEstudiante());

        }
        public ActionResult InsertarEstudiante(EntidadEstudiante Estudiante)
        {
            List<EntidadGrupo> grupo = (new DALGrupo()).ListarGrupo();
            EntidadEstudiante cbxGrupo = new EntidadEstudiante { Grupo = grupo };
            try
            {
                if (ModelState.IsValid)
                {
                    DALEstudiante ObjEstudiante = new DALEstudiante();

                    if (ObjEstudiante.insertarEstudiante(Estudiante))
                    {
                        ViewBag.Mensaje = "Estudiante a sido ingresado con éxto";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error en el inreso del Estudiante";
                    }
                }
                return View(cbxGrupo);
            }
            catch (Exception ex)
            {
                ex = null;
            }
            return View();
        }
        public ActionResult modificarEstudiante(int Estudiante_id)
        {
            DALEstudiante ObjEstudiante = new DALEstudiante();
            List<EntidadGrupo> grupo = (new DALGrupo()).ListarGrupo();
            EntidadEstudiante cbxGrupo = ObjEstudiante.ListarEstudiante().Find(est => est.Estudiante_id == Estudiante_id);
            cbxGrupo.Grupo = grupo;
            return View(cbxGrupo);
        }

        [HttpPost]
        public ActionResult modificarEstudiante(int Estudiante_id, EntidadEstudiante Estudiante)
        {
            DALEstudiante ObjEstudiante = new DALEstudiante();

            ObjEstudiante.ModificarEstudiante(Estudiante);

            return RedirectToAction("EstudianteListado");

        }
        public ActionResult eliminarEstudiante(int Estudiante_id)
        {
            try
            {
                DALEstudiante ObjEstudiante = new DALEstudiante();

                if (ObjEstudiante.InactivarEstudiante(Estudiante_id))
                {
                    ViewBag.Mensaje = "Estudiante eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Estudiante";
                }

                return RedirectToAction("EstudianteListado");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult eliminarAdminEstudiante(int Estudiante_id)
        {
            try
            {
                DALEstudiante ObjEstudiante = new DALEstudiante();

                if (ObjEstudiante.EliminarEstudiante(Estudiante_id))
                {
                    ViewBag.Mensaje = "Estudiante eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Estudiante";
                }

                return RedirectToAction("ListadoInactivosEstudiante");

            }
            catch
            {
                return View();
            }

        }

        public ActionResult ListadoInactivosEstudiante()
        {
            DALEstudiante ObjEstudiante = new DALEstudiante();
            ModelState.Clear();

            return View(ObjEstudiante.ListarIncativoEstudiante());
        }
        public ActionResult ActivarEstudiante(int Estudiante_id)
        {
            DALEstudiante ObjEstudiante = new DALEstudiante();
            ModelState.Clear();
            ObjEstudiante.ActivarEstudiante(Estudiante_id);
            return RedirectToAction("ListadoInactivosEstudiante");

        }
    }
}