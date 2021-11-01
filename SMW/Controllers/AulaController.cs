using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMW.Controllers
{
    public class AulaController : Controller
    {

        // GET: Profesor
        public ActionResult AulaListado()
        {
            DLAAula ObjAula = new DLAAula();
            ModelState.Clear();

            return View(ObjAula.ListarAula());
        }

        public ActionResult InsertarAula(EntidadAula aula)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DLAAula ObjAula = new DLAAula();

                    if (ObjAula.insertarAula(aula))
                    {
                        ViewBag.Mensaje = "Aula a sido ingresado con éxto";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error en el ingreso del Aula";
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
        public ActionResult modificarAula(int Aula_id)
        {
            DLAAula ObjAula = new DLAAula();

            return View(ObjAula.ListarAula().Find(est => est.Aula_id == Aula_id));
        }

        [HttpPost]
        public ActionResult modificarAula(int Aula_id, EntidadAula Aula)
        {
            DLAAula ObjAula = new DLAAula();

            ObjAula.ModificarAula(Aula);

            return RedirectToAction("AulaListado");

        }
        public ActionResult eliminarAula(int Aula_id)
        {
            try
            {
                DLAAula ObjAula = new DLAAula();

                if (ObjAula.InactivarAula(Aula_id))
                {
                    ViewBag.Mensaje = "Aula eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Aula";
                }

                return RedirectToAction("AulaListado");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult eliminarAdminAula(int Aula_id)
        {
            try
            {
                DLAAula ObjAula = new DLAAula();

                if (ObjAula.EliminarAula(Aula_id))
                {
                    ViewBag.Mensaje = "Aula eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Aula";
                }

                return RedirectToAction("ListadoInactivosAula");

            }
            catch
            {
                return RedirectToAction("AulaListado");
            }

        }
        public ActionResult ListadoInactivosAula()
        {
            DLAAula ObjAula = new DLAAula();
            ModelState.Clear();

            return View(ObjAula.ListarIncativoAula());
        }
        public ActionResult ActivarAula(int Aula_id)
        {
            DLAAula DLAAula = new DLAAula();
            ModelState.Clear();
            DLAAula.ActivarAula(Aula_id);
            return RedirectToAction("ListadoInactivosAula");

        }
    }
}