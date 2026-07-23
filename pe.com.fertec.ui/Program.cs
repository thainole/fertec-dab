using pe.com.fertec.ui.empleado;

namespace pe.com.fertec.ui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmempleado());
        }
    }
}
