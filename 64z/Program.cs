using System;
using static System.Console;

string PrintNumbers(int a, int b)
{
    if (b == a)
        return b.ToString();
    return (b + " " + PrintNumbers(a, b - 1));
}

Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine());
Write("Введите число N: ");
int n = int.Parse(ReadLine());
WriteLine(PrintNumbers(m, n));