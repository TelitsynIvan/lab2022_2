namespace Vehicle;

public class Plane :Vehicle
{
    private float alt;
    private int number;

    public Plane(double ax, double ay, decimal aprice, double aspeed, DateOnly ayear, float aalt, int anumber)
        : base(ax, ay, aprice, aspeed, ayear)
    {
        alt = aalt;
        number = anumber;
    }
    public void Write()
    {
        Console.WriteLine($"ship: {x}, {y}, {price}, {speed}, {year}, {alt}, {number}");
    }
}