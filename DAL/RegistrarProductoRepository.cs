using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
namespace DAL
{
    public class RegistrarProductoRepository
    {
        private SqlConnection connection;
        List<RegistrarProducto> registrarProductos;
        public RegistrarProductoRepository(SqlConnection connectionDb)
        {
            connection = connectionDb;
            registrarProductos = new List<RegistrarProducto>();
        }
        public void Guardar(RegistrarProducto registrarProducto)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Insert into RegistrarProducto (CodigoProducto, NombreProducto, Descripcion, FechaRegistro) values (@CodigoProducto, @NombreProducto, @Descripcion, @FechaRegistro)";
                command.Parameters.AddWithValue("@CodigoProducto", registrarProducto.CodigoProducto);
                command.Parameters.AddWithValue("@NombreProducto", registrarProducto.NombreProducto);
                command.Parameters.AddWithValue("@Descripcion", registrarProducto.Descripcion);
                command.Parameters.AddWithValue("FechaRegistro", registrarProducto.FechaRegistro);
                command.ExecuteNonQuery();
            }
        }
        public void Editar(RegistrarProducto producto)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE RegistrarProducto SET NombreProducto = @NombreProducto , Descripcion = @Descripcion , FechaRegistro = @FechaRegistro WHERE CodigoProducto=@CodigoProducto";
                command.Parameters.AddWithValue("@CodigoProducto", producto.CodigoProducto);
                command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                command.Parameters.AddWithValue("FechaRegistro", producto.FechaRegistro);
                command.ExecuteNonQuery();
            }
        }
        public void Eliminar(string codigoProducto)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "DELETE from RegistrarProducto WHERE CodigoProducto=@CodigoProducto";
                command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                command.ExecuteNonQuery();
            }
        }

        public RegistrarProducto Buscar (string codigoProducto)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM RegistrarProducto WHERE CodigoProducto=@CodigoProducto";
                command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
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
        private RegistrarProducto Mapear(SqlDataReader reader)
        {
            RegistrarProducto producto = new RegistrarProducto();
            producto.CodigoProducto = (string)reader["CodigoProducto"];
            producto.Descripcion = (string)reader["Descripcion"];
            producto.FechaRegistro = (DateTime)reader["FechaRegistro"];
            producto.NombreProducto = (string)reader["NombreProducto"];
            return producto;
        }
        public List<RegistrarProducto> Consultar()
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM RegistrarProducto";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    RegistrarProducto producto = new RegistrarProducto();
                    producto = Mapear(Reader);
                    registrarProductos.Add(producto);
                }
            }
            return registrarProductos;
        }

    }
}
