using System;
using System.Windows.Forms;
using AmicsDeLaMusicaClassLibrary.Src.Container;

namespace AmicsDeLaMusica
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(AppContainer.GetInstance().GetInstance<Main>());
        }
    }
}
