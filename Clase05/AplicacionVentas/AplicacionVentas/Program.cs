namespace AplicacionVentas
{
    internal static class Program
    {


        public static int Evento;

        //Datos del cliente
        public static int IdCliente;
        public static string DocumentoIdentidad;
        public static string NombreCliente;
        public static string ApellidosCliente;

        //Datos del Producto
        public static int IdProducto;
        public static string Descripcion;
        public static string Marca;
        public static int  Stock;
        public static decimal PrecioVenta;

        //Datos del Empleado
        public static int IdCargo;
        public static string EstadoCivil = "";
        public static int IdEmpleado;


        //Variables de Sesion
        public static int IdEmpleadoLogueado;
        public static string NombreEmpleadoLogueado;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}