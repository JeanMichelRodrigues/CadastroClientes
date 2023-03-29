using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroClientes.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Clientes
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Cadastro()
        {
            ViewBag.Message = "Cadastro de Clientes";

            return View();
        }
        public ActionResult Home()
        {
            ViewBag.Message = "Home";

            return View();
        }
    }
}