using Lombard_Project.UserClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingT
{
    [TestClass]
    public class UnitTestInitial
    {
        [TestMethod]
        public void TestMethod1()
        {
            Lombard lombard = new Lombard();
            lombard.FillTestData(10);
            Assert.AreEqual("Product0", lombard.Products[0].Name);
        }
    }
}