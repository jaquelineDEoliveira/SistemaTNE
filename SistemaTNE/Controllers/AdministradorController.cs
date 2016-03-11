using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaTNE.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador/Visualizar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NovoUsuario()
        {
            return View();
        }

        public ActionResult ImportarDados()
        {
            return View();
        }
    }
}
