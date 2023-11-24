using System;
using System.Windows.Forms;

namespace Proyecto
{
    public class Program
    {
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Pumarutas formulario = new Pumarutas();
            Application.Run(new Pumarutas());
        }
    }
}
