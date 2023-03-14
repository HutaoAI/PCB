using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YBR_Program.View;

namespace YBR_Program
{
    public static class DI
    {
        public static IContainer Container { get; set; }

        public static void GetContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EventHand>().SingleInstance();
            builder.RegisterType<Form1>().SingleInstance();
            builder.RegisterType<HomeView>().SingleInstance();
            builder.RegisterType<DebugView>().SingleInstance();
            builder.RegisterType<LoginView>().SingleInstance();
            builder.RegisterType<LoadView>().SingleInstance();


            Container = builder.Build();
        }
    }
}
