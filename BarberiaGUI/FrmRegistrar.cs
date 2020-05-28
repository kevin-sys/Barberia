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
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FrmRegistrarProducto frmRegistrarproducto = new FrmRegistrarProducto();
            frmRegistrarproducto.Visible = true;
            this.Close();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnRestaurar.Visible = true;
            BtnMaximizar.Visible = false;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PnlMenuVertical.Width == 250)
            {
                PnlMenuVertical.Width = 70;
            }
            else
                PnlMenuVertical.Width = 250;
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            FrmRegistrarCliente frmRegistrarCliente = new FrmRegistrarCliente();
            frmRegistrarCliente.Show();
            this.Visible = false;
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado frmRegistrarEmpleado = new FrmRegistrarEmpleado();
            frmRegistrarEmpleado.Show();
            this.Visible = false;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarGeneral consultarGeneral = new FrmConsultarGeneral();
            consultarGeneral.Show();
            this.Visible = false;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            FrmProveedor frmproveedor = new FrmProveedor();
            frmproveedor.Show();
            this.Visible = false;
            
        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            FrmGestionarGeneral gestion = new FrmGestionarGeneral();
            gestion.Show();
            this.Visible = false;
        }
    }
}
