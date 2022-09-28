namespace Vehicle;

public class Car :Vehicle
{
    public Car(double ax, double ay, decimal aprice, double aspeed, DateOnly ayear)
    :base(ax, ay, aprice, aspeed, ayear)
    {
    }
    public void Write()
    {
        Console.WriteLine($"ship: {x}, {y}, {price}, {speed}, {year}");
    }
}