using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace BarberiaGUI
{
    public partial class GestionProducto : Form
    {
       
        public GestionProducto()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RegistrarProductoService service = new RegistrarProductoService();
            string codigoProducto = TxtCodigoProducto.Text;
            if (codigoProducto != "")
            {
                RegistrarProducto registrar = service.BuscarID(codigoProducto);
            
            if (registrar != null)
            {
                TxtDescripcion.Text = registrar.Descripcion;
                TxtNombreProducto.Text = registrar.NombreProducto;
                DtaFechaRegistro.Value = registrar.FechaRegistro;
            }
            else
            {
                MessageBox.Show($"El producto con el codigo:  {codigoProducto} NO SE ENCUENTRA EN NUESTRA BASE DE DATOS");
            }
        }
            else
            {
                MessageBox.Show("Digite codigo del producto");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Esta seguro de eliminar el registro, PARA SIEMPRE!", "Eliminar Registro", MessageBoxButtons.YesNo);
            if (respuesta==DialogResult.Yes)
            {
                RegistrarProductoService service = new RegistrarProductoService();
                string codigo = TxtCodigoProducto.Text;
                string msjeliminado = service.Eliminar(codigo);
                MessageBox.Show(msjeliminado);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { 
            if (TxtCodigoProducto.Text!="" && TxtDescripcion.Text != "" && TxtNombreProducto.Text!="" && DtaFechaRegistro!=null )
            {
                RegistrarProductoService productoService = new RegistrarProductoService();
                RegistrarProducto producto = new RegistrarProducto();
                producto.CodigoProducto = TxtCodigoProducto.Text;
                producto.Descripcion = TxtDescripcion.Text;
                producto.NombreProducto = TxtNombreProducto.Text;
                producto.FechaRegistro = DtaFechaRegistro.Value.Date;
                productoService.EditarProducto(producto);
                MessageBox.Show("SE MODIFICO CORRECTAMENTE EL REGISTRO");
            }
            else
            {
                MessageBox.Show("ALGUNOS CAMPOS ESTAN VACIOS");
            }
        }

        private void GestionProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
