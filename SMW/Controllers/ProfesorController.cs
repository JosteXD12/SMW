using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMW.Controllers
{
    public class ProfesorController : Controller
    {
        // GET: Profesor
        public ActionResult Listado()
        {
            DALProfesor ObjProfesor = new DALProfesor();
            ModelState.Clear();

            return View(ObjProfesor.ListarProfesor());
        }
       

        public ActionResult InsertarProfesor(EntidadProfesor profesor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DALProfesor ObjProfesor = new DALProfesor();

                    if (ObjProfesor.insertarProfesor(profesor))
                    {
                        ViewBag.Mensaje = "Profesor a sido ingresado con éxto";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error en el inreso del profesor";
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
        //uso protocolo GET clientes/modificarProfesor/5
        public ActionResult modificarProfesor(int profesor_id)
        {
            DALProfesor ObjProfesor = new DALProfesor();

            return View(ObjProfesor.ListarProfesor().Find(est => est.Profesor_id == profesor_id));
        }

        [HttpPost]
        public ActionResult modificarProfesor(int profesor_id, EntidadProfesor profesor)
        {
            DALProfesor oProfesor = new DALProfesor();

            oProfesor.ModificarProfesor(profesor);

            return RedirectToAction("listado");

        }

        public ActionResult eliminarProfesor(int profesor_id)
        {
            try
            {
                DALProfesor ObjProfesor = new DALProfesor();

                if (ObjProfesor.InactivarProfesor(profesor_id))
                {
                    ViewBag.Mensaje = "Profesor eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el profesor";
                }

                return RedirectToAction("listado");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult eliminarAdminProfesor(int profesor_id)
        {
            try
            {
                DALProfesor ObjProfesor = new DALProfesor();

                if (ObjProfesor.EliminarProfesor(profesor_id))
                {
                    ViewBag.Mensaje = "Profesor eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el profesor";
                }

                return RedirectToAction("listado");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult ListadoInactivosProfesor()
        {
            DALProfesor ObjProfesor = new DALProfesor();
            ModelState.Clear();

            return View(ObjProfesor.ListarIncativoProfesor());
        }
        public ActionResult ActivarProfesor(int Profesor_id)
        {
            DALProfesor ObjProfesor = new DALProfesor();
            ModelState.Clear();
            ObjProfesor.ActivarProfesor(Profesor_id);
            return RedirectToAction("ListadoInactivosProfesor");
           
        }


    }
}