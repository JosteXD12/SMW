using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMW.Controllers
{
    public class HorarioController : Controller
    {
        // GET: Horario
        public ActionResult HorarioListado()
        {
            DALHorario ObjHorario = new DALHorario();
            ModelState.Clear();

            return View(ObjHorario.ListarHorario());
        }
        public ActionResult insertarhorario(EntidadHorario Horario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DALHorario ObjHorario = new DALHorario();

                    if (ObjHorario.InsertarHorario(Horario))
                    {
                        ViewBag.Mensaje = "Horario a sido ingresado con éxto";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error en el inreso del Horario";
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
        public ActionResult modificarHorario(int Horario_id)
        {
            DALHorario ObjHorario = new DALHorario();

            return View(ObjHorario.ListarHorario().Find(est => est.Horario_id == Horario_id));
        }

        [HttpPost]
        public ActionResult modificarHorario(int Horario_id, EntidadHorario horario)
        {
            DALHorario ObjHorario = new DALHorario();

            ObjHorario.ModificarHorario(horario);

            return RedirectToAction("HorarioListado");

        }
        public ActionResult eliminarHorario(int Horario_id)
        {
            try
            {
                DALHorario ObjHorario = new DALHorario();

                if (ObjHorario.InactivarHorario(Horario_id))
                {
                    ViewBag.Mensaje = "Horario Inactivado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al inactivado el Horario";
                }

                return RedirectToAction("HorarioListado");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult eliminarAdminHorario(int Horario_id)
        {
            try
            {
                DALHorario ObjHorario = new DALHorario();

                if (ObjHorario.EliminarHorario(Horario_id))
                {
                    ViewBag.Mensaje = "Horario eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el profesor";
                }

                return RedirectToAction("ListadoInactivosHorario");

            }
            catch
            {
                return RedirectToAction("HorarioListado");
            }

        }
        public ActionResult ListadoInactivosHorario()
        {
            DALHorario ObjHorario = new DALHorario();
            ModelState.Clear();

            return View(ObjHorario.ListarInactivosHorario());
        }
        public ActionResult ActivarHorario(int Horario_id)
        {
            DALHorario ObjHorario = new DALHorario();
            ModelState.Clear();
            ObjHorario.ActivarHorario(Horario_id);
            return RedirectToAction("ListadoInactivosHorario");

        }
    }
}