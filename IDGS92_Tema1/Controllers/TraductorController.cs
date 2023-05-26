using IDGS92_Tema1.Models;
using IDGS92_Tema1.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace IDGS92_Tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Index(string palabra = "", string idioma = "")
        {
            
            var diccionario = new Dictionary<string, string>();

            if (palabra.IsNullOrWhiteSpace() || palabra.IsNullOrWhiteSpace())
            {
                try
                {
                    var archivo = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/diccionario.txt"));
                    
                    foreach (var linea in archivo)
                    {
                        var palabras = linea.Split(',');
                        diccionario.Add(palabras[0], palabras[1]);
                    }

                    ViewBag.Diccionario = diccionario;
                }
                catch (Exception)
                {
                    ViewBag.Diccionario = null;
                }

            } 
            else
            {
                var traduccionService = new TraducirService();
                var traduccion = traduccionService.ObtenerTraduccion(palabra, idioma);

                if (traduccion != null)
                {
                    diccionario.Add(traduccion.Ingles, traduccion.Espanol);
                    ViewBag.Diccionario = diccionario;
                }

            }

            return View();
        }

        public ActionResult GuardarTraduccion(Traduccion trad)
        {
            var traduccionService = new TraducirService();
            traduccionService.GuardarTraduccion(trad);

            return RedirectToAction("Index");
        }
    }
}