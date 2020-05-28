using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ComprarProducto
    {
        public string CodigoProducto { get; set; }
        public string CodigoCompra { get; set; }
        public string NombreProducto { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Proveedor { get; set; }
        public string CodigoProveedor { get; set; }
        public int Cantidad { get; set; }
        public float PrecioCompra { get; set; }
        public float PorcentajeGanancia { get; set; }


        public float PrecioVenta { 
            get
            {
                float precioventa = 0;
                precioventa = (PrecioCompra * PorcentajeGanancia) / 100+ PrecioCompra;
                return precioventa;
            }
        }

        public float totalPrecioCompra
        {
            get
            {
                float totalCompra = 0;
                totalCompra = Cantidad * PrecioCompra;
                return totalCompra;
            }
            
        }

        public float totalPrecioVenta
        {
            get
            {
                float totalVenta = 0;
                totalVenta = Cantidad * PrecioVenta;
                return totalVenta;

            }
           
        }

        public float gananciaTotal
        {
            get
            {
                float gananciaTotal = 0;
                gananciaTotal = (Cantidad * PrecioVenta) - (Cantidad * PrecioCompra);
                return gananciaTotal;
            }
            
        }
    }
}
