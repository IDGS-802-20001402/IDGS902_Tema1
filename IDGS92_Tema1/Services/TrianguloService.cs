using IDGS92_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS92_Tema1.Services
{
    public class TrianguloService
    {
        public void GuardarTriangulo(Triangulo triangulo)
        {
            var lado1 = Math.Round(triangulo.DistanciaPuntos(triangulo.x1, triangulo.y1, triangulo.x2, triangulo.y2), 2);
            var lado2 = Math.Round(triangulo.DistanciaPuntos(triangulo.x1, triangulo.y1, triangulo.x3, triangulo.y3), 2);
            var lado3 = Math.Round(triangulo.DistanciaPuntos(triangulo.x2, triangulo.y2, triangulo.x3, triangulo.y3), 2);
            var tipo = triangulo.TipoTriangulo();
            var area = Math.Round(triangulo.AreaTriangulo(), 2);


            //var datos = lado1 + "," + lado2 + "," + lado3 + "," + tipo + "\n";
            var datos = triangulo.x1 + "," + triangulo.y1 + "," + triangulo.x2 + "," + triangulo.y2 + "," + triangulo.x3 + "," + triangulo.y3 + "," + lado1 + "," + lado2 + "," + lado3 + "," + tipo + "," + area + "\n";
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            File.AppendAllText(archivo, datos);
        }

        public List<string> ObtenerRegistros()
        {
             var lista = new List<string>();

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            var lineas = File.ReadAllLines(archivo);

            foreach (var linea in lineas)
            {
                var datos = linea.Split(',');

                var x1 = Convert.ToDouble(datos[0]);
                var y1 = Convert.ToDouble(datos[1]);
                var x2 = Convert.ToDouble(datos[2]);
                var y2 = Convert.ToDouble(datos[3]);
                var x3 = Convert.ToDouble(datos[4]);
                var y3 = Convert.ToDouble(datos[5]);
                var lado1 = Convert.ToDouble(datos[6]);
                var lado2 = Convert.ToDouble(datos[7]);
                var lado3 = Convert.ToDouble(datos[8]);
                var tipo = datos[9];
                var area = Convert.ToDouble(datos[10]);


                lista.Add(x1 + "," + y1 + "," + x2 + "," + y2 + "," + x3 + "," + y3 + "," + lado1 + "," + lado2 + "," + lado3 + "," + tipo + "," + area);
                
            }

            return lista;

        }
    }
}