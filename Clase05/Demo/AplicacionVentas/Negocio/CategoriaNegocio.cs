using AccesoDatos;
using System.Data;

namespace Negocio
{
    public class CategoriaNegocio
    {
        ConexionManejador conexionManejador = new();

        private int m_IdC;
        private int m_IdCategoria;
        private string  m_Descripcion;

        public int IdC
        {
            get { return m_IdC; }
            set { m_IdC = value; }
        }
        public int IdCategoria
        {
            get { return m_IdCategoria; }
            set { m_IdCategoria = value; }
        }

        public string Descripcion
        {
            get { return m_Descripcion; }
            set { m_Descripcion = value; }
        }

        public DataTable Listar()
        {
            return conexionManejador.Listado("ListarCategoria", null);
        }

        public String RegistrarCategoria()
        {
            List<Parametro> lst = new List<Parametro>();
            string mensaje = "";
            try
            {
                lst.Add(new Parametro("@Descripcion", m_Descripcion));
                lst.Add(new Parametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                conexionManejador.EjecutarSP("RegistrarCategoria", ref lst);
                mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }

        public DataTable BuscarCategoria(String objDescripcin)
        {
            List<Parametro> lst = new List<Parametro>();
            DataTable dt = new DataTable();
            try
            {
                lst.Add(new Parametro("@Datos", objDescripcin));
                return dt = conexionManejador.Listado("BuscarCategoria", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ActualizarCategoria()
        {
            List<Parametro> lst = new List<Parametro>();
            string mensaje = "";
            try
            {
                lst.Add(new Parametro("@IdC", m_IdC));
                lst.Add(new Parametro("@Descripcion", m_Descripcion));
                lst.Add(new Parametro("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                conexionManejador.EjecutarSP("ActualizarCategoria", ref lst);
                mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mensaje;
        }
    }
}
