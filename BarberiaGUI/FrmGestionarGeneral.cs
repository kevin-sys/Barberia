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
    public partial class FrmGestionarGeneral : Form
    {
        public FrmGestionarGeneral()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GestionProducto gestion = new GestionProducto();
            gestion.Visible = true;
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmRegistrar frmRegistrar = new FrmRegistrar();
            frmRegistrar.Show();
            this.Visible = false;
        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            FrmConsultarGeneral consultarGeneral = new FrmConsultarGeneral();
            consultarGeneral.Visible = true;
            this.Close();
        }
    }
}
