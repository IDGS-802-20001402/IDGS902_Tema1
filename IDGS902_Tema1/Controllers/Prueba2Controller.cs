using IDGS92_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS92_Tema1.Controllers
{
    public class Prueba2Controller : Controller
    {
        // GET: Prueba2
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                Name = "Cristian",
                Age = 21,
                Email = "cristian@gmail.com",
                Activo = true,
                Inscripcion = new DateTime(2023, 5, 2)

            };

            ViewBag.Alumnos = alumno;
            return View();
        }

        public ActionResult Escuela() {
            var alumno = new Alumnos()
            {
                Name = "Cristian",
                Age = 21,
                Email = "cristian@gmail.com",
                Activo = true,
                Inscripcion = new DateTime(2023, 5, 2)

            };

            ViewBag.Alumnos = alumno;
            return View(alumno);
        }
    }
}