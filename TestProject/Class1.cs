using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SQA_Assignment2;

namespace TestProject
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestGetSide1()
        {
            int i = 4;
            TriangleSolver.SetSide1(i);
            int val = TriangleSolver.GetSide1();
            Assert.AreEqual(val, i);
        }
    }
}
