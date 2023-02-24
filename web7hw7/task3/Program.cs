/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

System.Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = Generate2DArray(m,n);
Print2DArray(array);
System.Console.WriteLine();
FindAverageOfColumns(array, m, n);

int[,] Generate2DArray (int m, int n)
{
    int[,] result = new int[m,n];
    for ( int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(1,10);
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

void FindAverageOfColumns(int[,] arr, int m, int n)
{
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sum += arr[j,i]; 
        }
        System.Console.Write($"{sum / m} ");
        sum = 0;
    }

}
