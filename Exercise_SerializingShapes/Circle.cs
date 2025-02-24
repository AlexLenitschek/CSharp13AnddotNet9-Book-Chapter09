namespace Packt.Shared;

public class Circle : Shape
{
    public override double Area => Math.PI * Radius * Radius;
    public double Radius { get; set; }
}