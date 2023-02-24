/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int[] GetRandomArray ()
{
    int [] result = new int [8];
    Random rnd = new Random();
    for ( int i = 0; i < 8; i++)
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

PrintArray(GetRandomArray());