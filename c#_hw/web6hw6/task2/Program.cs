﻿/*  Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

System.Console.Write("Введите значение b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите значение k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Уравнение первой прямой : y = {k1}x + {b1} ");
System.Console.WriteLine($"Уравнение второй прямой : y = {k2}x + {b2} ");

System.Console.Write($"точка пересечения: ");
GetPoint(b1, k1, b2, k2);

void GetPoint (  double b1, double k1, double b2, double k2 )
{
    double x = (b2 - b1)/(k1 -k2);
    double y = k1*x + b1;
    System.Console.WriteLine($" точка пересечения: ({x} ; {y})");
}

