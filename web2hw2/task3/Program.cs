/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int number = Convert.ToInt32(Console.ReadLine());

if(number > 0 && number < 8)
{ 
        if (number < 6)
    {
    System.Console.WriteLine($"{number} -> нет");
    }
        else
    {
    System.Console.WriteLine($"{number} -> да");
    };
}
else
{
    System.Console.WriteLine($"{number} -> такого дня нет");
};