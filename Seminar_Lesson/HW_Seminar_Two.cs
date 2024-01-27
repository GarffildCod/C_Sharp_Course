// Задача 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num} -> {Method(num)}");

// int Method(int num1)
// {
//     num1 = num1 % 100;
//     num1 = num1 / 10;
//     return num1;
// }

// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num <= 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else{
// int result = Method(num) % 10;
// Console.WriteLine($"{num} -> {result}");
// }

// int Method(int num1)
// {
//     while(num1 > 1000)
//     {
//         num1 = num1 / 10;
//     }
//     return num1;
// }

// Задача 15
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите День недели");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 8)
{
     if(num >= 6)
     {
        Console.WriteLine($"{num} -> да");
     }
    else{
        Console.WriteLine($"{num} -> нет");
    }

}
else {
    Console.WriteLine("Такого дня недели нет");
}