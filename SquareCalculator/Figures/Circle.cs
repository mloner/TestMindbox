namespace SquareCalculator.Figures;

public class Circle : Figure
{
    public double Radius { get;}

    public Circle(double radius)
    {
        Radius = radius;
        
        Validate();
    }
    
    public override void Validate()
    {
        if (Radius <= 0)
        {
            throw new ArgumentException("Circle radius must be positive");
        }
    }
    
    protected override double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}