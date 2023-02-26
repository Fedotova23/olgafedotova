/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/


System.Console.WriteLine("first number:");
int number1 = Convert.ToInt16(Console.ReadLine());

System.Console.WriteLine("second number:");
int number2 = Convert.ToInt16(Console.ReadLine());

System.Console.WriteLine("third number:");
int number3 = Convert.ToInt16(Console.ReadLine());

int max = number1;

if (number2 > max){
    max = number2;
    if (number3 > max){ 
        max = number3;
        }
}
else if (number3 > max){
        max = number3;
};
System.Console.WriteLine("max=" + max);

