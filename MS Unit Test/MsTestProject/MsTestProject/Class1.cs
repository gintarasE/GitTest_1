using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MsTestProject
{
    [TestClass]
    public class Class1
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext tc)
        {
            Console.WriteLine("This is Before Assambly");
        }

        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Console.WriteLine("This is After Assambly");
        }
    }
}
