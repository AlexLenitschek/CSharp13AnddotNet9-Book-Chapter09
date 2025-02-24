namespace Packt.Shared;

public class Rectangle : Shape
{
    public override double Area => Height * Width;
    public double Height { get; set; }
    public double Width { get; set; }
}