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
    public  class EmpleadoService
    {
        SqlConnection connection;
        string CadenaCnexion = @"Data Source=SERVIDORGOMEZ;Initial Catalog=BarberSoft;Integrated Security=True";
        EmpleadoRepository empleadoRepository;
        public EmpleadoService()
        {
            connection = new SqlConnection(CadenaCnexion);
            empleadoRepository = new EmpleadoRepository(connection);
        }

        public string Guardar(Empleado empleado)
        {

            try
            {
                connection.Open();
                empleadoRepository.Guardar(empleado);
                return "se guardo el empleado correctamente";

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
        public string ConsultarTodos(Empleado empleado)
        {
            try
            {
                connection.Open();
                empleadoRepository.ConsultarTodos(empleado);
                return "se consulto correctamente";

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
    }
}
