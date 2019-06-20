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
    public class TestTriangle
    {
        [Test]
        public void TestSide1Value()
        {
            // validate that value of side1 is set correctly
            int s1 = 5,s2 = 8,s3 = 4;
            TriangleSolver.Analyze(s1,s2,s3);
            int val = TriangleSolver.GetSide1();
            Assert.AreEqual(val, s1);
        }
        [Test]
        public void TestSide2Value()
        {
            // validate that value of side2 is set correctly
            int s1 = 5, s2 = 8, s3 = 4;
            TriangleSolver.Analyze(s1, s2, s3);
            int val = TriangleSolver.GetSide2();
            Assert.AreEqual(val, s2);
        }
        [Test]
        public void TestSide3Value()
        {
            // validate that value of side3 is set correctly
            int s1 = 5, s2 = 8, s3 = 4;
            TriangleSolver.Analyze(s1, s2, s3);
            int val = TriangleSolver.GetSide3();
            Assert.AreEqual(val, s3);
        }
        [Test]
        public void TestSide1ValueInvalid()
        {
            // validate that value of side1 is set correctly
            int s1 = 5, s2 = 8, s3 = 4;
            TriangleSolver.Analyze(s1, s2, s3);
            int val = TriangleSolver.GetSide1();
            Assert.AreNotEqual(val, s2);
        }
        [Test]
        public void TestSide2ValueInvalid()
        {
            // validate that value of side2 is set correctly
            int s1 = 5, s2 = 8, s3 = 4;
            TriangleSolver.Analyze(s1, s2, s3);
            int val = TriangleSolver.GetSide2();
            Assert.AreNotEqual(val, s3);
        }
        [Test]
        public void TestSide3ValueInvalid()
        {
            // validate that value of side3 is set correctly
            int s1 = 5, s2 = 8, s3 = 4;
            TriangleSolver.Analyze(s1, s2, s3);
            int val = TriangleSolver.GetSide3();
            Assert.AreNotEqual(val, s1);
        }
        [Test]
        public void TestIsTriangle()
        {
            // validate that it can form Triangle
            int sideA = 90, sideB = 45, sideC = 50;
            bool ans = TriangleSolver.IsTriangle(sideA,sideB,sideC);
            bool validate = (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) ? false : true;
            Assert.AreEqual(ans, validate);
        }
        [Test]
        public void TestIsNotTriangle()
        {
            // validate that it cannot form Triangle
            int sideA = 90, sideB = 40, sideC = 40;
            bool ans = TriangleSolver.IsTriangle(sideA, sideB, sideC);
            bool validate = (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) ? false : true;
            Assert.AreEqual(ans, validate);
        }
        [Test]
        public void TestIsEquilateral()
        {
            // validate that it is Equilateral Triangle
            int sideA = 45, sideB = 45, sideC = 45;
            string type = TriangleSolver.Analyze(sideA, sideB, sideC);
            string validate = (sideA == sideB && sideB == sideC) ? "Equilateral" : "Not Equilateral";
            Assert.AreEqual(type, validate);
        }
        [Test]
        public void TestIsIsosceles()
        {
            // validate that it is Isosceles Triangle
            int sideA = 45, sideB = 45, sideC = 50;
            string type = TriangleSolver.Analyze(sideA, sideB, sideC);
            string validate = (sideA == sideB || sideA == sideC || sideB == sideC) ? "Isosceles" : "Not Isosceles";
            Assert.AreEqual(type, validate);
        }
        [Test]
        public void TestIsScalene()
        {
            // validate that it is Scalene Triangle
            int sideA = 90, sideB = 45, sideC = 50;
            string type = TriangleSolver.Analyze(sideA, sideB, sideC);
            string validate = (sideA != sideB && sideB != sideC && sideC != sideA) ? "Scalene" : "Not Scalene";
            Assert.AreEqual(type, validate);
        }
    }
}
