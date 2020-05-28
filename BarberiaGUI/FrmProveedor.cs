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
    public partial class FrmProveedor : Form
    {
        Proveedor proveedor;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private Proveedor MapearProveedor()
        {
            proveedor = new Proveedor();
            proveedor.CodigoProveedor = TxtCodigoProveedor.Text.Trim();
            proveedor.NombreProveedor = TxtNombreProveedor.Text.Trim();
            proveedor.Telefono = TxtTelefono.Text.Trim();
            proveedor.Correo = TxtCorreo.Text.Trim();
            proveedor.Domicilio = TxtDomicilio.Text.Trim();
            proveedor.FechaRegistro = DtaFechaRegistro.Value.Date;
            return proveedor;
        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = MapearProveedor();
            ProveedorService service = new ProveedorService();
            string mensaje = service.Guardar(proveedor);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmRegistrar frmRegistrar = new FrmRegistrar();
            frmRegistrar.Show();
            this.Dispose();
        }
    }
}
