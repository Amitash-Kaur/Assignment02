//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
//using System;
//using Assignment02;

namespace UnitTest
{
    [TestFixture]
    public class UnitTests
    {
        [Test] //Side1=side2=side3 for equilateral triangle
        public void Equilateral_Triangle()
        {
            //TriangleSolver ObjectUnderTest = new TriangleSolver();

            string result = TriangleSolver.Analyze(3,3,3);

            Assert.AreEqual("Equilateral Triangle", result);
        }

        [Test] //2 equal sides for isoscless triangle
        public void Isoscless_Triangle()
        {
            //TriangleSolver ObjectUnderTest = new TriangleSolver();

            string result = TriangleSolver.Analyze(3, 3, 4 );

            Assert.AreEqual("Isoscless Triangle", result);
        }

        [Test] // all different sides for scalene triangle
        public void Scalene_Triangle()
        {
            //TriangleSolver ObjectUnderTest = new TriangleSolver();

            string result = TriangleSolver.Analyze(3, 4, 2);

            Assert.AreEqual("Scalene Triangle", result);
        }

        [Test] // negative value which should not make a triangle
        public void No_Triangle1()
        {
            //TriangleSolver ObjectUnderTest = new TriangleSolver();

            string result = TriangleSolver.Analyze(3, 3, -3);

            Assert.AreEqual("Given inputs are not valid to form a triangle", result);
        }

        [Test] // side with length zero should not make a triangle
        public void No_Triangle2()
        {
            //TriangleSolver ObjectUnderTest = new TriangleSolver();

            string result = TriangleSolver.Analyze(3, 0, 3);

            Assert.AreEqual("Given inputs are not valid to form a triangle", result);
        }

        [Test] // side with a string value should not make a triangle
        public void No_Triangle3()
        {
            //TriangleSolver ObjectUnderTest = new TriangleSolver();

            string result = TriangleSolver.Analyze("&", 3, 3);

            Assert.AreEqual("Given inputs are not valid to form a triangle", result);
        }

        [Test] // side(s) length is not appropriate to make a triangle
        public void No_Triangle4()
        {
            //TriangleSolver ObjectUnderTest = new TriangleSolver();

            string result = TriangleSolver.Analyze(5, 5, 10);

            Assert.AreEqual("Given inputs are not valid to form a triangle", result);
        }

        [Test] // sides with zero length should not make a triangle
        public void No_Triangle5()
        {
            //TriangleSolver ObjectUnderTest = new TriangleSolver();

            string result = TriangleSolver.Analyze(0, 0, 0);

            Assert.AreEqual("Given inputs are not valid to form a triangle", result);
        }
    }
}
