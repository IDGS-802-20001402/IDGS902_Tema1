using IDGS92_Tema1.Models;
using IDGS92_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS92_Tema1.Controllers
{
    public class TriangulosController : Controller
    {
        // GET: Triangulos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ObtenerDatos(double x1, double  y1, double x2, double y2, double x3, double y3)
        {
            var triangulo = new Triangulo();

            triangulo.x1 = x1;
            triangulo.y1 = y1;

            triangulo.x2 = x2;
            triangulo.y2 = y2;

            triangulo.x3 = x3;
            triangulo.y3 = y3;

            ViewBag.EsTriangulo = triangulo.EsTriangulo();
            
            if (triangulo.EsTriangulo())
            {
                ViewBag.TipoTriangulo = triangulo.TipoTriangulo();
                new TrianguloService().GuardarTriangulo(triangulo);

                ViewBag.Area = Math.Round(triangulo.AreaTriangulo(), 2);
            }
            else
            {
                ViewBag.TipoTriangulo = "No es un triangulo";
            }

            return View();
        }

        public ActionResult VerHistorial()
        {
            var lista = new TrianguloService().ObtenerRegistros();

            ViewBag.Lista = lista;

            return View();
        }
    }
}