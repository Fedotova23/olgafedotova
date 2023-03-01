/*Задайте значение N. Напишите программу, которая выведет все
натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

System.Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(NatNumbers(N, 1));

string NatNumbers (int start, int finish)
{
    if (start == finish)
    {
        return finish.ToString(); 
    };
    return (start + " " + NatNumbers(start - 1, finish));
}
