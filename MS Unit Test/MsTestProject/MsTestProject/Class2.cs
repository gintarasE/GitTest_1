using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MsTestProject
{
    [TestClass]
    public class Class2
    {
        [TestMethod, TestCategory("SmokeTest")]
        public void TestCaseone()
        {
            Console.WriteLine("This is Class 2 Test Method");
        }
    }
}
