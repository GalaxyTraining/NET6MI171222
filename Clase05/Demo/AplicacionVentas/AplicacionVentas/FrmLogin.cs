using Negocio;
using System.Data;

namespace AplicacionVentas
{
    public partial class FrmLogin : Form
    {
        UsuarioNegocio usuarioNegocio = new();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim()!="")
            {
                if(txtPassword.Text.Trim()!="")
                {
                    usuarioNegocio.User = txtUsuario.Text;
                    usuarioNegocio.Password=txtPassword.Text;
                  string mensaje=  usuarioNegocio.IniciarSesion();
                    if(mensaje=="Su Contraseña es Incorrecta.")
                    {
                        MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtPassword.Clear();
                        txtPassword.Focus();
                    }
                    else
                        if(mensaje == "El Nombre de Usuario no Existe.")
                       {
                        MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        txtUsuario.Clear();
                        txtPassword.Clear();
                          txtUsuario.Focus();
                        }
                    else
                    {
                        MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        FrmMenuPrincipal frmMenuPrincipal = new();
                        RecuperarDatosSesion();
                        frmMenuPrincipal.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese su Contraseña.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
             
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese Nombre de Usuario.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
            }
        }

        private void RecuperarDatosSesion()
        {
            DataRow row;
            DataTable dt = new();
            dt=usuarioNegocio.DevolverDatosSesion(txtUsuario.Text,txtPassword.Text);
            if(dt.Rows.Count==1)
            {
                row = dt.Rows[0];
                Program.IdEmpleadoLogueado = Convert.ToInt32(row[0].ToString());
                Program.NombreEmpleadoLogueado = row[1].ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}