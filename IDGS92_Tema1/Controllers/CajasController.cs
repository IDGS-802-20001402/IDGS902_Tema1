using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS92_Tema1.Controllers
{
    public class CajasController : Controller
    {
        // GET: Cajas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NumCajas(string num) {
            
            int num_cajas = Convert.ToInt16(num);

            ViewBag.NumCajas = num_cajas;

            return View();
        }

        public ActionResult Calcular(List<float> numeros) {

            float max = numeros.Max();
            float min = numeros.Min();
            float sum = numeros.Sum();
            float prom = numeros.Average();
            List<float> duplicados = new List<float>();

            ViewBag.max = max;
            ViewBag.min = min;
            ViewBag.sum = sum;
            ViewBag.prom = prom;

            foreach (float numero in numeros)
            {
                List<float> dup = numeros.FindAll(n => n.Equals(numero));

                if (dup.Count > 1)
                {
                    if (!duplicados.Contains(numero))
                    {
                        duplicados.Add(numero);
                    }
                }
            }

            ViewBag.duplicados = duplicados;

            return View();

        }
    }
}