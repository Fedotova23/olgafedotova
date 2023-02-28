/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

System.Console.WriteLine("Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = Generate2DArray(m,n);
Print2DArray(array);
System.Console.WriteLine();
PrintArray(GetSummOfEveryLineInMatrix(array));
System.Console.WriteLine();
System.Console.WriteLine($"номер строки с наименьшей суммой = {FindMin(GetSummOfEveryLineInMatrix(array))}");

int FindMin( int[] arr)
{
    int min = arr[0];
    int index = 0;
    for (int i = 1; i < arr.GetLength(0) - 1; i++)
    {
        if (arr[i +1] < arr[i])
        {
            min = arr[i+1];
            index = i+1;
        }
    }
    return index;
}


int [] GetSummOfEveryLineInMatrix( int[,] matr)
{
    int[] sum = new int[matr.GetLength(0)];
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i] += matr[i,j];
        }
        
    }
    return sum;
}

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

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        Console.Write($"{arr[i]} ");
        
    }
}
