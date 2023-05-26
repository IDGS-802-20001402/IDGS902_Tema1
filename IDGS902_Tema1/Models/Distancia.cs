using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS92_Tema1.Models
{
    public class Distancia
    {
        public double CordenadaX1 { get; set; }
        public double CordenadaY1 { get; set; }
        public double CordenadaX2 { get; set; }
        public double CordenadaY2 { get; set; }
        public double DistanciaTotal { get; set; }

        public void CalcularDistancia()
        {
            double res = 0;

            res = Math.Sqrt(Math.Pow(this.CordenadaX2 - this.CordenadaX1, 2) + Math.Pow((this.CordenadaY2 - this.CordenadaY1), 2));

            this.DistanciaTotal = res;
        }
    }
}