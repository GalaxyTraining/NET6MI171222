using Negocio;

namespace AplicacionVentas
{
    public partial class FrmRegistroProductos : Form
    {

        ProductosNegocio productosNegocio = new();
        CategoriaNegocio categoriaNegocio= new();
        public FrmRegistroProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if(txtProducto.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Por Favor Ingrese Nombre del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProducto.Focus();
            }
           else  if(txtMarca.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por Favor Ingrese Marca del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarca.Focus();
            }
            else if (txtPCompra.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por Favor Ingrese Precio de Compra del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPCompra.Focus();
            }
            else if (txtPVenta.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por Favor Ingrese Precio de Venta del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPVenta.Focus();
            }
            else if (txtStock.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Por Favor Ingrese Stock del Producto.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Focus();
            }
            else
            {
                if (Program.Evento == 0)
                {
                    productosNegocio.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                    productosNegocio.Producto = txtProducto.Text;
                    productosNegocio.Marca = txtMarca.Text;
                    productosNegocio.PrecioCompra = Convert.ToDecimal(txtPCompra.Text);
                    productosNegocio.PrecioVenta = Convert.ToDecimal(txtPVenta.Text);
                    productosNegocio.Stock = Convert.ToInt32(txtStock.Text);
                    productosNegocio.FechaVencimiento = Convert.ToDateTime(dateTimePicker1.Value);
                    mensaje = productosNegocio.RegistrarProductos();
                    if (mensaje == "Este Producto ya ha sido Registrado.")
                    {
                        MessageBox.Show(mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                else
                {
                    productosNegocio.IdP = Convert.ToInt32(txtIdP.Text);
                    productosNegocio.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                    productosNegocio.Producto = txtProducto.Text;
                    productosNegocio.Marca = txtMarca.Text;
                    productosNegocio.PrecioCompra = Convert.ToDecimal(txtPCompra.Text);
                    productosNegocio.PrecioVenta = Convert.ToDecimal(txtPVenta.Text);
                    productosNegocio.Stock = Convert.ToInt32(txtStock.Text);
                    productosNegocio.FechaVencimiento = Convert.ToDateTime(dateTimePicker1.Value);
                    MessageBox.Show(productosNegocio.ActualizarProductos(), "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }


        }

        private void Limpiar()
        {
            txtProducto.Text = "";
            txtMarca.Clear();
            txtPCompra.Clear();
            txtPVenta.Clear();
            IdC.Clear();
            txtIdP.Clear();
            txtStock.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtProducto.Focus();
        }

        private void FrmRegistroProductos_Load(object sender, EventArgs e)
        {
            ListarElementos();
        }
        private void ListarElementos()
        {
            if (IdC.Text.Trim() != "")
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = categoriaNegocio.Listar();
                cbxCategoria.SelectedValue = IdC.Text;
            }
            else
            {
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DataSource = categoriaNegocio.Listar();
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.txtPCompra.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtPVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtPVenta.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
