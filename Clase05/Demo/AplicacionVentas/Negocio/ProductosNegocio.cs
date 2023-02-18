using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductosNegocio
    {
        private ConexionManejador conexionManejador = new();
        private int m_IdP;
        private int m_IdCategoria;
        private string m_Producto;
        private string m_Marca;
        private int m_Stock;
        private decimal m_PrecioCompra;
        private decimal m_PrecioVenta;
        private DateTime m_FechaVencimiento;

        public int IdP
        {
            get { return m_IdP; }
            set { m_IdP = value; }
        }

        public int IdCategoria
        {
            get { return m_IdCategoria; }
            set { m_IdCategoria = value; }
        }
        public string Producto
        {
            get { return m_Producto; }
            set { m_Producto = value; }
        }
        public string Marca
        {
            get { return m_Marca; }
            set { m_Marca = value; }
        }
        public int Stock
        {
            get { return m_Stock; }
           set{ m_Stock = value;}
        }
        public decimal PrecioCompra
        {
            get { return m_PrecioCompra; }
            set
            {
                m_PrecioCompra = value;
            }
        }
        public decimal PrecioVenta
        {
            get { return m_PrecioVenta; }
            set
            {
                m_PrecioVenta = value;
            }
        }
        public DateTime FechaVencimiento
        {
            get { return m_FechaVencimiento; }
            set
            {
                m_FechaVencimiento = value;
            }
        }
        public DataTable Listar()
        {
            return conexionManejador.Listado("ListadoProductos", null);
        }
        public DataTable BusquedaProductos(string objDatos) 
        {
            DataTable dt = new();
            List<Parametro> parametros = new();
            try
            {
                parametros.Add(new Parametro("@Datos", objDatos));
                dt = conexionManejador.Listado("FiltrarDatosProducto", parametros);
            }
            catch (Exception ex)
            {

                throw;
            }
            return dt;
        }
        public string RegistrarProductos()
        {
            List<Parametro> parametros = new();
            try
            {
                parametros.Add(new Parametro("@IdCategoria", m_IdCategoria));
                parametros.Add(new Parametro("@Nombre", m_Producto));
                parametros.Add(new Parametro("@Marca", m_Marca));
                parametros.Add(new Parametro("@Stock", m_Stock));
                parametros.Add(new Parametro("@PrecioCompra", m_PrecioCompra));
                parametros.Add(new Parametro("@PrecioVenta", m_PrecioVenta));
                parametros.Add(new Parametro("@FechaVencimiento", m_FechaVencimiento));
                parametros.Add(new Parametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                conexionManejador.EjecutarSP("RegistrarProducto",ref parametros);
                return parametros[7].Valor.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public string ActualizarProductos()
        {
            List<Parametro> parametros = new();
            try
            {
                parametros.Add(new Parametro("@IdProducto", m_IdP));
                parametros.Add(new Parametro("@IdCategoria", m_IdCategoria));
                parametros.Add(new Parametro("@Nombre", m_Producto));
                parametros.Add(new Parametro("@Marca", m_Marca));
                parametros.Add(new Parametro("@Stock", m_Stock));
                parametros.Add(new Parametro("@PrecioCompra", m_PrecioCompra));
                parametros.Add(new Parametro("@PrecioVenta", m_PrecioVenta));
                parametros.Add(new Parametro("@FechaVencimiento", m_FechaVencimiento));
                parametros.Add(new Parametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                conexionManejador.EjecutarSP("ActualizarProducto", ref parametros);
                return parametros[8].Valor.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
