using SquareCalculator.Figures;
using Xunit;

namespace SquareCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void Triangle_Nonexistent_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1,2,3));
    }

    [Fact]
    public void Triangle_ZeroSideLength_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1,0,3));
    }
    
    [Fact]
    public void Triangle_CalculateSquare()
    {
        var triangle = new Triangle(3, 4, 6);
        
        Assert.Equal(triangle.Square, 5.332682251925386);
    }
    
    [Fact]
    public void Triangle_RightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        
        Assert.Equal(triangle.IsRight, true);
    }
    
    [Fact]
    public void Triangle_NotRightTriangle()
    {
        var triangle = new Triangle(4, 5, 6);
        
        Assert.Equal(triangle.IsRight, false);
    }
}