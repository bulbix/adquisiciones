using System;
using System.Collections.Generic;
using System.Linq;
using Spring.Windows;

namespace Adquisiciones.View
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();
            const string startup = "assembly://Adquisiciones.View/Adquisiciones.View.Config/Startup.xml";
            const string dao = "assembly://Adquisiciones.Data/Adquisiciones.Data.Dao/Dao.xml";
            const string service = "assembly://Adquisiciones.Business/Adquisiciones.Business/Services.xml";
            const string view = "assembly://Adquisiciones.View/Adquisiciones.View.Config/View.xml";

            Application.Initialize(startup, dao, service, view);
            Application.Run(new FrmModuloAcceso());

        }
    }
}