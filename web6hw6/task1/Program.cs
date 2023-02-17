/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

System.Console.Write("Введите числа через пробел: ");

string? numbers = Console.ReadLine();
string[] num = numbers!.Split(' ');

int[] nums = new int[num.Length];

for (int i = 0; i < num.Length; i++)
{
    nums[i] = Convert.ToInt32(num[i]);
}



int GetNumOfPositive (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ( arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}


System.Console.WriteLine(GetNumOfPositive(nums));
