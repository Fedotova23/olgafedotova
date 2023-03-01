/*Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

System.Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(A(M, N));

int A (int m, int n)
{
    if (m == 0)
    {
        return 1 + n; 
    };
    if (m > 0 && n == 0)
    {
        return A(m - 1, 1);
    }
    
    return A (m - 1, A(m, n -1));
}

