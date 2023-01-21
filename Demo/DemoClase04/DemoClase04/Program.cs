using System.Data;
using System.Data.SqlClient;

string connectionString = "data source = DESKTOP-0RI6A0M\\MSSQLSERVER01; initial catalog = DbTest; user id = sa; password = 12345;";

string queryString = "select * from dbo.Producto where Tipo=@tipo  order by Id Desc;";

string paramValue = "Gaseosa";

using (SqlConnection connection = new (connectionString))
{
	SqlCommand command=new(queryString, connection);
	command.Parameters.AddWithValue("@tipo", paramValue);
    DataTable dt=new DataTable();
	try
	{
		connection.Open();
		SqlDataReader reader = command.ExecuteReader();
        while (!reader.IsClosed)
        {
            
            // DataTable.Load automatically advances the reader to the next result set
            dt.Load(reader);
      
        }
  //      while (reader.Read())
		//{
          
  //          Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
		//}
      
        reader.Close();
        var result=dt.AsEnumerable().Where(a=>a.Field<decimal>("Precio")==5).AsDataView();

	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}

    try
    {
        string nombre = "Chocotest";
        string tipo = "Galleta";
        int precio = 1;
        using SqlConnection con = new(connectionString);
        using SqlCommand cmd = new("INSERT INTO Producto values (@Nombre,@Tipo,@Precio)", con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@Nombre", nombre);
        cmd.Parameters.AddWithValue("@Tipo", tipo);
        cmd.Parameters.AddWithValue("@Precio", precio);
        con.Open();
        int rowsAffected = cmd.ExecuteNonQuery();
        con.Close();
    }
    catch (Exception)
    {

        throw;
    }


    try
    {
        string nombre = "Gloria";
        string tipo = "Leche";
        int precio = 2;
        int Id = 5;
        using SqlConnection con = new(connectionString);
        using SqlCommand cmd = new("Update Producto set  Nombre=@Nombre,Tipo=@Tipo,Precio=@Precio  where Id=@Id", con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@Nombre", nombre);
        cmd.Parameters.AddWithValue("@Tipo", tipo);
        cmd.Parameters.AddWithValue("@Precio", precio);
        cmd.Parameters.AddWithValue("@Id", Id);
        con.Open();
        int rowsAffected = cmd.ExecuteNonQuery();
        con.Close();
    }
    catch (Exception ex)
    {

        throw;
    }



    try
    {
      
        int Codigo = 7;
        using SqlConnection con = new(connectionString);
        using SqlCommand cmd = new("Delete from Producto where Id=@Id", con);
        cmd.CommandType = CommandType.Text;
        cmd.Parameters.AddWithValue("@Id", Codigo);
        con.Open();
        int rowsAffected = cmd.ExecuteNonQuery();
        con.Close();
    }
    catch (Exception ex)
    {

        throw;
    }

    Console.ReadLine();
}
