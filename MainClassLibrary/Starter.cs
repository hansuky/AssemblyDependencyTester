using CommonModule;
using System;
using System.Reflection;

namespace MainClassLibrary
{
    public class Starter: FxApp
    {
        public override void Initialize()
        {
            Console.WriteLine("Initialize");
            //Assembly.GetAssembly(null);
            
            Assembly.Load("ModuleClassLibray");
        }
    }
}
