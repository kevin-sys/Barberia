using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;


namespace DAL
{
    public class ProveedorRepository
    {

        private SqlConnection connection;
        List<Proveedor> proveedores;
        public ProveedorRepository(SqlConnection connectionDb)
        {
            connection = connectionDb;
            proveedores = new List<Proveedor>();
        }
        public void Guardar(Proveedor proveedor)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "Insert into Proveedor (CodigoProveedor, NombreProveedor, Telefono, Correo, Domicilio, FechaRegistro) values (@CodigoProveedor, @NombreProveedor, @Telefono, @Correo, @Domicilio,  @FechaRegistro)";
                command.Parameters.AddWithValue("@CodigoProveedor", proveedor.CodigoProveedor);
                command.Parameters.AddWithValue("@NombreProveedor", proveedor.NombreProveedor);
                command.Parameters.AddWithValue("@Telefono", proveedor.Telefono);
                command.Parameters.AddWithValue("@Correo", proveedor.Correo);
                command.Parameters.AddWithValue("@Domicilio", proveedor.Domicilio);
                command.Parameters.AddWithValue("@FechaRegistro", proveedor.FechaRegistro);
                command.ExecuteNonQuery();
            }
        }

        public void Eliminar(string codigoProveedor)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "delete from Proveedor where CodigoProveedor=@CodigoProveedor";
                command.Parameters.AddWithValue("@CodigoProveedor", codigoProveedor);
                command.ExecuteNonQuery();
            }

        }

        public List <Proveedor> Consultar()
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Proveedor";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Proveedor proveedor = new Proveedor();
                    proveedor = Mapear(Reader);
                    proveedores.Add(proveedor);
                }
            }
            return proveedores;
        }

        private Proveedor Mapear(SqlDataReader reader)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.CodigoProveedor = (string)reader["CodigoProveedor"];
            proveedor.NombreProveedor = (string)reader["NombreProveedor"];
            proveedor.Correo = (string)reader["Correo"];
            proveedor.Telefono = (string)reader["Telefono"];
            proveedor.Domicilio = (string)reader["Domicilio"];
            proveedor.FechaRegistro = (DateTime)reader["FechaRegistro"];
            return proveedor;
        }

    }
}
