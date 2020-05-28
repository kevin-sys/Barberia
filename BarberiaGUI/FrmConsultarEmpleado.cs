using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace BarberiaGUI
{
    public partial class FrmConsultarEmpleado : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=SERVIDORGOMEZ;Initial Catalog=BarberSoft;Integrated Security=True");
        public FrmConsultarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmConsultarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from Empleado", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DtaTablaEmpleados.DataSource = tabla;

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FrmConsultarGeneral consultarGeneral = new FrmConsultarGeneral();
            consultarGeneral.Show();
            this.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
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
