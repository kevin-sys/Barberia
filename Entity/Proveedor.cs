﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Proveedor
    {
        public string CodigoProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
