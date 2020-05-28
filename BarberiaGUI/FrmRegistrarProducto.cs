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
    public partial class FrmRegistrarProducto : Form
        
    {
        RegistrarProducto producto;
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private RegistrarProducto MapearProducto()
        {
            producto = new RegistrarProducto();
            producto.CodigoProducto = TxtCodigoProducto.Text;
            producto.NombreProducto = TxtNombreProducto.Text;
            producto.Descripcion = TxtDescripcion.Text;
            producto.FechaRegistro = DtaFechaRegistro.Value.Date;
            return producto;
        }

        

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegistrarProducto producto = MapearProducto();
            RegistrarProductoService service = new RegistrarProductoService();
            string mensaje = service.Guardar(producto);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmRegistrar registrar = new FrmRegistrar();
            registrar.Visible = true;
            this.Close();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            FrmGestionarGeneral general = new FrmGestionarGeneral();
            general.Show();
            this.Visible = false;
        }
    }
}
