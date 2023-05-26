using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GeometryShapeLIB;

namespace LibraryTest
{
    [TestClass]
    public class UnitTestLibrary
    {
        [TestMethod]
        public void CheckAreaCalculate()
        {
            var a = 3.00;
            var b = 4.00;
            var c = 5.00;
            Assert.AreEqual(28.26, GeometryShapeCalculator.GetArea(a), 0.05, "Area of the circle is not correctly");
            Assert.AreEqual(12.00, GeometryShapeCalculator.GetArea(a, b), "Area of the rectangle is not correctly");
            Assert.AreEqual(6.00, GeometryShapeCalculator.GetArea(a, b, c), "Area of the triangle is not correctly");
        }

        [TestMethod]
        public void CheckRightTriangle()
        {
            var a = 3.00;
            var b = 4.00;
            var c = 5.00;

            Assert.AreEqual(true, GeometryShapeCalculator.IsRightTriangle(a, b, c), "The method of checking a right triangle is not correctly");
        }
    }
}
