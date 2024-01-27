// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// while(number > 0)
// {
//     i++;
//     number = number/10;
// }



// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// int coll =  Met1(number);
// if(coll == 5)
// {
//   if(Met2(number) == Met3(number) && Met4(number) == Met5(number))
//   {
//     Console.WriteLine($"{number} -> Да");
//   }
//   else{
//     Console.WriteLine($"{number} -> Нет");
//   }
// }
// else{
//     Console.WriteLine("Вы введи не пятизначное число");
// }

// int Met1 (int num1)
// {
//     while(num1 > 0)
//     {
//         i++;
//         num1 = num1/10;
//     }
//     return i;
// }

   
// int Met2 (int num2) 
// {
//     num2 = num2 % 10;
//     return num2;
// }
// int Met3 (int num3)
// {
//     num3 = num3 / 10000;
//     return num3;
// }
// int Met4 (int num4)
// {
//     num4 = num4 / 1000;
//     num4 = num4 % 10;
//     return num4;
// }
// int Met5 (int num5)
// {
//     num5 = num5 / 10;
//     num5 = num5 % 10;
//     return num5;
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты");
// Console.WriteLine("XA: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("XB: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YA: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YB: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ZA: ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ZB: ");
// int zb = Convert.ToInt32(Console.ReadLine());

// double result = Math.Round(Method(xa, xb, ya, yb, za, zb) ,2 ,MidpointRounding.ToZero);
// Console.WriteLine($"расстояние между ними {xa}, {xb} и {ya}, {yb} и {za}, {zb} is {result}");

// double Method(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double distens = Math.Sqrt(Math.Pow((x2 - x1) ,2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2) );
//     return distens;
// }

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 0)
// {
//     Met(number);
// }
// else{
//     Console.WriteLine("Не натуральное число");
// }

// void Met(int num)
// {
//     int count = 1;
//     while(count <= num)
//     {
//         Console.WriteLine($"{count,4} | {Math.Pow(count, 3),4}");
//          count++;
//     }
// }