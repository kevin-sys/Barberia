using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using Entity;
namespace BLL
{
    public class RegistrarProductoService
    {
        List<RegistrarProducto> productos;
        SqlConnection connection;
        string CadenaCnexion = @"Data Source=SERVIDORGOMEZ;Initial Catalog=BarberSoft;Integrated Security=True";
        RegistrarProductoRepository registrarRepository;
        public RegistrarProductoService()
        {
            connection = new SqlConnection(CadenaCnexion);
            registrarRepository = new RegistrarProductoRepository(connection);
        }
        public string Guardar(RegistrarProducto registrarProducto)
        {
            try
            {
                connection.Open();
                registrarRepository.Guardar(registrarProducto);
                return "se guardo el producto correctamente";

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
        public RegistrarProducto EditarProducto(RegistrarProducto producto)
        {
            try
            {
                connection.Open();
                registrarRepository.Editar(producto);
                return producto;

            }
            catch (Exception ex)
            {
                string mensaje = "ERROR!" + ex.Message;
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public RegistrarProducto BuscarID(string CodigoProducto)
        {
            RegistrarProducto producto = new RegistrarProducto();
            try
            {
                connection.Open();
                return registrarRepository.Buscar(CodigoProducto);
            }
            catch (Exception e)
            {

                string mensaje = " ERROR EN LA BASE DE DATOS " + e.Message;
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public string Eliminar(string codigoProducto)
        {
            try
            {
                connection.Open();
                registrarRepository.Eliminar(codigoProducto);
                return "SE ELIMINO CORRECTAMENTE";

            }
            catch (Exception ex)
            {

                return " ERROR EN LOS DATOS: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<RegistrarProducto> Consultar()
        {
            connection.Open();
            productos = new List<RegistrarProducto>();
            productos = registrarRepository.Consultar();
            connection.Close();
            return productos;
        }
    }
}
