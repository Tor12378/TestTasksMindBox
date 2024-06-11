using ShapeLibrary;

namespace ShapeLibraryTests;

[TestFixture]
public class ShapeTests
{
    [Test]
    public void CircleAreaTest()
    {
        IShape circle = new Circle(5);
        Assert.AreEqual(78.5, circle.CalculateArea(), 0.5);
    }

    [Test]
    public void TriangleAreaTest()
    {
        IShape triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6, triangle.CalculateArea());
    }

    [Test]
    public void IsRightTriangleTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightTriangle());
    }
}