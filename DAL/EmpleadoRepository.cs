using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.IO;
using System.Data.SqlClient;


namespace DAL
{
    public class EmpleadoRepository
    {
        private SqlConnection connection;
        List<Empleado> empleados;
        public EmpleadoRepository(SqlConnection connectionDb)
        {
            connection = connectionDb;
            empleados = new List<Empleado>(); 
        }
        public void Guardar(Empleado empleado)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Insert into Empleado (Nombre, SegundoNombre, Apellido, SegundoApellido, Identificacion, Telefono, FechaNacimiento, Sexo, Correo, Direccion, Ciudad, Departamento, Pais, TipoDeJornada, Sueldo, Cargo, PeriocidadDePago) values (@Nombre, @SegundoNombre, @Apellido, @SegundoApellido, @Identificacion, @Telefono, @FechaNacimiento, @Sexo, @Correo, @Direccion, @Ciudad, @Departamento, @Pais, @TipoDeJornada, @Sueldo, @Cargo, @PeriocidadDePago)";
                command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                command.Parameters.AddWithValue("@SegundoNombre", empleado.SegundoNombre);
                command.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                command.Parameters.AddWithValue("@SegundoApellido", empleado.SegundoApellido);
                command.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@FechaNacimiento", empleado.FechaNacimiento);
                command.Parameters.AddWithValue("@Sexo", empleado.Sexo);
                command.Parameters.AddWithValue("@Correo", empleado.Correo);
                command.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                command.Parameters.AddWithValue("@Ciudad", empleado.Ciudad);
                command.Parameters.AddWithValue("@Departamento", empleado.Departamento);
                command.Parameters.AddWithValue("@Pais", empleado.Pais);
                command.Parameters.AddWithValue("@TipoDeJornada", empleado.TipoDeJornada);
                command.Parameters.AddWithValue("@Sueldo", empleado.Sueldo);
                command.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                command.Parameters.AddWithValue("@periocidadDePago", empleado.PeriocidadDePago);
                command.ExecuteNonQuery();
            }
        }
        public void Eliminar(Empleado empleado)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete from Empleado where Idenficacion=@Identificacion";
                command.Parameters.AddWithValue("@identificacion", empleado.Identificacion);
                command.ExecuteNonQuery();

            }

        }
        public void ConsultarTodos(Empleado empleado)
        {
            using (var command = connection.CreateCommand())
            {
                SqlCommand comando = new SqlCommand("Select * from Empleado", connection);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
            }
        }

    }
}
