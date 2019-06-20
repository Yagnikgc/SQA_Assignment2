using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQA_Assignment2;

namespace TestTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetSide1()
        {
            int i = 4;
            TriangleSolver.SetSide1(i);
            int val = TriangleSolver.GetSide1();
            Assert.AreEqual(val, i);
        }
    }
}
