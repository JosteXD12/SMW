using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMW.Controllers
{
    public class GrupoController : Controller
    {
        // GET: Grupo
        public ActionResult GrupoListado()
        {
            DALGrupo ObjGrupo = new DALGrupo();
            ModelState.Clear();

            return View(ObjGrupo.ListarGrupo());
        }
        public ActionResult InsertarGrupo(EntidadGrupo Grupo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DALGrupo ObjGrupo = new DALGrupo();

                    if (ObjGrupo.insertarGrupo(Grupo))
                    {
                        ViewBag.Mensaje = "Grupo a sido ingresado con éxto";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error en el inreso del Grupo";
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
        public ActionResult modificarGrupo(int Grupo_id)
        {
            DALGrupo ObjGrupo = new DALGrupo();

            return View(ObjGrupo.ListarGrupo().Find(est => est.Grupo_id == Grupo_id));
        }

        [HttpPost]
        public ActionResult modificarGrupo(int Grupo_id, EntidadGrupo Grupo)
        {
            DALGrupo ObjGrupo = new DALGrupo();

            ObjGrupo.ModificarGrupo(Grupo);

            return RedirectToAction("GrupoListado");

        }
        public ActionResult eliminarGrupo(int Grupo_id)
        {
            try
            {
                DALGrupo ObjGrupo = new DALGrupo();

                if (ObjGrupo.InactivarGrupo(Grupo_id))
                {
                    ViewBag.Mensaje = "Grupo eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Grupo";
                }

                return RedirectToAction("GrupoListado");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult eliminarAdminGrupo(int Grupo_id)
        {
            try
            {
                DALGrupo ObjGrupo = new DALGrupo();

                if (ObjGrupo.EliminarGrupo(Grupo_id))
                {
                    ViewBag.Mensaje = "Grupo eliminado";
                }
                else
                {
                    ViewBag.Mensaje = "Hubo problemas al eliminar el Grupo";
                }

                return RedirectToAction("ListadoInactivosGrupo");

            }
            catch
            {
                return View();
            }

        }
        public ActionResult ListadoInactivosGrupo()
        {
            DALGrupo ObjGrupo = new DALGrupo();
            ModelState.Clear();

            return View(ObjGrupo.ListarIncativoGrupo());
        }
        public ActionResult ActivarGrupo(int Grupo_id)
        {
            DALGrupo ObjGrupo = new DALGrupo();
            ModelState.Clear();
            ObjGrupo.ActivarGrupo(Grupo_id);
            return RedirectToAction("ListadoInactivosGrupo");

        }
    }
}