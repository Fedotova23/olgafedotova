/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

int num = Convert.ToInt32(Console.ReadLine());
int tempNum = num;
int newnum = 0;

while (tempNum >0)
{
    newnum = newnum*10 + tempNum % 10;
    tempNum = tempNum/10;
}

System.Console.WriteLine(newnum);

if (num == newnum)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}