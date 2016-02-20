using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestProject
{
    [TestClass]
    public class Class3
    {
        [TestMethod, TestCategory("SmokeTest")]
        public void Test()
        {
            Console.WriteLine("Test");
        }

    }
}
