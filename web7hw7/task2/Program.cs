/*Задача 50. Напишите программу, которая на вход принимает позиции
 элемента в двумерном массиве, и возвращает значение этого элемента 
 или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

System.Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите позицию элемента:");
int position = Convert.ToInt32(Console.ReadLine());

int[,] array = Generate2DArray(m,n);
Print2DArray(array);
System.Console.WriteLine();
FindElement(array, position);

void FindElement (int[,] arr , int position)
{
    if ( position < n*m)
    {
        System.Console.WriteLine($"Элемент на {position} позиции - > {arr[position / n, position % n]}");
    }
    else 
    {
        System.Console.WriteLine("такого элемента нет");
    }
}


int[,] Generate2DArray (int m, int n)
{
    int[,] result = new int[m,n];
    for ( int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(1,100);
        }
    }
    return result;
}

void Print2DArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
