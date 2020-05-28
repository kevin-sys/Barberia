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
    public partial class FrmRegistrarCliente : Form
    {
        Cliente cliente;
        
        public FrmRegistrarCliente()
        {
            InitializeComponent();
            CmbSexo.SelectedIndex = 0;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.Nombre = TxtNombre.Text;
            cliente.SegundoNombre = TxtSegundoNombre.Text;
            cliente.Apellido = TxtSegundoApellido.Text;
            cliente.SegundoApellido = TxtSegundoApellido.Text;
            cliente.Identificacion = TxtIdentificacion.Text;
            cliente.Telefono = TxtTelefono.Text;
            cliente.FechaNacimiento = DtaFechaNacimiento.Value.Date;
            cliente.Sexo = CmbSexo.Text;
            cliente.Correo = TxtCorreo.Text;
            cliente.Direccion = TxtDireccion.Text;
            cliente.Ciudad = TxtCiudad.Text;
            cliente.Departamento = TxtDepartamento.Text;
            cliente.Pais = TxtPais.Text;
            cliente.FechaRegistro = dtaFechaRegistro.Value.Date;
            return cliente;
        }
        

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
      

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.Show();
            this.Visible = false;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarGeneral consultarGeneral = new FrmConsultarGeneral();
            consultarGeneral.Show();
            this.Visible = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearCliente();
            ClienteService service = new ClienteService();
            string mensaje = service.Guardar(cliente);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            FrmRegistrar registrar = new FrmRegistrar();
            registrar.Show();
            this.Visible = false;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void Limpiar()
        {
            TxtNombre.Text = "";
            TxtSegundoNombre.Text = "";
            TxtApellido.Text = "";
            TxtSegundoApellido.Text = "";
            TxtDepartamento.Text = "";
            TxtCiudad.Text = "";
            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtIdentificacion.Text = "";
            TxtPais.Text = "";
            TxtTelefono.Text = "";
            DtaFechaNacimiento.Text = "";
            CmbSexo.Text = "Seleccione";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
