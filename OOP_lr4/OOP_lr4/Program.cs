using System.Security.Cryptography.X509Certificates;
using c = System.Console;

class Student
{
    public static int id;
    public string SecondName;
    public string FirstName;
    public string LastName;
    public string date;
    public string address;
    public string pulpit;
    public short course;
    public string univ;

    static Student() { }

    public Student(string secondName, string firstName, string lastName, string date, string address, string pulpit, short course, string univ)
    {
        SecondName = secondName;
        FirstName = firstName;
        LastName = lastName;
        this.date = date;
        this.address = address;
        this.pulpit = pulpit;
        this.course = course;
        this.univ = univ;
    }

    public int GetAge(int id)
    {
      //  return 
    }

    public override void ToString()
    {
        
      //  return c.WriteLine("To string in Student");
    }
}

//2
abstract class Pleant
{
    public string pName;
    public string pType;

    public Pleant(string pName, string pType)
    {
        this.pName = pName;
        this.pType = pType;
    }

    protected Pleant(string pName)
    {
        this.pName = pName;
    }

    public abstract void GetMsg(string msg);
}

class Tree : Pleant
{
    public string tName;
    public string tType;
    public int tAge;

    //public Tree(int tAge)
    //{

    //    this.tAge = tAge;
    //}

    public override void GetMsg(string msg)
    {
        c.Write((string)msg);
    }
}

internal class Flower : Pleant
{
    public int fLength;

    public Flower(string pName, string pType) : base(pName, pType)
    {
    }

    public override void GetMsg(string msg)
    {
        c.Write((string)msg);
    }

    public static Flower operator +(Flower fLength, int length)
    {
        return fLength + length;
    }
}

class Rose : Flower
{
    public string fColor;

    public Rose(string pName, string pType) : base(pName, pType)
    {
    }
}



//3
class NewsChannel
{
    

    public void News()
    {
        c.Write("News");
    }
}

class Sub
{
    public void ReadNews()
    {
        c.Write("I read");
    }
}



//realise
class Program
{
    static void Main()
    {//
       // char[] justarr = new char("gsg", "gsgsg", "gaga");

      //  var ourQuery = justarr.Where
    }
}