/* Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int GetNumOfEven (int [] arr)
{  
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] GetRandomArray (int lenght)
{
    int [] result = new int [lenght];
    Random rnd = new Random();
    for ( int i = 0; i < lenght; i++)
    {
        result[i] = rnd.Next(100, 1000);
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
System.Console.WriteLine(GetNumOfEven(array));