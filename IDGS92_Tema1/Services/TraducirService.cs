using IDGS92_Tema1.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace IDGS92_Tema1.Services
{
    public class TraducirService
    {
        public Traduccion ObtenerTraduccion(string pBuscar, string idioma)
        {
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            var palabras = System.IO.File.ReadAllLines(archivo);

            foreach (var linea in palabras)
            {
                var palabra = linea.Split(',');

                if (idioma.Equals("espanol"))
                {
                    if (palabra[1].Equals(pBuscar.ToLower()))
                    {
                        return new Traduccion
                        {
                            Ingles = palabra[0],
                            Espanol = palabra[1]
                        };
                    }
                }
                else
                {
                    if (palabra[0].Equals(pBuscar.ToLower()))
                    {
                        return new Traduccion
                        {
                            Ingles = palabra[0],
                            Espanol = palabra[1]
                        };
                    }
                }
            }

            return null;
        }

        public void GuardarTraduccion(Traduccion trad)
        {
            string archivo;
            var existe = System.IO.File.Exists(HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt"));
            if (existe)
            {
                archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");

            }
            else
            {
                System.IO.File.Create(HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt")).Close();
                archivo = HttpContext.Current.Server.MapPath("~/App_Data/diccionario.txt");
            }

            if(trad.Ingles.IsNullOrWhiteSpace() || trad.Espanol.IsNullOrWhiteSpace())
            {
                return;
            }

            var palabras = archivo.Split('\n');

            foreach (var linea in palabras)
            {
                var palabra = linea.Split(',');

                if (palabra[0] == trad.Ingles)
                {
                    return;
                }
            }

            var datos = trad.Ingles.ToLower() + "," + trad.Espanol.ToLower() + "\n";

            System.IO.File.AppendAllText(archivo, datos);

            return;
        }
    }
}