namespace SquareCalculator;

public abstract class Figure : IValidatable
{
    private Lazy<double> _square { get; set; }
    public double Square
    {
        get => _square.Value;
    }

    public Figure()
    {
        _square = new Lazy<double>(GetSquare);
    }

    public abstract void Validate();
    protected abstract double GetSquare();
}