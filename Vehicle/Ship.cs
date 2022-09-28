using System.Xml;

namespace Vehicle;

public class Ship :Vehicle
{
    private string port;
    private int number;

    public Ship(double ax, double ay, decimal aprice, double aspeed, DateOnly ayear, string aport, int anumber)
        : base(ax, ay, aprice, aspeed, ayear)
    {
        port = aport;
        number = anumber;
    }

    public void Write()
    {
        Console.WriteLine($"ship: {x}, {y}, {price}, {speed}, {year}, {port}, {number}");
    }
}