using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data.SqlClient;

namespace BLL
{
   public class ComprarProductoService
    {
        List<ComprarProducto> Productos;
        SqlConnection connection;
        string CadenaConexion = @"Data Source=SERVIDORGOMEZ;Initial Catalog=BarberSoft;Integrated Security=True";
        ComprarProductoRepository repositorio;
        public ComprarProductoService()
        {
            connection = new SqlConnection(CadenaConexion);
            repositorio = new ComprarProductoRepository(connection);
        }
        public string Guardar(ComprarProducto comprarProducto)
        {
            try
            {
                connection.Open();
                repositorio.Guardar(comprarProducto);
                return "SE GUARDO CORRECTAMENTE";
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
    }
}
