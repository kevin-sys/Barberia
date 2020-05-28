using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace BarberiaGUI
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FrmConsultarGeneral consultarGeneral = new FrmConsultarGeneral();
            consultarGeneral.Show();
            this.Visible = false;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FrmRegistrar registrar = new FrmRegistrar();
            registrar.Show();
            this.Visible = false;
        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            FrmGestionarGeneral general = new FrmGestionarGeneral();
            general.Show();
            this.Visible = false;
        }
    }
}
