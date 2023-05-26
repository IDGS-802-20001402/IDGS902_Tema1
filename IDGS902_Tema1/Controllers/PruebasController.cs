using IDGS92_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS92_Tema1.Controllers
{
    public class PruebasController : Controller
    {
        // GET: Pruebas
        public ActionResult Index()
        {
            var idgs902 = new Alumnos() { Name = "Crisian", Email = "cristian@gmail.com", Age = 21 };
            return Json(idgs902, JsonRequestBehavior.AllowGet);
            return View();
        }

        public RedirectResult Index2() { 
            return Redirect("google.com");
        }

        public RedirectToRouteResult Index3()
        {
            return RedirectToAction("Operas", "Nuevo");
        }

        public ActionResult Index4() {

            ViewBag.Grupo = "IDGS902";

            ViewBag.Numero = 20;

            ViewBag.FechaInicio = new DateTime(2023, 2, 5);

            ViewData["Nombre"] = "Mario";


            return View();
        }
    }
}