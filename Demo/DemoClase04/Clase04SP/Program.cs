
using System.Data;
using System.Data.SqlClient;

string connectionString = "data source = DESKTOP-0RI6A0M\\MSSQLSERVER01; initial catalog = DbTest; user id = sa; password = 12345;";
string SQL = "SP_INSERT_PRODUCTO";

try
{
    using SqlConnection con = new(connectionString);
    using SqlCommand cmd = new(SQL, con);
    cmd.CommandType = CommandType.StoredProcedure;

    SqlParameter param;
    param = cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 100);
    param.Value = "Todino";
    param = cmd.Parameters.Add("@Tipo", SqlDbType.VarChar, 100);
    param.Value = "Paneton";
    param = cmd.Parameters.Add("@Precio", SqlDbType.Decimal);
    param.Value = 25;
    con.Open();
    int rowsAffected = cmd.ExecuteNonQuery();
    con.Close();
}
catch (Exception ex)
{

	throw;
}
