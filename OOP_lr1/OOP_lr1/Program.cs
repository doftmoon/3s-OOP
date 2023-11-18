//def
using c = System.Console;



//1)	Типы
/*
 * a.   Определите переменные всех возможных примитивных типов С#  и проинициализируйте их. 
 *  Осуществите ввод и вывод их значений используя консоль.
 */
static void FillTypes()
{
    Console.Write("Enter value of int: ");
    int intValue = int.Parse(Console.ReadLine());
    Console.WriteLine("int: " + intValue);

    Console.Write("Enter value of uint: ");
    uint uintValue = uint.Parse(Console.ReadLine());
    Console.WriteLine("uint: " + uintValue);

    Console.Write("Enter value of nint: ");
    nint nintValue = nint.Parse(Console.ReadLine());
    Console.WriteLine("nint: " + nintValue);

    Console.Write("Enter value of nuint: ");
    nuint nuintValue = nuint.Parse(Console.ReadLine());
    Console.WriteLine("nuint: " + nuintValue);

    Console.Write("Enter value of short: ");
    short shortValue = short.Parse(Console.ReadLine());
    Console.WriteLine("short: " + shortValue);

    Console.Write("Enter value of ushort: ");
    ushort ushortValue = ushort.Parse(Console.ReadLine());
    Console.WriteLine("ushort: " + ushortValue);

    Console.Write("Enter value of long: ");
    long longValue = long.Parse(Console.ReadLine());
    Console.WriteLine("long: " + longValue);

    Console.Write("Enter value of ulong: ");
    ulong ulongValue = ulong.Parse(Console.ReadLine());
    Console.WriteLine("ulong: " + ulongValue);

    Console.Write("Enter value of byte: ");
    byte byteValue = byte.Parse(Console.ReadLine());
    Console.WriteLine("byte: " + byteValue);

    Console.Write("Enter value of sbyte: ");
    sbyte sbyteValue = sbyte.Parse(Console.ReadLine());
    Console.WriteLine("sbyte: " + sbyteValue);

    Console.Write("Enter value of float: ");
    float floatValue = float.Parse(Console.ReadLine());
    Console.WriteLine("float: " + floatValue);

    Console.Write("Enter value of double: ");
    double doubleValue = double.Parse(Console.ReadLine());
    Console.WriteLine("double: " + doubleValue);

    Console.Write("Enter value of decimal: ");
    decimal decimalValue = decimal.Parse(Console.ReadLine());
    Console.WriteLine("decimal: " + decimalValue);

    Console.Write("Enter value of char: ");
    char charValue = char.Parse(Console.ReadLine());
    Console.WriteLine("char: " + charValue);

    Console.Write("Enter value of bool (True or False): ");
    bool boolValue = bool.Parse(Console.ReadLine());
    Console.WriteLine("bool: " + boolValue);

    Console.Write("Enter str: ");
    string stringValue = Console.ReadLine();
    Console.WriteLine("string: " + stringValue);
}
FillTypes();


/*
 * b.	Выполните 5 операций явного и 5 неявного приведения.  Изучите возможности класса Convert.
 */
double explicitDouble = 10.5;
int explicitInt = (int)explicitDouble;

long explicitLong = 1000;
short explicitShort = (short)explicitLong;

float explicitFloat = 3.14f;
byte explicitByte = (byte)explicitFloat;

decimal explicitDecimal = 10.99m;
int explicitInt2 = (int)explicitDecimal;

byte explicitByte2 = 255;
short explicitShort2 = (short)explicitByte2;

c.WriteLine(explicitInt);
c.WriteLine(explicitShort);
c.WriteLine(explicitByte);
c.WriteLine(explicitInt2);
c.WriteLine(explicitShort2);

int implicitInt = 10;
double implicitDouble = implicitInt;

byte implicitByte = 100;
int implicitInt2 = implicitByte;

float implicitFloat = 3.14f;
double implicitDouble2 = implicitFloat;

int implicitInt3 = 10;
decimal implicitDecimal = implicitInt3;

short implicitShort = 100;
int implicitInt4 = implicitShort;

c.WriteLine(implicitDouble);
c.WriteLine(implicitInt2);
c.WriteLine(implicitDouble2);
c.WriteLine(implicitDecimal);
c.WriteLine(implicitInt4);

string intString = "123";
int intValue1 = Convert.ToInt32(intString);
c.WriteLine(intValue1);


/*
 * c.	Выполните упаковку и распаковку значимых типов.
 */
int number = 42;

object boxedNumber = number;

int unpackedNumber = (int)boxedNumber;

c.WriteLine($"Value of var number: {number}");
c.WriteLine($"Value of var boxedNumber (after boxing): {boxedNumber}");
c.WriteLine($"Value of var unpackedNumber (after unboxing): {unpackedNumber}");


/*
 * d.	Продемонстрируйте работу с неявно типизированной переменной.
 */
var number123 = 10;
var name = "John";
var pi = 3.14;

c.WriteLine($"number: {number123}, type: {number123.GetType()}");
c.WriteLine($"name: {name}, type: {name.GetType()}");
c.WriteLine($"pi: {pi}, type: {pi.GetType()}");


/*
 * e.	Продемонстрируйте пример работы с Nullable переменной.
 */

int? nullableNumber = null;
double? nullableValue = 3.14;

c.WriteLine($"nullableNumber: {nullableNumber}");
c.WriteLine($"nullableValue: {nullableValue}");

if (nullableNumber.HasValue)
{
    int value = nullableNumber.Value;
    c.WriteLine($"nullableNumber has value: {value}");
}
else
{
    c.WriteLine("nullableNumber has no value");
}



/*
 * f.	Определите переменную  типа  var и присвойте ей любое значение.
 *  Затем следующей инструкцией присвойте ей значение другого типа. Объясните причину ошибки.
 */
var variable = "Hello";

//variable = 42; //ошибка



//2)	Строки
/*
 * a.	Объявите строковые литералы. Сравните их.
 */
string st1 = "hello";
string st2 = "my";
string st3 = "friend";

c.WriteLine(string.Compare(st1, st2) == 0);
string st4 = string.Concat(st1, st2);

string substr = st1.Substring(2, 3);

string phrase = "can your cat do a flip";
string[] words = phrase.Split(' ');


string nst = "dog cat";
string nst1 = "mouse";

c.WriteLine(nst.Insert(4, nst1));


string nst2 = "dog cat mouse";

c.WriteLine(nst2.Remove(0, 4));

int a1 = -10;
c.WriteLine($"int a = {a1}; string: {st1}");


string? nst3 = null;
if (String.IsNullOrEmpty(nst3))
    c.WriteLine("str null or empty");
else c.WriteLine("str not null and not empty");

string emptyString = "";

if (string.IsNullOrEmpty(emptyString))
{
    c.WriteLine("str null or empty");
}
else
{
    c.WriteLine("str not null and not empty");
}



var sb = new System.Text.StringBuilder("Great weather");

sb.Append("!");

sb.Insert(17, ",Vlad");
c.WriteLine(sb.ToString());
sb.Remove(17, 5);
c.WriteLine(sb.ToString());




int[,] arr = { { 1, 2, 3 }, { 33, 34, 35 }, { 8, 9, 10 } };
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        c.Write($"{arr[i, j]}\t");
    }
    c.Write("\n\n");
}

string[] array = { "str 1", "str 2", "str 3", "str 4" };


c.WriteLine("arr is:");
for (int i = 0; i < array.Length; i++)
{
    c.WriteLine("El {0}: {1}", i, array[i]);
}
c.WriteLine("Arr length: {0}", array.Length);


c.Write("Enter pos of el to change (from 0 to {0}): ", array.Length - 1);
int position = Convert.ToInt32(c.ReadLine());

c.Write("Enter new el value: ");
string newValue = c.ReadLine();


if (position >= 0 && position < array.Length)
{
    array[position] = newValue;
    c.WriteLine("Successfully changed.");
}
else
{
    c.WriteLine("Wrong pos of el.");
}


c.WriteLine("Arr is:");
for (int i = 0; i < array.Length; i++)
{
    c.WriteLine("El {0}: {1}", i, array[i]);
}
c.WriteLine("Arr length: {0}", array.Length);



double[][] myArr = new double[3][];

for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = new double[i + 2];
    c.WriteLine($"Enter el of n:{i + 1} arr");
    for (int j = 0; j < myArr[i].Length; j++)
    {
        myArr[i][j] = Convert.ToDouble(c.ReadLine());
    }
}

for (int i = 0; i < myArr.Length; i++)
{
    for (int j = 0; j < myArr[i].Length; j++)
    {
        c.Write(myArr[i][j] + " | ");
    }
    c.WriteLine();
}


var vrr = new[] { 22, 54, 154, 84 };
var vst = new[] { "Hello", "My", "Dear", "Friend" };
c.WriteLine("type {0}", vrr.GetType());
c.WriteLine("type {0}", vst.GetType());



(int, string, char, string, ulong) car = (250, "mercedes", 'S', "benz", 520);
c.WriteLine(car);
c.WriteLine($"speed:{car.Item1}\nName:{car.Item2}");

string kor;
int kor2;

(string kor, ushort kor2) ha = ("Hello", 11);

kor = ha.kor;
kor2 = ha.kor2;

//var (kor, kor2) = ("Hello", 11);

(kor, _, _) = tuplesReturn();

c.WriteLine(ha == ("Hello", 11));
c.WriteLine(ha == ("Hello", 22));
static (string, ushort, char) tuplesReturn()
{
    return ("Hello", 33, 'a');
}


(int, int, int, string) tsk()
{
    int[] ar = new int[] { 3, 2, 11, 9, 1, 8, 5 };
    string strk = "car";
    int min = ar[0];
    int max = ar[0];
    int sumarr = 0;
    string firstlit;
    for (int nu = 0; nu < ar.Length; nu++)
    {
        sumarr += ar[nu];
        if (min > ar[nu])
            min = ar[nu];
        if (max < ar[nu])
            max = ar[nu];
    }
    firstlit = strk.Remove(1);
    var Korteg = (min, max, sumarr, firstlit);
    return Korteg;
}
c.WriteLine(tsk());
void LocalFunctionsExample()
{
    void CheckedFunction()
    {
        checked
        {
            int maxValue = int.MaxValue;
            //maxValue++;   
            c.WriteLine($"Value in block checked: {maxValue}");
        }
    }

    void UncheckedFunction()
    {
        unchecked
        {
            int maxValue = int.MaxValue;
            c.WriteLine($"Value in block unchecked: {maxValue}");
        }
    }

    CheckedFunction();
    UncheckedFunction();
}
LocalFunctionsExample();