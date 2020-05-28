using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;


namespace DAL
{
    public class ClienteRepository
    {
        private SqlConnection connection;
        private List<Cliente> clientes;
        public ClienteRepository(SqlConnection connectionDb)
        {
            connection = connectionDb;
            clientes = new List<Cliente>();
        }
        public void Guardar (Cliente cliente)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "insert into Cliente (Nombre, segundoNombre, Apellido, SegundoApellido, identificacion, telefono, fechanacimiento, sexo, correo, direccion, ciudad, departamento, pais, FechaRegistro) values  (@Nombre, @segundoNombre, @Apellido, @segundoapellido, @identificacion, @telefono, @fechanacimiento, @sexo, @correo, @direccion, @ciudad, @departamento, @pais, @FechaRegistro) ";
                command.Parameters.AddWithValue("@Nombre",cliente.Nombre);
                command.Parameters.AddWithValue("@SegundoNombre", cliente.SegundoNombre);
                command.Parameters.AddWithValue("@apellido",cliente.Apellido);
                command.Parameters.AddWithValue("@SegundoApellido", cliente.SegundoApellido);
                command.Parameters.AddWithValue("@identificacion", cliente.Identificacion);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@fechanacimiento", cliente.FechaNacimiento);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
                command.Parameters.AddWithValue("@Departamento", cliente.Departamento);
                command.Parameters.AddWithValue("@Pais", cliente.Pais);
                command.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);

                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(string identificacion)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete from Cliente where Idenficacion=@Identificacion";
                command.Parameters.AddWithValue("@identificacion", identificacion);
                command.ExecuteNonQuery();

            }

        }
        private Cliente Mapear(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = (string)reader["Nombre"];
            cliente.SegundoNombre = (string)reader["SegundoNombre"];
            cliente.Apellido = (string)reader["SegundoNombre"];
            cliente.Apellido = (string)reader["Apellido"];
            cliente.SegundoApellido = (string)reader["SegundoApellido"];
            cliente.Identificacion = (string)reader["Identificacion"];
            cliente.Sexo = (string)reader["Sexo"];
            cliente.Telefono=(string)reader["Telefono"];
            cliente.Ciudad = (string)reader["Ciudad"];
            cliente.Direccion = (string)reader["Direccion"];
            cliente.Departamento = (string)reader["Departamento"];
            cliente.Correo = (string)reader["Correo"];
            cliente.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
            cliente.FechaRegistro = (DateTime)reader["FechaRegistro"];

            return cliente;
        }
        public Cliente Buscar(string identificacion)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Cliente WHERE Identificacion = @Identificacion ";
                command.Parameters.AddWithValue("@Identificacion", identificacion);
                var reader = command.ExecuteReader();
                if (reader.HasRows==true)
                {
                    while (reader.Read())
                    {
                        return Mapear(reader);
                    }
                }

            }
            return null;
        }
        public List<Cliente>Consultar()
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Cliente";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente = Mapear(Reader);
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }
        public List<Cliente>ConsultarMujeres()
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Cliente WHERE Sexo='Femenino'";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente = Mapear(Reader);
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }

        public void Modificar(Cliente cliente)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE Cliente SET Nombre = @Nombre, SegundoNombre = @SegundoNombre, Apellido=@Apellido, SegundoApellido=@SegundoApellido, Identificacion=@Identificacion, Telefono=@Telefono, FechaNacimiento=@FechaNacimiento, Sexo=@Sexo, Correo=@Correo, Direccion=@Direccion, Ciudad=@Ciudad, Departamento=@Departamento, Pais=@Pais, FechaRegistro=@FechaRegistro WHERE Identificacion = @Identificacion";
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@SegundoNombre", cliente.SegundoNombre);
                command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("SegundoApellido", cliente.SegundoApellido);
                command.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                command.Parameters.AddWithValue("@Sexo", cliente.Sexo);
                command.Parameters.AddWithValue("@correo", cliente.Correo);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);
                command.Parameters.AddWithValue("@Departamento", cliente.Departamento);
                command.Parameters.AddWithValue("@Pais", cliente.Pais);
                command.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
                command.ExecuteNonQuery();
            }
        }

    }
}
