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
    public partial class FrmRegistrarEmpleado : Form
    {
        Empleado empleado;
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmRegistrarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private Empleado MapearEmpleado()
        {
            empleado = new Empleado();
            empleado.Nombre = TxtNombre.Text.Trim();
            empleado.SegundoNombre = TxtSegundoNombre.Text.Trim();
            empleado.Apellido = TxtApellido.Text.Trim();
            empleado.SegundoApellido = TxtSegundoApellido.Text.Trim();
            empleado.Identificacion = TxtIdentificacion.Text.Trim();
            empleado.Telefono = TxtTelefono.Text.Trim();
            empleado.FechaNacimiento = DtaFechaNacimiento.Value.Date;
            empleado.Sexo = CmbSexo.Text.Trim();
            empleado.Correo = TxtCorreo.Text.Trim();
            empleado.Direccion = TxtDireccion.Text.Trim();
            empleado.Ciudad = TxtCiudad.Text.Trim();
            empleado.Departamento = TxtDepartamento.Text.Trim();
            empleado.Pais = TxtPais.Text.Trim();
            empleado.TipoDeJornada = CmbTipoJornada.Text.Trim();
            empleado.Sueldo = float.Parse(TxtSueldo.Text.Trim());
            empleado.Cargo = CmbCargo.Text.Trim();
            empleado.PeriocidadDePago = CmbPeriodoPago.Text.Trim();
            return empleado;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

           
        }

        

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearEmpleado();
            EmpleadoService service = new EmpleadoService();
            string mensaje = service.Guardar(empleado);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarGeneral consultarGeneral = new FrmConsultarGeneral();
            consultarGeneral.Show();
            this.Visible = false;
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
        private void Limpiar()
        {
            TxtNombre.Text="";
            TxtSegundoNombre.Text = "";
            TxtApellido.Text = "";
            TxtSegundoApellido.Text = "";
            TxtDepartamento.Text = "";
            TxtCiudad.Text = "";
            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtIdentificacion.Text = "";
            TxtPais.Text = "";
            TxtSueldo.Text = "";
            TxtTelefono.Text = "";
            CmbCargo.Text = "Seleccione";
            CmbPeriodoPago.Text = "Seleccione";
            CmbSexo.Text = "Seleccione";
            CmbTipoJornada.Text = "Seleccione";
            DtaFechaNacimiento.Text = "";

        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            FrmGestionarGeneral general = new FrmGestionarGeneral();
            general.Show();
            this.Visible = false;
        }
    }
}
