using AccesoDatos;
using System.Data;

namespace Negocio
{
    public class UsuarioNegocio
    {
        ConexionManejador conexionManejador = new();
        public int IdEmpleado { get; set; }
        public string User { get; set; }

        public string Password { get; set; }

        public string RegistrarUsuarios()
        {
            List<Parametro> parametros= new();
            try
            {
                parametros.Add(new Parametro("@IdEmpleado", IdEmpleado));
                parametros.Add(new Parametro("@Usuario", User));
                parametros.Add(new Parametro("@Contraseña", Password));
                parametros.Add(new Parametro("@Mensaje", "", System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Output, 50));
                conexionManejador.EjecutarSP("RegistrarUsuario", ref parametros);
                return parametros[3].Valor.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public string IniciarSesion()
        {
            List<Parametro> parametros= new();
            try
            {
                parametros.Add(new Parametro("@Usuario", User));
                parametros.Add(new Parametro("@Contraseña", Password));
                parametros.Add(new Parametro("@Mensaje", "", System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Output, 50));
                conexionManejador.EjecutarSP("IniciarSesion", ref parametros);
                return parametros[2].Valor.ToString();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public DataTable DevolverDatosSesion(string objUser,string objPassword)
        {
            List<Parametro> parametros= new();
            try
            {
                parametros.Add(new Parametro("@Usuario", objUser));
                parametros.Add(new Parametro("@Contraseña", objPassword));
                return conexionManejador.Listado("DevolverDatosSesion", parametros);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}