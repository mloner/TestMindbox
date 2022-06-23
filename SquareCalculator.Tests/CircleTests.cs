using SquareCalculator.Figures;
using Xunit;

namespace SquareCalculator.Tests;

public class CircleTests
{
    [Fact]
    public void Circle_ZeroRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
    
    [Fact]
    public void Circle_NegativeRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-6));
    }
    
    [Fact]
    public void Circle_CalculateSquare()
    {
        var radius = 5;
        var circle = new Circle(radius);
        
        Assert.Equal(circle.Square, Math.PI * Math.Pow(radius, 2));
    }
}