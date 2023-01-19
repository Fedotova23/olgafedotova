// See https://aka.ms/new-console-template for more information
//int number = Convert.ToInt32(Console.ReadLine());

//int square = Convert.ToInt32(Math.Pow(number,2));

//System.Console.WriteLine(square);

//  Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (Convert.ToInt32((Math.Pow(number2,2))) == number1){
    // System.Console.WriteLine("yes");

// }
// else{
    // System.Console.WriteLine("no");
// };

int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay == 1){
    System.Console.WriteLine("monday");
}
else if (numberDay == 2){ 
    System.Console.WriteLine("tuesday");
}
else if (numberDay == 3){
    System.Console.WriteLine("wednesday");
}
else if (numberDay == 4){
    System.Console.WriteLine("therthday");
}
else if (numberDay == 5){
    System.Console.WriteLine("friday");
}
else if (numberDay == 6){
    System.Console.WriteLine("suturday");
}
else if (numberDay == 7){
    System.Console.WriteLine("sunday");
}
else {
    System.Console.WriteLine("no name");
}


