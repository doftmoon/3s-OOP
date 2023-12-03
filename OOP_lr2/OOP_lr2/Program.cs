using System.Numerics;

internal class Program
{

    static void Main(string[] args)
    {
        Person person1 = new Person();
        Person person2 = new Person("John", 25);
        Person person3 = new Person("Jane", 30);

        person1.Name = "Mike";
        person1.Age = 35; int[] arr = new int[2] { 2, 8 };

        Console.WriteLine(person1.ToString());
        Console.WriteLine(person2.ToString());
        Console.WriteLine(person3.ToString());

        string newName = "Alice";
        int newAge;
        person3.ModifyPerson(ref newName, out newAge);
        Console.WriteLine($"Modified Name: {newName}, Modified Age: {newAge}");

        Console.WriteLine($"person1 == person2: {person1.Equals(person2)}");
        Console.WriteLine($"person2 == person3: {person2.Equals(person3)}");

        Console.WriteLine($"person1 is Person: {person1 is Person}");
        Console.WriteLine($"person2 is Person: {person2 is Person}");
        Console.WriteLine($"person3 is Person: {person3 is Person}");

        Person.ClassInfo();

        Person personWithID = Person.CreatePersonWithID(123);
        Console.WriteLine(personWithID.ToString());

        //---------------------------2

        Person[] people = new Person[3];

        people[0] = new Person("John", 25);
        people[1] = new Person("Jane", 30);
        people[2] = new Person("Mike", 35);

        foreach (Person person in people)
        {
            Console.WriteLine(person.ToString());
        }
        //---------------------------3

        Vector vector1 = new Vector(3);
        vector1[0] = 1;
        vector1[1] = 2;
        vector1[2] = 3;

        Vector vector2 = new Vector(3);
        vector2[0] = 4;
        vector2[1] = 5;
        vector2[2] = 6;

        Vector sum = vector1.Add(vector2);
        if (sum != null)
        {
            Console.WriteLine("Sum vectors: {0}, {1}, {2}", sum[0], sum[1], sum[2]);
        }
        else
        {
            Console.WriteLine("Error when sum: {0}", vector1.ErrorCode);
        }

        Vector product = vector2.Multiply(2);
        Console.WriteLine("Scal multip: {0}, {1}, {2}", product[0], product[1], product[2]);
    }
}


public class Vector
{
    private int[] elements;
    private int size;
    private int errorCode;

    public Vector(int size)
    {
        elements = new int[size];
        this.size = size;
        errorCode = 0;
    }

    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < size)
            {
                return elements[index];
            }
            else
            {
                errorCode = 1; // Установка кода ошибки при недопустимом индексе
                return 0;
            }
        }
        set
        {
            if (index >= 0 && index < size)
            {
                elements[index] = value;
            }
            else
            {
                errorCode = 1; // Установка кода ошибки при недопустимом индексе
            }
        }
    }

    public int ErrorCode
    {
        get { return errorCode; }
    }

    public Vector Add(Vector other)
    {
        if (size != other.size)
        {
            errorCode = 2; // Установка кода ошибки при попытке сложения векторов разной длины
            return null;
        }

        Vector result = new Vector(size);

        for (int i = 0; i < size; i++)
        {
            result[i] = elements[i] + other[i];
        }

        return result;
    }

    public Vector Multiply(int scalar)
    {
        Vector result = new Vector(size);

        for (int i = 0; i < size; i++)
        {
            result[i] = elements[i] * scalar;
        }

        return result;
    }
}



partial class Person
{
    private static int count;

    private readonly int ID;
    private const string Country = "USA";

    private string name;
    private int age;
}

partial class Person
{
    public Person()
    {
        ID = GetHashCode();
        count++;
        name = "Unknwon";
        age = 0;
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        ID = GetHashCode();
        count++;
    }

    public Person(string name = "Unknown", int age = 0, bool t = false)
    {
        this.name = name;
        this.age = age;
        ID = GetHashCode();
        count++;
    }

    static Person()
    {
        count = 0;
    }

    private Person(int id)
    {
        ID = id;
        count++;
        name = "Unknwon";
        age = 0;
    }

    public static Person CreatePersonWithID(int id)
    {
        return new Person(id);
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public int Count
    {
        get { return count; }
        private set { }
    }

    public void ModifyPerson(ref string newName, out int newAge)
    {
        newName += " Smith";
        newAge = age + 1;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Person otherPerson = (Person)obj;
        return ID == otherPerson.ID;
    }

    public override int GetHashCode()
    {
        return Guid.NewGuid().GetHashCode();
    }

    public override string ToString()
    {
        return $"Name: {name}, Age: {age}";
    }
    public static void ClassInfo()
    {
        Console.WriteLine($"Class: Person\nNumber of instances: {count}");
    }
}