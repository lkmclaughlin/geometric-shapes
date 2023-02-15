
using geometric_shapes;


//Geometric Operations

Square s1 = new Square(5);

Console.WriteLine($"Perimeter is {s1.Perimeter()} and Area is {s1.Area()}");


/*Square s1 = new Square
{
    Side = 5
};
Console.WriteLine($"Perimeter is {s1.Perimeter()} and Area is {s1.Area()}");
*/

Rect r1 = new Rect(3, 5);

Console.WriteLine($"Perimeter is {r1.Perimeter()} and Area is {r1.Area()}");

/*
Rect r1 = new Rect
{
    Side1 = 3,
    Side2 = 5,
};
Console.WriteLine($"Perimeter is {r1.Perimeter()} and Area is {r1.Area()}");
*/

Quad q1 = new Quad(3, 4, 5, 6);

Console.WriteLine($"Perimeter is {q1.Perimeter()}");


/*Quad q1 = new Quad
{
    Side1 = 3,
    Side2 = 4,
    Side3 = 5,
    Side4 = 6
};
Console.WriteLine($"Perimeter is {q1.Perimeter()}");
*/



//General Math Operations
/*  
public class Program
{
    public static void Main()
    {

        Console.WriteLine($"2 plus 3 equals {MathLib.Add(2, 3)}");
        Console.WriteLine($"2 minus 3 equals {MathLib.Subtract(2, 3)}");
        Console.WriteLine($"2 times 3 equals {MathLib.Multiply(2, 3)}");
        Console.WriteLine($"2 divided by 3 equals {MathLib.Divide(2, 0)}");
*/


/* var fullname = Person.Fullname("Lynn", "McLaughlin");

Console.WriteLine(fullname); 


Console.ReadLine();
    }
}

*/