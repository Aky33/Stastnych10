using DryIoc;
using S10.ServiceLayer.Interfaces;
using System;
using System.Windows.Forms;
using CompRoot = S10.CompositionRoot;

namespace S10
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var compRoot = new CompRoot.CompositionRoot();
            compRoot.Compose();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Main(compRoot.Container.Resolve<IVypocetService>(), compRoot.Container.Resolve<ITahService>()));
        }
    }
}
