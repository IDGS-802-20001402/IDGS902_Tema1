using IDGS92_Tema1.Models;
using IDGS92_Tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS92_Tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Ventana()
        {
            return View();
        }

        public ActionResult Operas(string opera, string n1, string n2)
        {
            int res = 0;
            switch (opera) {
                case "suma":
                    res = Convert.ToInt16(n2) + Convert.ToInt16(n1);
                    break;
                case "resta":
                    res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
                    break;
                case "multiplicacion":
                    res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
                    break;
                case "division":
                    res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
                    break;
            }

            ViewBag.Res = Convert.ToString(res);

            return View();
        }

        public ActionResult OperasBas2(Calculos op)
        {
            var model = new Calculos();

            model.Res = op.Num1 + op.Num2;

            ViewBag.Res = model.Res;

            return View(model);
        }

        public ActionResult DistanciaPuntos(Distancia ds)
        {
            var model = new Distancia();

            ds.CalcularDistancia();

            model.DistanciaTotal = ds.DistanciaTotal;

            return View(model);

        }

        public ActionResult MuestraPulques()
        {
            PulqueService pulques1 = new PulqueService();
            var model = pulques1.ObtenerPulque();
            

            return View(model);
        }

        public ActionResult MuestraPulques2()
        {
            PulqueService pulques1 = new PulqueService();
            var model = pulques1.ObtenerPulque();


            return View(model);
        }
    }
}