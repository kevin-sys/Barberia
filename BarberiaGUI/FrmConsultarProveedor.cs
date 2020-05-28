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
    public partial class FrmConsultarProveedor : Form
    {
        InterfaceIRecepcion FrmRecepcion;
        ProveedorService service = new ProveedorService();
        public FrmConsultarProveedor()
        {
            InitializeComponent();
        }

        public FrmConsultarProveedor(InterfaceIRecepcion recepcion)
        {
            InitializeComponent();
            FrmRecepcion = recepcion;
        }
        
        private void FrmConsultarProveedor_Load(object sender, EventArgs e)
        {

        }

        List<Proveedor> proveedores = new List<Proveedor>();

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DtaTablaEmpleados.DataSource = null;
            proveedores.Clear();
            proveedores = service.Consultar();
            DtaTablaEmpleados.DataSource = proveedores;
        }

        private void DtaTablaEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FrmRecepcion!=null)
            {
                Proveedor proveedor = (Proveedor)DtaTablaEmpleados.CurrentRow.DataBoundItem;
                FrmRecepcion.RecibirProveedor(proveedor);
                this.Hide();
            }
        }
    }
}
