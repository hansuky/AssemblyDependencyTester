using CommonModule;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyDependencyTester
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo mainLib = new FileInfo(@"..\..\..\Build\Debug\MainClassLibrary.dll");
            var mainAsm = Assembly.LoadFile(mainLib.FullName);
            Console.WriteLine(mainAsm);
            var appType = mainAsm.GetExportedTypes().First(type => type.BaseType.Equals(typeof(FxApp)));
            var app = Activator.CreateInstance(appType) as FxApp;
            foreach(var asm in appType.Assembly.GetReferencedAssemblies())
            {
                var loadedAsm = Assembly.Load(asm.FullName);
            }
            app.Initialize();
        }
    }
}
