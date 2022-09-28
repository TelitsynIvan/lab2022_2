using Vehicle;



class Program
{
    static void Main()
    {
        DateOnly test = new(2003, 10, 26);
        Plane one = new(12, 12, 234.5m, 456, test, 10_000, 255 );
        Ship two = new(12, 12, 234.5m, 456, test, "Murmansk", 1234);
        Car three = new(12, 12, 234.5m, 456, test);
        one.Write();
        two.Write();
        three.Write();
    }
}