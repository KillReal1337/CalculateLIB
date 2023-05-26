using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapeLIB
{
    /// <summary>
    /// Methods for working with geometric shapes.
    /// </summary>
    public class GeometryShapeCalculator
    {
        private static double Area;

        /// <summary>
        /// Gets the area of circle.
        /// </summary>
        public static double GetArea(double radius)
        {
            Area = Math.PI * Math.Pow(radius, 2);
            return Area;
        }

        /// <summary>
        /// Gets the area of rectangle.
        /// </summary>
        /// <param name="a"> First side of the triangle. </param>
        /// <param name="b"> Second side of the triangle. </param>
        public static double GetArea(double a, double b)
        {
            Area = a * b;
            return Area;
        }

        /// <summary>
        /// Gets the area of triangle.
        /// </summary>
        /// <param name="a"> First side of the triangle. </param>
        /// <param name="b"> Second side of the triangle. </param>
        /// <param name="c"> Third side of the triangle. </param>
        public static double GetArea(double a, double b, double c)
        {
            double semiPerimeter = (a + b + c) / 2;
            Area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return Area;
        }

        /// <summary>
        /// Gets value indicating whether the triangle is right.
        /// </summary>
        /// <param name="a"> First side of the triangle. </param>
        /// <param name="b"> Second side of the triangle. </param>
        /// <param name="c"> Third side of the triangle. </param>
        public static bool IsRightTriangle(double a, double b, double c)
        {
            double[] sides = new double[] { a, b, c };
            Array.Sort(sides);
            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
