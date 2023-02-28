/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

System.Console.WriteLine("Введите количество строк первой матрицы:");
int m1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов первой матрицы:");
int n1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество строк второй матрицы:");
int m2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов второй матрицы:");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = Generate2DArray(m1,n1);
Print2DArray(array1);
System.Console.WriteLine();

int[,] array2 = Generate2DArray(m2,n2);
Print2DArray(array2);
System.Console.WriteLine();

Print2DArray(GetMatrixMultiplication(array1, array2));

int[,] GetMatrixMultiplication(int[,] matr1, int [,] matr2)
{
    int[,] mult = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for(int i = 0; i < mult.GetLength(0); i++)
    {
        for (int j = 0; j < mult.GetLength(1); j++)
        {
            for (int r = 0; r < matr1.GetLength(1); r++)
                mult[i,j] += matr1[i,r]*matr2[r,j];
        }
    }
    return mult;
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
