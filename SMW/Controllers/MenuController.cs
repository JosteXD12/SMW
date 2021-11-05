using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SMW.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        [Authorize]
        public ActionResult VistaMenu()
        {
            return View();
        }

         
        public ActionResult Login(string Usuario_nick, string Usuario_Contrasenna)
        {
          
            try
            {
                if (!string.IsNullOrEmpty(Usuario_nick) && !string.IsNullOrEmpty(Usuario_Contrasenna))
                {
                    
                    DALUsuario ObjUser = new DALUsuario();
                    var user = ObjUser.login(Usuario_nick, Usuario_Contrasenna);

                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(user.Usuario_nick + "," + user.Usuario_Area , true);
                        return RedirectToAction("VistaMenu");

                    }
                    else
                    {
                        ViewBag.Mensaje = "Datos erroneos";   
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