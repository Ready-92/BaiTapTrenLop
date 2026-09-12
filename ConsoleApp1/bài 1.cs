using System;

Console.WriteLine("Hello World!");

int ReadInt(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var input = Console.ReadLine();
        if (int.TryParse(input, out var value))
            return value;
        Console.WriteLine("nhap sai, nhap lai");
    }
}

int a = ReadInt("nhap a: ");
int b = ReadInt("nhap b: ");
int c = ReadInt("nhap c: ");

int sum = a + b + c;
double average = sum / 3.0;

Console.WriteLine($"a+b+c={sum}");
Console.WriteLine($"average={average}");
