using AppCore.IServices;
using AppCore.Services;
using Autofac;
using ConversorDeTemperaturas.Forms;
using Domain.Interfaces;
using Repository.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeTemperaturas
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ResumenRepository>().As<IResumen>();
            builder.RegisterType<Temperatures>().As<ITemperature>();

            builder.RegisterType<ServicesResumen>().As<IResumenServices>();
            builder.RegisterType<ServicesTemperature>().As<ITemperatureColeccion>();

            var container = builder.Build(); 
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPresentation(container.Resolve<ITemperatureColeccion>(), container.Resolve<IResumenServices>()));
        }
    }
}
