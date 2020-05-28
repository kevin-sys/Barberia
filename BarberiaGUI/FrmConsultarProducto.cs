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
    public partial class FrmConsultarProducto : Form
    {
        InterfaceIRecepcion FrmRecepcion;
        RegistrarProductoService service = new RegistrarProductoService();
        public FrmConsultarProducto()
        {
            InitializeComponent();
        }
        public FrmConsultarProducto(InterfaceIRecepcion recepcion)
        {
            InitializeComponent();
            FrmRecepcion = recepcion;
        }

        private void FrmConsultarProducto_Load(object sender, EventArgs e)
        {

        }

        List<RegistrarProducto> productos = new List<RegistrarProducto>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DtaTablaProductos.DataSource = null;
            productos.Clear();
            productos = service.Consultar();
            DtaTablaProductos.DataSource = productos;
        }

        private void DtaTablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FrmRecepcion!=null)
            {
                RegistrarProducto producto = (RegistrarProducto)DtaTablaProductos.CurrentRow.DataBoundItem;
                FrmRecepcion.Recibir(producto);
                this.Hide();
            }
        }
    }
}
