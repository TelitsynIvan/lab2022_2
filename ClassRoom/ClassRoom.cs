
namespace ClassRoom;
using System.Collections.Generic;
using Pupil;

public class ClassRoom
{
    public List<Pupil> arr { get; set; } = new List<Pupil>();

    public ClassRoom(Pupil a, Pupil b)
    {
        arr.Add(a);
        arr.Add(b);
    }
    public ClassRoom(Pupil a, Pupil b, Pupil c) :this(a, b)
    {
        arr.Add(c);
    }
    public ClassRoom(Pupil a, Pupil b, Pupil c, Pupil d) :this(a, b, c)
    {
        arr.Add(d);
    }
}