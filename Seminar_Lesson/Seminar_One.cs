// Console.Clear();

// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int a = i * i; 
// Console.WriteLine(a);

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine($"Квадрат числа {number} равен {square}");


// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());  //25 
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());  //5 
int square = numberB * numberB;
if(numberA == square)
{
    Console.WriteLine("Да является");
}
else
{
    Console.WriteLine("Нет не является");
}

// int[] array = {1, 2, 3, 4, 5, 6, 7};
// Console.WriteLine("Введите число");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberA == array[0])
// {
//     Console.WriteLine("Понедельник");
// }
// else if(numberA == array[1])
// {
//     Console.WriteLine("Вторние");
// }
// else if(numberA == array[2])
// {
//     Console.WriteLine("Среда");
// }
// else if(numberA == array[3])
// {
//     Console.WriteLine("Четверг");
// }
// else if(numberA == array[4])
// {
//     Console.WriteLine("Пятница");
// }
// else if(numberA == array[5])
// {
//     Console.WriteLine("Суббота");
// }
// else if(numberA == array[6])
// {
//     Console.WriteLine("Воскресенье");
// }
// else {
//     Console.WriteLine("День недели не найден");
// }



// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Введите первое число");
// int numberA = Convert.ToInt32(Console.ReadLine()); //4 
// int numberB = -numberA;
// while(numberB <= numberA)
// {
//     Console.Write(numberB + " ");
//     numberB++;
// }

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
double ost = number % 10 ;
// Console.WriteLine(ost);
if (number >= 100 && number <= 999)
{
    Console.WriteLine($"Посдежния цифра в числе {number} равна {ost} ");
}
else {
    Console.WriteLine("Вы введи не трехзначное число");
}