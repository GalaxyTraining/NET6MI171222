using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPersonas
{
    public class Conexion
    {
        private SqlConnection conexionBD;
        private SqlCommand orden;
        private SqlDataReader lector;
        private string strConexion;
        private string consulta;
        private string nombre;
        private string[] datos = new string[2];
        private string[,] datos2 = new string[11, 11];
        public Conexion()
        {
            strConexion = "data source = DESKTOP-0RI6A0M\\MSSQLSERVER01; initial catalog = DbTest; user id = sa; password = 12345;";
            conexionBD = new(strConexion);
        }
        public string[] getNombre(int id)
        {
            conexionBD.Open();
            consulta = "Select * from Persona where Id=" + id + ";";
            orden = new SqlCommand(consulta, conexionBD);
            lector = orden.ExecuteReader();
            while(lector.Read())
            {
                datos[0] = (string)lector["Nombre"];
                datos[1] = (string)lector["Direccion"];
            }
            lector.Close();
            conexionBD.Close();
            return datos;
        }
        public string getBorrar(int id)
        {
            conexionBD.Open();
            consulta = "delete  from Persona where Id=" + id + ";";
            orden = new SqlCommand(consulta, conexionBD);
            lector = orden.ExecuteReader();
            while (lector.Read())
            {
                nombre= (string)lector["Nombre"];
            }
            lector.Close();
            conexionBD.Close();
            return nombre;
        }
        public string getAgregar(string nombre,string direccion)
        {
            conexionBD.Open();
            consulta = "insert into  Persona  values ('"+nombre+"'"+","+"'"+direccion+"')"+";";
            orden = new SqlCommand(consulta, conexionBD);
            int rowsAffected = orden.ExecuteNonQuery();
            conexionBD.Close();
            return nombre;
        }
        public string getModificar(int id,string nombre, string direccion)
        {
            conexionBD.Open();
            consulta = "update  Persona  set  Nombre="+"'"+ nombre + "'" + "," + "Direccion='" + direccion + "'" + "where id="+id+";";
            orden = new SqlCommand(consulta, conexionBD);
            int rowsAffected = orden.ExecuteNonQuery();
            conexionBD.Close();
            return nombre;
        }
        public string[,] getTabla()
        {
            int j = 0;
            conexionBD.Open();
            consulta = "select * from  Persona";
            orden = new SqlCommand(consulta, conexionBD);
            lector = orden.ExecuteReader();
            while(lector.Read())
            {
                datos2[j, 1] = Convert.ToString((int)lector["Id"]);
                datos2[j, 2] = (string)(lector["Nombre"]);
                datos2[j, 3] = (string)(lector["Direccion"]);
                j++;
            }
            lector.Close();
            conexionBD.Close();
            return datos2;
        }
    }
}
