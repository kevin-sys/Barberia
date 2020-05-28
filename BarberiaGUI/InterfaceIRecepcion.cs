using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
namespace BarberiaGUI
{
    public interface InterfaceIRecepcion
    {
        void Recibir(RegistrarProducto producto);
        void RecibirProveedor(Proveedor proveedor);
    }
}
