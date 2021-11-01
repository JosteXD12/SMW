using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMW.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult VistaMenu()
        {
            return View();
        }
        public ActionResult Login(string Usuario_nick, string Usuario_Contrasenna)
        {
            ModelState.Clear();
            try
            {
                if (ModelState.IsValid)
                {
                    DALUsuario ObjUser = new DALUsuario();

                    if (ObjUser.login(Usuario_nick, Usuario_Contrasenna))
                    {
                        ViewBag.Mensaje = "Usuario a sido loguado con exito";
                        return RedirectToAction("VistaMenu");
                    }
                    else
                    {
                        ViewBag.Mensaje = "Error al loguarse";
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
    }
}