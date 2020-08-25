using System;
using Dog_Race_Rajpal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject_rajpal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RajpalRunningClass rjp = new RajpalRunningClass();
            if (rjp.moving() > 10)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
