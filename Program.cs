﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("Введите первое неотрицательное число ");
int m = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Введите второе неотрицательное число ");
int n = Convert.ToInt32(Console.ReadLine() ?? "");
if (m >= 0 && n >= 0) Console.WriteLine($"{Akkerman(m,n)}");
else Console.WriteLine("Некорректный ввод");
int Akkerman(int m, int n)
{
    if (m==0) return n+1;
    else if (m > 0 && n == 0) return Akkerman(m-1,1);
    else return Akkerman(m-1,Akkerman(m,n-1));
}
