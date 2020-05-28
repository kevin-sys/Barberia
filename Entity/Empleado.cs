using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado:Persona
    {
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Pais { get; set; }
        public string TipoDeJornada { get; set; }
        public float Sueldo { get; set; }
        public string Cargo { get; set; }
        public string PeriocidadDePago { get; set; }
    }
}
