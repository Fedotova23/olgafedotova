/*Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


System.Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine(SumBetween(M, N));

int SumBetween (int start, int finish)
{
    if (start == finish)
    {
        return finish; 
    };
    return (start + SumBetween (start + 1, finish));
}
