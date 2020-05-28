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
    public partial class FrmComprarProducto : Form,InterfaceIRecepcion
    {
        ComprarProducto comprarProducto;
        public FrmComprarProducto()
        {
            InitializeComponent();
        }
        public void Recibir(RegistrarProducto producto)
        {
            if (producto!=null)
            {
                TxtCodigoProducto.Text = producto.CodigoProducto;
                TxtNombreProducto.Text = producto.NombreProducto;
            }
        }
        public void RecibirProveedor(Proveedor proveedor)
        {
            if(proveedor!=null)
            {
                TxtCodigoProveedor.Text = proveedor.CodigoProveedor;
                TxtProveedor.Text = proveedor.NombreProveedor;
            }
        }
        private void FrmComprarProducto_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            FrmGestionarGeneral general = new FrmGestionarGeneral();
            general.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmConsultarProducto producto = new FrmConsultarProducto(this);
            producto.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmConsultarProveedor consultarEmpleado = new FrmConsultarProveedor(this);
            consultarEmpleado.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private ComprarProducto MapearCompra()
        {
            comprarProducto = new ComprarProducto();
            comprarProducto.Cantidad = int.Parse(TxtCantidad.Text);
            comprarProducto.CodigoCompra = TxtCodigoCompra.Text;
            comprarProducto.CodigoProducto = TxtCodigoProducto.Text;
            comprarProducto.CodigoProveedor = TxtCodigoProveedor.Text;
            comprarProducto.FechaCompra = DtaFechaRegistro.Value.Date;
            comprarProducto.NombreProducto = TxtNombreProducto.Text;
            comprarProducto.PrecioCompra = float.Parse(TxtPrecioCompra.Text);
            comprarProducto.Proveedor = TxtProveedor.Text;
            comprarProducto.PorcentajeGanancia = float.Parse(TxtPorcentajeGanancia.Text);
            return comprarProducto;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ComprarProductoService service = new ComprarProductoService();
            ComprarProducto comprarProducto = MapearCompra();
            string mensaje = service.Guardar(comprarProducto);
            MessageBox.Show(mensaje, "MENSAJE DE GUARDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
        }
    }
}
