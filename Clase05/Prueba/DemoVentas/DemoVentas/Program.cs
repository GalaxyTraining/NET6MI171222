namespace DemoVentas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.      
        /// </summary>
        public static int Evento;

        //Datos del Cliente
        public static int IdCliente;
        public static String DocumentoIdentidad;
        public static String NombreCliente;
        public static String ApellidosCliente;

        //Datos del Producto
        public static int IdProducto;
        public static String Descripcion;
        public static String Marca;
        public static Int32 Stock;
        public static Decimal PrecioVenta;

        //Datos del Empleado
        public static int IdCargo;
        public static String EstadoCivil = "";
        public static int IdEmpleado;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //Variables de Sesion
        public static int IdEmpleadoLogueado;
        public static String NombreEmpleadoLogueado;
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