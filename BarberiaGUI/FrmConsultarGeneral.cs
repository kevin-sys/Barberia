using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberiaGUI
{
    public partial class FrmConsultarGeneral : Form
    {
        public FrmConsultarGeneral()
        {
            InitializeComponent();
        }

        private void FrmConsultarGeneral_Load(object sender, EventArgs e)
        {

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrar registrar = new FrmRegistrar();
            registrar.Show();
            this.Visible = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FrmConsultar consultar = new FrmConsultar();
            consultar.Show();
            this.Visible = false;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            FrmConsultarEmpleado consultarEmpleado = new FrmConsultarEmpleado();
            consultarEmpleado.Show();
            this.Visible = false;
        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            FrmGestionarGeneral general = new FrmGestionarGeneral();
            general.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmConsultarProducto producto = new FrmConsultarProducto();
            producto.Show();
            this.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmConsultarProveedor proveedor = new FrmConsultarProveedor();
            proveedor.Show();
            this.Visible = false;
        }
    }
}
