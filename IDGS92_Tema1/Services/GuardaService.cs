using IDGS92_Tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS92_Tema1.Services
{
    public class GuardaService
    {
        public void GuardaArchivo(Maestros maestro)
        {
            var nombre = maestro.Nombre;
            var apaterno = maestro.Apaterno;
            var amaterno = maestro.Amaterno;
            var edad = maestro.Edad;
            var email = maestro.Email;
            var datos = nombre + ", " + apaterno + ", " + amaterno + ", " + edad + ", " + email + "\n";
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            File.AppendAllText(archivo, datos);
        }
    }
}