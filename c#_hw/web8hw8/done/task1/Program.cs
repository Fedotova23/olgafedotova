/*Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

System.Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = Generate2DArray(m,n);
Print2DArray(array);
System.Console.WriteLine();
Print2DArray(SortLines(array));


int[,] SortLines ( int[,] arr )
{
    int temp = 0;
    for ( int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j+1; k < arr.GetLength(1); k++)
            if (arr[i,j] < arr[i,k])
            {
                temp = arr[i,j];
                arr[i,j] = arr [i,k];
                arr[i,k] = temp;
            }
        }
    }
    return arr;
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
