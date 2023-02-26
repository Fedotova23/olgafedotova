/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

int number = Convert.ToInt32(Console.ReadLine());

int digits = 0;
int tempNumber = number;
int result = number;

while (tempNumber > 0)
{
    tempNumber = tempNumber / 10;
    digits++;
};

if (digits > 2){
        while (digits > 3)
    {
    result = result/10;
    digits--;
    };
    System.Console.WriteLine($"{number} -> {result % 10}"); 
}
else
{
    System.Console.WriteLine($"{number} -> третьей цифры нет");
};