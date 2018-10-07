using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using IoC.Core.Autofac;

namespace IoC.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<CoreModule>();
            containerBuilder.RegisterType<MainWindow>().AsSelf();
            var container = containerBuilder.Build();
            container.Resolve<MainWindow>().Show();
        }
    }
}
