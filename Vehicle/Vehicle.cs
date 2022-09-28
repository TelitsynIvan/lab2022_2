namespace Vehicle;

public class Vehicle
{
    protected double x;
    protected double y;
    protected decimal price;
    protected double speed;
    protected DateOnly year;

    public Vehicle(double ax, double ay, decimal aprice, double aspeed, DateOnly ayear)
    {
        x = ax;
        y = ay;
        price = aprice;
        speed = aspeed;
        year = ayear;
    }
}