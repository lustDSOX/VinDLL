using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckVINT()
        {
            Class1 class1 = new Class1();
            Assert.IsTrue(class1.CheckVIN("JHMCM56557C404453"));
        }

        [TestMethod]
        public void TestGetVINCountryT()
        {
            Class1 class1 = new Class1();
            Assert.AreEqual("Азия", class1.GetVINCountry("JHMCM56557C404453"));
        }

        [TestMethod]
        public void TestCheckVINF()
        {
            Class1 class1 = new Class1();
            Assert.IsFalse(class1.CheckVIN("OHMCM56557C404453"));
        }

        [TestMethod]
        public void TestGetVINCountryF()
        {
            Class1 class1 = new Class1();
            Assert.AreNotEqual("Европа", class1.GetVINCountry("JHMCM56557C404453"));
        }
    }
}
