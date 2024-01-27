// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число");
// int numbers = Convert.ToInt32(Console.ReadLine());
// int result = SumNumbers(numbers);

// Console.WriteLine($"Сумма чисел от 1 до {numbers} = {result}");

// int SumNumbers (int num)
// {
//     int sum = 0;
//     for(int i = 1; i <= num; i++)
//     {
//     sum = sum + i;
//     }
//     return sum;
// }

// Задача26
// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число");
// int numbers = Convert.ToInt32(Console.ReadLine());
// int result = Met1(numbers);
// Console.WriteLine($"{numbers} -> {result}");


// int Met1(int num1)
// {
//     int i = 0;
//     while(num1 > 0)
//     {
//         i++;
//         num1 = num1/10;
//     }
//     return i;
// }

// Другой вариант нахождения количества числа

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int countNumbers = CountNumbers(number);
// Console.WriteLine($"Количество цифр в числе = {countNumbers}");

// int CountNumbers(int digit)
// {
//     int count = 0;

//     while (digit != 0)
//     {
//         digit = digit/10;
//         count = count + 1;
//     }
//     return count;
// }

// Задача 28
// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = Met(number);
// Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");


// int Met(int num)
// {
//     int sum = 1;
//     for(int i = 1; i <= num; i++)
//     {
//     sum = sum * i;
//     }
//     return sum;
// }

// int Met(int num)
// {
//     int sum = 1;
//     for(int i = 1; i <= num; i++)
//     {
//         checked
//         {
//             sum = sum * i;
//         }
//     }
//     return sum;
// }

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8]; // 0,1,2,3,4,5,6,7

// FillArray(array);
// PrintArray(array);

// void FillArray(int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = new Random().Next(0, 2);
// }
// }

// void PrintArray(int[] arr)
// {
// for (int i = 0; i < arr.Length; i++)
// {
// Console.Write(arr[i] + " ");
// }
// }


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumber(number);

void NaturalNumber (int num)
{
    if(num == 0) return;
    NaturalNumber(num - 1);
    Console.Write($"{num} ");
}
