﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int A = Convert.ToInt32(System.Console.ReadLine());
int B = Convert.ToInt32(System.Console.ReadLine());

int Power (int A , int B)
{
    int res = 1;
    for (int i = 1; i <=  B; i++)
    {
        res = res * A;
    }
    return res;
}

System.Console.WriteLine(Power(A,B));