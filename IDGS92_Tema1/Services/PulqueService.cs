using IDGS92_Tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS92_Tema1.Services
{
    public class PulqueService
    {
        public List<Pulques> ObtenerPulque()
        {
            var pulque1 = new Pulques()
            {
                Producto = "Pulque1",
                Descripcion = "Mango Piña",
                Litros = 20,
                Creacion = new DateTime(2023, 5, 10)
            };

            var pulque2 = new Pulques()
            {
                Producto = "Pulque2",
                Descripcion = "Coco",
                Litros = 20,
                Creacion = new DateTime(2023, 5, 10)
            };

            var pulque3 = new Pulques()
            {
                Producto = "Pulque3",
                Descripcion = "Fresa",
                Litros = 20,
                Creacion = new DateTime(2023, 5, 10)
            };

            return new List<Pulques>
            {
                pulque1, pulque2, pulque3
            };
        }
    }
}