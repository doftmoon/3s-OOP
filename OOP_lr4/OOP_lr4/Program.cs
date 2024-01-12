using System.Runtime.InteropServices;
using c = System.Console;

interface IFigure
{
    void Print();
}

class Rectangle : IFigure
{
    public int x;
    public int y;
    private int h;
    private int l;
    private string? color;

    public Rectangle() { }

    public Rectangle(int x, int y, int h)
    {
        this.x = x;
        this.y = y;
        this.h = h;
    }

    public Rectangle(int x, int y, int h, int l, string color)
    {
        this.x = x;
        this.y = y;
        this.h = h;
        this.l = l;
        this.color = color;
    }

    public void Print()
    {
        c.WriteLine($"Rectangle: x={x}, y={y}, h={h}, l={l}, color={color}");
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public static Rectangle operator +(Rectangle rectangle, int value)
    {
        rectangle.x += value;
        rectangle.y += value;
        return rectangle;
    }

    public int Calculate()
    {
        return h * l;
    }
}

class Program
{
    static void Main()
    {
        List<Rectangle> rectangles = new List<Rectangle>
        {
            new Rectangle(0, 0, 10, 20, "red"),
            new Rectangle(1, 1, 15, 25, "blue"),
            new Rectangle(2, 2, 12, 22, "green"),
            new Rectangle(3, 3, 18, 28, "yellow"),
            new Rectangle(4, 4, 8, 18, "orange"),
            new Rectangle(5, 5, 14, 24, "purple")
        };

        Console.WriteLine("Original List:");
        foreach (var rectangle in rectangles)
        {
            rectangle.Print();
        }

        Console.WriteLine();
        Console.WriteLine("List after adding 5 to width and height using operator +:");

        List<Rectangle> updatedRectangles = new List<Rectangle>();

        foreach (var rectangle in rectangles)
        {
            Rectangle updatedRectangle = rectangle + 5;
            updatedRectangles.Add(updatedRectangle);
            updatedRectangle.Print();
        }

        rectangles = updatedRectangles;

        var sortedRectangles = rectangles.OrderBy(r => r.x)
                                          .ThenBy(r => r.y)
                                          .ThenBy(r => r.Calculate())
                                          .ToList();

        // Вывод первого и последнего объектов
        if (sortedRectangles.Count > 0)
        {
            Console.WriteLine("First Object:");
            Console.WriteLine(sortedRectangles.First());

            Console.WriteLine();

            Console.WriteLine("Last Object:");
            Console.WriteLine(sortedRectangles.Last());
        }
        else
        {
            Console.WriteLine("List is empty");
        }

        foreach (var rectangle in sortedRectangles)
        {
            rectangle.Print();
        }
    }
}