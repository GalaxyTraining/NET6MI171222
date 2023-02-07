using Negocio;
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
    public partial class FrmListadoProductos : Form
    {
        int Listado = 0;
        private ProductosNegocio productosNegocio = new();
        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar== 13)
            {
                BusquedaProductos();
                timer1.Stop();
            }
            else
            {
                CargarListado();
                timer1.Start();
            }
        }
        private void BusquedaProductos()
        {
            DataTable dt = new();
            try
            {
                productosNegocio.Marca = txtBuscarProducto.Text;
                dt = productosNegocio.BusquedaProductos(productosNegocio.Marca);
                dataGridView1.Rows.Clear();
                for(int i=0;i<dt.Rows.Count;i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = Convert.ToDateTime(dt.Rows[i][7].ToString()).ToShortDateString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }

        private void CargarListado()
        {
            DataTable dt = new();
            dt = productosNegocio.Listar();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[4].Value = dt.Rows[i][4].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][5].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dt.Rows[i][6].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = Convert.ToDateTime(dt.Rows[i][7].ToString()).ToShortDateString();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Program.IdProducto = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.Descripcion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.Marca = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Program.PrecioVenta = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            Program.Stock = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            this.Close();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                    dataGridView1.ClearSelection();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está Seguro que Desea Salir.?", "Sistema de Ventas.", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 5000;
            CargarListado();
            dataGridView1.ClearSelection();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroProductos frmRegistroProductos = new();
            if (dataGridView1.SelectedRows.Count > 0)
                Program.Evento = 1;
            else
                Program.Evento = 0;
            dataGridView1.ClearSelection();
            frmRegistroProductos.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FrmRegistroProductos P = new FrmRegistroProductos();
                P.txtIdP.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                P.IdC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                P.txtProducto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                P.txtMarca.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                P.txtPCompra.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                P.txtPVenta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                P.txtStock.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                P.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
                P.Show();
                if (dataGridView1.SelectedRows.Count > 0)
                    Program.Evento = 1;
                else
                    Program.Evento = 0;
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar la Fila a Editar.", "Sistema de Ventas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
