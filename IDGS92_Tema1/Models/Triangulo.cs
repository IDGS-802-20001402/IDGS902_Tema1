using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast.Selectors;

namespace IDGS92_Tema1.Models
{
    public class Triangulo
    {
        public double x1 { get; set; }
        public double y1 { get; set; }

        public double x2 { get; set; }
        public double y2 { get; set; }

        public double x3 { get; set; }
        public double y3 { get; set; }

        public Boolean EsTriangulo()
        {
            if (x1 == x2 && y1 == y2 || x1 == x3 && y1 == y3 || x2 == x3 && y2 == y3)
            {
                return false;
            }
            else
            {
                if ((y2 - y1) / (x2 - x1) == (y3 - y2) / (x3 - x2))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public double DistanciaPuntos(double x1, double y1, double x2, double y2)
        {

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            return distancia;

        }

        public string TipoTriangulo()
        {

            double lado1 = Math.Round(DistanciaPuntos(x1, y1, x2, y2), 2);
            double lado2 = Math.Round(DistanciaPuntos(x1, y1, x3, y3), 2);
            double lado3 = Math.Round(DistanciaPuntos(x2, y2, x3, y3), 2);

            if (lado1 == lado2 && lado1 == lado3)
            {
                return "Equilatero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "Isosceles";
            }
            else
            {
                return "Escaleno";
            }
        }

        public double AreaTriangulo()
        {
            double lado1 = Math.Round(DistanciaPuntos(x1, y1, x2, y2), 2);
            double lado2 = Math.Round(DistanciaPuntos(x1, y1, x3, y3), 2);
            double lado3 = Math.Round(DistanciaPuntos(x2, y2, x3, y3), 2);

            double s = Math.Round(((Math.Round(lado1,2) + Math.Round(lado2, 2) + Math.Round(lado3, 2)) / 2), 2 );

            double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));

            return area;
        }
    }
}