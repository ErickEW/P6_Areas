using System;
using NUnit.Framework;

namespace P6___Areas
{
    [TestFixture]
    class UnitTests
    {
        [Test]
        [TestCase(TestName = "calculate the area of ​​the triangles")]
        public void getTriangleArea()
        {
             // 9*4/2
             //= 18
            Triangle triangle = new Triangle(9,4);
            Assert.That(triangle.getArea(), Is.EqualTo(12));

            // 23*3/2
            //= 34.5 = 34
            Triangle triangle2 = new Triangle(23,3);
            Assert.That(triangle2.getArea(), Is.EqualTo(34));

            // if a number is less than 0
            // 4*-3
            //= 0
            Triangle triangulo3 = new Triangle(4,-3);
            Assert.That(triangulo3.getArea(), Is.EqualTo(0));


        }


        [Test]
        [TestCase(TestName = "Calculate the area of the squares")]
        public void getSquareArea()
        {
            //5*5 
            //= 25
            Square square = new Square(5);
            Assert.That(square.getArea(), Is.EqualTo(25));

             //33*33
            Square square3 = new Square(33);
            Assert.That(square3.getArea(), Is.EqualTo(1089));
            
            // if a number is less than 0
            //-3*-3
            //= 0
            Square square2 = new Square(-3);
            Assert.That(square2.getArea(), Is.EqualTo(0));
        }

        [Test]
        [TestCase(TestName = "Calculate the area of the rectangles")]
        public void getRectangleArea()
        {
            // 5*15
            //= 75
            Rectangle rectangle = new Rectangle(5,15);
            Assert.That(rectangle.getArea(), Is.EqualTo(75));

            //90*15
            //= 1350
            Rectangle rectangle2 = new Rectangle(90,15);
            Assert.That(rectangle2.getArea(), Is.EqualTo(1350));

            // if a number is less than 0
            Rectangle rectangle3 = new Rectangle(0,0);
            Assert.That(rectangle3.getArea(), Is.EqualTo(0));
        }

        [Test]
        [TestCase(TestName = "Calculate the area of the Pentagon")]
        public void getPentagonArea()
        {
            //Pentagon Area = Perimeter*Apothem/2

            // 15*7/2
            // =54.5 = 54
            Pentagon pentagon = new Pentagon(15,7);
            Assert.That(pentagon.getArea(), Is.EqualTo(54));

            // if a number is less than 0
            //-13*9/2
            // = 0
            Pentagon pentagon2 = new Pentagon(-13,9);
            Assert.That(pentagon2.getArea(), Is.EqualTo(0));

            //32*10/2
            //= 160
            Pentagon pentagon3 = new Pentagon(32,10);
            Assert.That(pentagon3.getArea(), Is.EqualTo(160));
        }

        [Test]
        [TestCase(TestName = "Calculate the area of the Circle")]
        public void getCircleArea()
        {
            //8*8*π
            //= 213.62 = 213
            Circle circle = new Circle(8);
            Assert.That(circle.getArea(), Is.EqualTo(213));

            //20*20*π
            //= 1256.63
            Circle circle2 = new Circle(20);
            Assert.That(circle2.getArea(), Is.EqualTo(1256));

             // if a number is less than 0
             //-3*-3*π
             //= 0
             Circle circle3 = new Circle(-3);
            Assert.That(circle3.getArea(), Is.EqualTo(0));
        }
    }
}