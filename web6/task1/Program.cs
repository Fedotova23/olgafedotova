
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

int[] ReverseMass (int[] arr)
{
    int[] newMass = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newMass[i] = arr[arr.Length -1 - i ];
    }
    return newMass;
}

int[] array = GetRandomArray(10);

PrintArray(array);
System.Console.WriteLine();
PrintArray(ReverseMass(array));
