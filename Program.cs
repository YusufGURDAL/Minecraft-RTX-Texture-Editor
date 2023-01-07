using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;

namespace RTX_Texture_Editor_for_Minecraft
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var input = Console.ReadLine();
            var py = Python.CreateEngine();
            try
            {
                py.Execute("print(" + input + ")");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
