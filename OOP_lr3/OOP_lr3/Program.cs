using System;
using System.Security.Cryptography.X509Certificates;

// Абстрактный класс "Компонент ПО"
public abstract class SoftwareComponent
{
    public string Name { get; set; }

    public SoftwareComponent(string name)
    {
        Name = name;
    }

    public abstract void Run();

    // Одноименный метод в абстрактном классе
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Abstract class: {Name}");
    }
}

// Интерфейс "Обновляемый"
public interface IUpdatable
{
    void Update();

    // Одноименный метод в интерфейсе
    void DisplayInfo()
    {
        Console.WriteLine("Inteface: IUpdatable");
    }
}

// Класс "Разработчик"
public class Developer
{
    public Software Software { get; set; }

    public Developer(Software software)
    {
        Software = software;
    }
}

// Класс "ПО"
public class Software
{
    public OperationSet Operations { get; set; }
    public TextProcessor TextProcessor { get; set; }
    public Virus Virus { get; set; }
    public Game Game { get; set; }
    public CConficker CConficker { get; set; }

    public Software(OperationSet operations, TextProcessor textProcessor, Virus virus, Game game, CConficker cConficker)
    {
        Operations = operations;
        TextProcessor = textProcessor;
        Virus = virus;
        Game = game;
        CConficker = cConficker;
    }
}

// Класс "Набор операций"
public class OperationSet : SoftwareComponent
{
    public OperationSet(string name) : base(name)
    {
    }

    public override void Run()
    {
        Console.WriteLine("Run OperationSet");
    }

    // Переопределение метода из абстрактного класса
    public override void DisplayInfo()
    {
        Console.WriteLine($"Class: {Name}");
    }
}

// Класс "Текстовый процессор"
public class TextProcessor : SoftwareComponent
{
    public Word Word { get; set; }

    public TextProcessor(string name, Word word) : base(name)
    {
        Word = word;
    }

    public override void Run()
    {
        Console.WriteLine("Run TextProcessor");
    }
}

// Класс "Word"
public class Word
{
    public string Name { get; set; }

    public Word(string name)
    {
        Name = name;
    }
}

// Класс "Вирус"
public sealed class Virus : SoftwareComponent, IUpdatable
{
    public Virus(string name) : base(name)
    {
    }

    public override void Run()
    {
        Console.WriteLine("Run Virus");
    }

    public void Update()
    {
        Console.WriteLine("Update Virus");
    }

    // Переопределение метода из абстрактного класса
    public override void DisplayInfo()
    {
        Console.WriteLine($"Class: {Name}");
    }

    // Переопределение метода из интерфейса
    void IUpdatable.DisplayInfo()
    {
        Console.WriteLine("I - IUpdatable");
    }
}

// Класс "Игра"
public class Game : SoftwareComponent
{
    public Minesweeper Minesweeper { get; set; }

    public Game(string name, Minesweeper minesweeper) : base(name)
    {
        Minesweeper = minesweeper;
    }

    public override void Run()
    {
        Console.WriteLine("Run Game");
    }
}

// Класс "CConficker"
public class CConficker
{
    public string Name { get; set; }

    public CConficker(string name)
    {
        Name = name;
    }
}

// Класс "Сапер"
public class Minesweeper
{
    public string Name { get; set; }

    public Minesweeper(string name)
    {
        Name = name;
    }
}

public class Program
{
    public static void Main()
    {
        OperationSet operationSet = new OperationSet("OperationSet");
        operationSet.Run();
        operationSet.DisplayInfo(); // Вызов метода из абстрактного класса
        Console.WriteLine(operationSet is OperationSet);

        Virus virus = new Virus("Virus");

        virus.Run();
        virus.Update();
        ((IUpdatable)virus).DisplayInfo(); // Вызов метода из интерфейса

        Console.ReadLine();
    }
}