using System;
using System.Windows.Forms;
using DTM.Forms;
using DTM.RunConfig;

namespace DTM
{
    public static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            InjectionModule.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(InjectionModule.Container.GetInstance<DtmMainWindow>());
        }
    }
}
