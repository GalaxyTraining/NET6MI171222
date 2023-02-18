using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ConexionManejador
    {
        public SqlConnection conexion = new("data source = DESKTOP-0RI6A0M\\MSSQLSERVER01; initial catalog = BDSistemaVenta; user id = sa; password = 12345");

        public void Conectar()
        {
            if(conexion.State== ConnectionState.Closed) 
                conexion.Open();
        }
        public void Desconectar() 
        { 
              if(conexion.State== ConnectionState.Open)
                conexion.Close();
        }
        public DataTable Listado(string NombreSP,List<Parametro> listParametros)
        {
            DataTable dt = new();
            SqlDataAdapter sqlDataAdapter;
            try
            {
                Conectar();
                sqlDataAdapter = new(NombreSP, conexion);
                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                if(listParametros!= null ) 
                { 
                    for(int i=0;i<listParametros.Count;i++) 
                    {
                        sqlDataAdapter.SelectCommand.Parameters.AddWithValue(listParametros[i].Nombre, listParametros[i].Valor);
                    }
                }
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }


        public void EjecutarSP(string NombreSP,ref List<Parametro> listParametros)
        {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(NombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if(listParametros!= null )
                {
                    for(int i=0;i<listParametros.Count;i++)
                    {
                        if (listParametros[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(listParametros[i].Nombre, listParametros[i].Valor);
                        if (listParametros[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(listParametros[i].Nombre, listParametros[i].TipoDato, listParametros[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for(int i=0;i<listParametros.Count;i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            listParametros[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            Desconectar();
        }
    }
}
