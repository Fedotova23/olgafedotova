﻿
/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

System.Console.WriteLine("your number:");
int number = Convert.ToInt16(Console.ReadLine());


for ( int i = 1; i <= number; i++){
    if (i % 2 == 0){ 
    System.Console.WriteLine(i);
    }
};