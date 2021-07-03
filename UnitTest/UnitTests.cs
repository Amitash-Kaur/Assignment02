//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
//using System;
//using Assignment02;

namespace UnitTest
{
    [TestFixture]
    //[TestClass]
    public class UnitTests
    {
        [Test]
        //[TestMethod]
        public void GetLength_DefaultConstructorObjectCreated_ReturnsOne()
        {
            TriangleSolver ObjectUnderTest = new TriangleSolver();

            int actualLength = ObjectUnderTest.GetLength();

            Assert.AreEqual(1, actualLength);
        }




    }
}
