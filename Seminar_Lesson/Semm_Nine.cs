// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// NaturalNumber(number);

// void NaturalNumber(int num)
// {
//     if(num == 0) return;
//     NaturalNumber(num - 1);
//     Console.Write($"{num} ");
// }

// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.WriteLine("Введите число M");
// int numberM = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int numberN = Convert.ToInt32(Console.ReadLine());

// NaturalNumberRange(numberM, numberN);

// void NaturalNumberRange (int numM, int numN)
// {
//     if(numM == numN) Console.WriteLine($"{numM} ");
//     else if(numM < numN)
//     {
//          Console.Write($"{numM} ");
//         NaturalNumberRange(numM + 1, numN);
//     }
//     else if(numM > numN) 
//     {
//         Console.Write($"{numM} ");
//         NaturalNumberRange(numM - 1, numN);
//     }
// }

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// int FactorialFor(int n)
// {
// int result = 1;
// for (int i = 1; i <= n; i++) result *= i;
// return result;
// }
// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10)); // 3628800
// Console.WriteLine(FactorialRec(10)); // 3628800


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumber(number));

int SumNumber(int num)
{
    if (num == 0) return num;
    else return num%10 + SumNumber(num/10);
}

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A = {numberM} B = {numberN} ->{MathPow(numberM,numberN)}");

int MathPow (int numM, int numN)
{
    if(numN == 0) return 1;
    else return numberM * MathPow(numM, numN - 1);
}

