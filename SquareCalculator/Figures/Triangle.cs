namespace SquareCalculator.Figures;

public class Triangle : Figure
{
    public double SideALen { get;}
    public double SideBLen { get;}
    public double SideCLen { get;}
    
    private Lazy<bool> _isRight { get; set; }
    public bool IsRight
    {
        get => _isRight.Value;
    }

    public Triangle(double sideALen, double sideBLen, double sideCLen)
    {
        SideALen = sideALen;
        SideBLen = sideBLen;
        SideCLen = sideCLen;
        _isRight = new Lazy<bool>(IsRightTriangle);
        
        Validate();
    }
    
    public override void Validate()
    {
        
        if (SideALen > 0 && SideBLen > 0 && SideCLen > 0)
        {
            if (SideALen + SideBLen <= SideCLen || SideALen + SideCLen <= SideBLen || SideBLen + SideCLen <= SideALen)
                throw new ArgumentException("Triabgle can not exist. Wrong side lengths.");
        }
        else {
            throw new ArgumentException("Triangle sides must be positive.");
        }
    }

    protected override double GetSquare()
    {
        //Heron formula
        var halfPer = (SideALen + SideBLen + SideCLen) / 2;
        return Math.Sqrt(halfPer *
                         (halfPer - SideALen) *
                         (halfPer - SideBLen) *
                         (halfPer - SideCLen));
    }

    private bool IsRightTriangle()
    {
        return Math.Abs(
                   //Pythagorean theorem
                   (Math.Pow(SideALen, 2) + Math.Pow(SideBLen, 2)) -
                   Math.Pow(SideCLen, 2))
               < Constants.ErrorSize;
    }
}