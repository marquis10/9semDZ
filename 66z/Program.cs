using System;
using static System.Console;

int PrintSum(int a, int b)
{
    //int sum = a;
    if (b == a)
        return a;
    int sum = b + PrintSum(a, b - 1);
    return (sum);
}

Clear();
Write("Введите значение M: ");
int m = int.Parse(ReadLine());
Write("Введите значение N: ");
int n = int.Parse(ReadLine());
WriteLine(PrintSum(m, n));