using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionVentas
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmListadoProductos frmListadoProductos = new();
            frmListadoProductos.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            lblUsuario.Text = Program.NombreEmpleadoLogueado;
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CapturarFechaSistema();
        }
        private void CapturarFechaSistema()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text= DateTime.Now.ToShortTimeString();
        }
    }
}
