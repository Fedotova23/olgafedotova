/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

System.Console.WriteLine("Введите координаты точки A");
System.Console.Write("x = ");
int ax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int ay = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z = ");
int az = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B");
System.Console.Write("x = ");
int bx = Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int by = Convert.ToInt32(Console.ReadLine());
System.Console.Write("z = ");
int bz = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((bx-ax), 2) + Math.Pow((by-ay), 2) + Math.Pow((bz-az), 2));

System.Console.WriteLine($"расстояние между точками равно {d}");