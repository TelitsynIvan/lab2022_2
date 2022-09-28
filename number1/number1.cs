namespace number1;
using ClassRoom;
using Pupil;

class Program
{
    static void Main()
    {
        ExcelentPupil one = new();
        ExcelentPupil two = new();
        BadPupil three = new();
        GoodPupil four = new();
        ClassRoom test = new ClassRoom(one, two, three, four);
        foreach (var pup in test.arr)
        {
            pup.Read();
            pup.Write();
            pup.Study();
            pup.Relax();
        }
    }
}