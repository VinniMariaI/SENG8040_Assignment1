using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SENG8040_Assignment1;

namespace RectangleTest
{
    [TestFixture]
    public class UnitTest1
    {
        Rectangle rec = new Rectangle();

        [Test]
        [TestCase(2,2)]
        [TestCase(3,3)]
       
        public void GetLengthTestMethod(int length, int expectedlength)
        {
            Rectangle rec = new Rectangle();
            int RectangleLength = rec.GetLength();
            NUnit.Framework.Assert.AreEqual(RectangleLength, 1);

        }
       [Test]
        [TestCase(4,4)]
        [TestCase(5,5)]
        public void GetWidthTestMethod(int width, int expectedWidth)
        {
           Rectangle rec = new Rectangle();
            int RectangleWidth = rec.GetWidth();
            NUnit.Framework.Assert.AreEqual(RectangleWidth, 1);

        }

        [Test]
        [TestCase(10)]
        [TestCase(20)]

        public void setLengthTestMethod(int length)
        {
            rec.setLength(length);
            NUnit.Framework.Assert.AreEqual(length, rec.GetLength());
        }

        [Test]
        [TestCase(20)]
        [TestCase(15)]

        public void setWidthTestMethod(int width)
        {
            rec.setWidth(width);
            NUnit.Framework.Assert.AreEqual(width, rec.GetWidth());
        }

        [Test]
        [TestCase(2,3,10)]
        [TestCase(3, 3, 12)]
        public void GetperimeterTestMethod(int length, int width, int expectedPerimeter)
        {
            rec.setLength(length);
            rec.setWidth(width);
            int Perimeter = rec.GetPerimeter();
            NUnit.Framework.Assert.AreEqual(Perimeter, expectedPerimeter);
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(5, 5, 25)]
        public void GetAreaTestMethod(int length, int width, int expectedArea)
        {
            rec.setLength(length);
            rec.setWidth(width);
            int Perimeter = rec.GetArea();
            NUnit.Framework.Assert.AreEqual(Perimeter, expectedArea);
        }


    }
}
