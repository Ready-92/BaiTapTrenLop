using System;

Console.WriteLine("Hello, World!");

int ReadInt(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var input = Console.ReadLine();
        if (int.TryParse(input, out var value))
            return value;
        Console.WriteLine("Nhap sai, nhap lai");
    }
}

int a = ReadInt("Nhap a: ");
int b = ReadInt("Nhap b: ");
int c = ReadInt("Nhap c: ");

int sum = a + b + c;
double average = sum / 3.0;

Console.WriteLine($"a+b+c={sum}");
Console.WriteLine($"average={average}");
