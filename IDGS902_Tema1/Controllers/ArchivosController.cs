using IDGS92_Tema1.Models;
using IDGS92_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS92_Tema1.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar() {

            return View();

        }
        [HttpPost]
        public ActionResult Registrar(Maestros maestro)
        {

            var ope1 = new GuardaService();
            ope1.GuardaArchivo(maestro);

            return View(maestro);

        }


        public ActionResult LeerDatos()
        {
            var arch = new LeerService();
            ViewBag.Archivos = arch.LeerArchivo();
            
            return View();
        }
    }
}