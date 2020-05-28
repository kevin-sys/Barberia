using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
using System.Data.SqlClient;

namespace DAL
{
    public class ComprarProductoRepository
    {
        private SqlConnection connection;
        private List<ComprarProducto> productos;
        public ComprarProductoRepository(SqlConnection connectionDb)
        {
            connection = connectionDb;
            productos = new List<ComprarProducto>();
        }

        public void Guardar(ComprarProducto producto)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO ComprarProducto (CodigoCompra, CodigoProducto, NombreProducto, FechaCompra, Proveedor, CodigoProveedor, TotalCompra, TotalVenta, Ganancia, Cantidad, PrecioCompra, PrecioVenta, PorcentajeGanancia) VALUES (@CodigoCompra, @CodigoProducto, @NombreProducto, @FechaCompra, @Proveedor, @CodigoProveedor, @TotalCompra, @TotalVenta, @Ganancia, @Cantidad, @PrecioCompra, @PrecioVenta, @PorcentajeGanancia)";
                command.Parameters.AddWithValue("@CodigoCompra", producto.CodigoCompra);
                command.Parameters.AddWithValue("@CodigoProducto",producto.CodigoProducto);
                command.Parameters.AddWithValue("@NombreProducto", producto.NombreProducto);
                command.Parameters.AddWithValue("@FechaCompra", producto.FechaCompra);
                command.Parameters.AddWithValue("@Proveedor", producto.Proveedor);
                command.Parameters.AddWithValue("@CodigoProveedor", producto.CodigoProveedor);
                command.Parameters.AddWithValue("@TotalCompra", producto.totalPrecioCompra);
                command.Parameters.AddWithValue("@TotalVenta", producto.totalPrecioVenta);
                command.Parameters.AddWithValue("@Ganancia", producto.gananciaTotal);
                command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                command.Parameters.AddWithValue("@PrecioCompra", producto.PrecioCompra);
                command.Parameters.AddWithValue("@PrecioVenta", producto.PrecioVenta);
                command.Parameters.AddWithValue("@PorcentajeGanancia", producto.PorcentajeGanancia);
                command.ExecuteNonQuery();
            }
        }
    }
}
