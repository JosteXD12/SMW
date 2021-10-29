using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMW.Controllers
{
    public class CursoController : Controller
    {
        public ActionResult CursoListado()
        {
            DLACurso ObjCurso = new DLACurso();
            ModelState.Clear();

            return View(ObjCurso.ListarCurso());

        }
        public ActionResult InsertarCurso(EntidadCurso Curso)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DLACurso ObjCurso = new DLACurso();

                    if (ObjCurso.insertarCuro(Curso))
                    {
                        ViewBag.Mensaje = "Curso a sido ingresado con éxto";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error en el inreso del Curso";
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                ex = null;
            }
            return View();
        }
        public ActionResult modificarCurso(int Curso_id)
        {
            DLACurso ObjCurso = new DLACurso();

            return View(ObjCurso.ListarCurso().Find(est => est.Curso_id == Curso_id));
        }

        [HttpPost]
        public ActionResult modificarCurso(int Curso_id, EntidadCurso Curso)
        {
            DLACurso ObjCurso = new DLACurso();

            ObjCurso.ModificarCurso(Curso);

            return RedirectToAction("CursoListado");

        }
        public ActionResult eliminarCurso(int Curso_id)
        {
            try
            {
                DLACurso ObjCurso = new DLACurso();

                if (ObjCurso.InactivarCurso(Curso_id))
                {
                    ViewBag.Mensaje = "Curso eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Curso";
                }

                return RedirectToAction("CursoListado");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult eliminarAdminEstudiante(int Curso_id)
        {
            try
            {
                DLACurso ObjCurso = new DLACurso();

                if (ObjCurso.EliminarCurso(Curso_id))
                {
                    ViewBag.Mensaje = "Curso eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Curso";
                }

                return RedirectToAction("ListadoInactivosCurso");

            }
            catch
            {
                return View();
            }

        }

        public ActionResult ListadoInactivosCurso()
        {
            DLACurso ObjCurso = new DLACurso();
            ModelState.Clear();

            return View(ObjCurso.ListarIncativoCurso());
        }
        public ActionResult ActivarEstudiante(int Curso_id)
        {
            DLACurso ObjCurso = new DLACurso();
            ModelState.Clear();
            ObjCurso.ActivarCurso(Curso_id);
            return RedirectToAction("ListadoInactivosCurso");

        }
    }
}