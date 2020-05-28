using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class ProveedorService
    {
        List<Proveedor> proveedores;
        SqlConnection connection;
        string CadenaCnexion = @"Data Source=SERVIDORGOMEZ;Initial Catalog=BarberSoft;Integrated Security=True";
        ProveedorRepository proveedorRepository;
        public ProveedorService()
        {
            connection = new SqlConnection(CadenaCnexion);
            proveedorRepository = new ProveedorRepository(connection);
        }

        public string Guardar(Proveedor proveedor)
        {

            try
            {
                connection.Open();
                proveedorRepository.Guardar(proveedor);
                return "se guardo el proveedor correctamente";
            }
            catch (Exception ex)
            {
                return "error de datos: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<Proveedor> Consultar()
        {
            connection.Open();
            proveedores = new List<Proveedor>();
            proveedores = proveedorRepository.Consultar();
            connection.Close();
            return proveedores;
        }
    }

}
