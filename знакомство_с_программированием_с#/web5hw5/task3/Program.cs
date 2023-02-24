 /*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int DiffBetweenMaxAndMin(int max, int min)
{
    return max - min;
}

int FindMax (int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        max = arr[i];
    }
    return max;
}

int FindMin (int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        min = arr[i];
    }
    return min;
}

int[] GetRandomArray (int lenght)
{
    int [] result = new int [lenght];
    Random rnd = new Random();
    for ( int i = 0; i < lenght; i++)
    {
        result[i] = rnd.Next(0, 100);
    }
    return result;
}

void PrintArray (int[] arr)
{
    foreach (int item in arr)
    {
        System.Console.WriteLine(item);
    }
}

int[] array = GetRandomArray(10);

PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(FindMax(array));
System.Console.WriteLine();
System.Console.WriteLine(FindMin(array));
System.Console.WriteLine();
System.Console.WriteLine(DiffBetweenMaxAndMin(FindMax(array),FindMin(array)));