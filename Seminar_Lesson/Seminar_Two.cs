// Console.Clear();

// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// int namber = new Random().Next(10, 100);
// Console.WriteLine($"случайное число из отрезка [10, 99] -> {namber}");
// int firstDigit = namber / 10;
// int secondDigit = namber % 10;
// if (firstDigit > secondDigit )
// {
//     Console.WriteLine($"Наибольшее число {firstDigit}");
// }
// else{
//     Console.WriteLine($"Наибольшее число {secondDigit}");
// }
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

// Решения с фунуциями (метод)

// int namber = new Random().Next(10, 100);
// Console.WriteLine($"случайное число из отрезка [10, 99] -> {namber}");
// int max = MaxDigit(namber);
// int MaxDigit(int namber)
// {
//     int firstDigit = namber / 10;
//     int secondDigit = namber % 10;
//     int result = (firstDigit > secondDigit ? firstDigit : secondDigit);
//     return result; 
// }
// Console.WriteLine($"Наибольшее число {max}");


// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

//11
// int number = new Random().Next(100, 1000);
// Console.WriteLine($"случайное трёхзначное число => {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;

// int result = firstDigit*10 + thirdDigit;
// Console.WriteLine(result);

//12
// Console.WriteLine("Введите число Первое");
// int firstDigit = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число Второе");
// int secondDigit = Convert.ToInt32(Console.ReadLine());
// double result = firstDigit % secondDigit;
// if (result == 0)
// {
//     Console.WriteLine($"{firstDigit}, {secondDigit} -> кратно");
// }
// else {
//     Console.WriteLine($"{firstDigit}{secondDigit} -> не кратно, остаток {result}");
// }

//Решение яерез метод 
// Console.WriteLine("Введите число Первое");
// int firstDigital = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число второе");
// int secondDigit = Convert.ToInt32(Console.ReadLine());
// int res = Method(firstDigital, secondDigit);
// Console.WriteLine(res == 0 ? "Кратно" : $"не кратно, остаток {res}");


// int Method(int firstDigital, int secondDigit)
// {
//     return firstDigital % secondDigit;
// }

//14
// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

//16
// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int numA = 7;
// int numB = 23;
// int i = 0;
// if (number % numA == 0 && number % numB == 0 )
// {
//     Console.WriteLine($"{number} -> Да");
// }
// else {
//     Console.WriteLine($"{number} -> Нет");
// }

// Решение через метод (функцию)
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Method(number) ? "Да" : "Нет");


// bool Method (int number, int num1 = 7, int num2 = 23)
// {
//     return number % num1 == 0 && number % num2 == 0;
// }

//16 
Console.WriteLine("Введите число Первое");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число второе");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Method(number1,number2) ? "Да" : "Нет");

bool Method(int num1, int num2)
{
    return num1*num1 == num2 || num2*num2 == num1;
}