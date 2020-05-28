using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BarberiaGUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmRegistrar frmRegistrar = new FrmRegistrar();
            frmRegistrar.Show();
            this.Visible = false;
        }

        private void PnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FrmConsultarGeneral consultarGeneral = new FrmConsultarGeneral();
            consultarGeneral.Show();
            this.Visible = false;
        }

        private void PictureBox3_Click(object sender, EventArgs e)
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

        private void PnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void PnlBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnGestion_Click(object sender, EventArgs e)
        {
            FrmGestionarGeneral general = new FrmGestionarGeneral();
            general.Show();
            this.Visible = false;
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            FrmComprarProducto frmComprarProducto = new FrmComprarProducto();
            frmComprarProducto.Show();
            this.Visible = false;
        }

        private void LblHora_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
