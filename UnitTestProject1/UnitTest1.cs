using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckVIN()
        {
            Class1 class1 = new Class1();
            Assert.IsTrue(class1.CheckVIN("JHMCM56557C404453"));
        }

        [TestMethod]
        public void TestGetVINCountry()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("Азия", class1.GetVINCountry("JHMCM56557C404453"));
        }
    }
}
