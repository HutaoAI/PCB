using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YBR_Program.View;

namespace YBR_Program
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DI.GetContainer();

            using (var temp = DI.Container.BeginLifetimeScope())
            {
                var load = temp.Resolve<LoadView>();
                load.Init();
                Application.Run(load);
            }
        }
    }
}
