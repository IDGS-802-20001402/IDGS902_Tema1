using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS92_Tema1.Services
{
    public class LeerService
    {
        public Array LeerArchivo()
        {
            Array maestro = null;

            var datos = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");

            if (File.Exists(datos))
            {
                maestro = File.ReadAllLines(datos);
            }

            return maestro;
        }
    }
}