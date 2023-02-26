/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int GetSumOfOddIndexNum (int[] arr)
{
    int sum =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int[] GetRandomArray (int lenght)
{
    int [] result = new int [lenght];
    Random rnd = new Random();
    for ( int i = 0; i < lenght; i++)
    {
        result[i] = rnd.Next(0, 10);
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
System.Console.WriteLine(GetSumOfOddIndexNum(array));