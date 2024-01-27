// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// Console.WriteLine("Введите координаты точки");
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter(x, y);
// string result = quarter > 0
// ? $"Указанные координаты соответствуют четверти -> {quarter}"
// : "Введены некорректные координаты";
// Console.WriteLine(result);

// int Quarter(int xc, int yc)
// {
// if (xc > 0 && yc > 0) return 1;
// if (xc < 0 && yc > 0) return 2;
// if (xc < 0 && yc < 0) return 3;
// if (xc > 0 && yc < 0) return 4;
// return 0;
// }

// Задача 18
// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите четверть");
// int x = Convert.ToInt32(Console.ReadLine());

// string result = Quarter(x);
// Console.WriteLine($"диапазон возможных координат точек в этой четверти {result} " );

// string Quarter(int xc)
// {
//     if (xc == 1) return "x > 0 && y > 0";
//     if (xc == 2) return "x < 0 && y > 0";
//     if (xc == 3) return "x < 0 && y < 0";
//     if (xc == 4) return "x > 0 && y < 0";
//     return "0";
// }


// double d = Math.Sqrt(355);
// double f = Math.Pow(2, 10);
// double num = 5.099873456;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);

// Задача 20
// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите координаты");
// Console.WriteLine("XA: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("XB: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YA: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YB: ");
// int yb = Convert.ToInt32(Console.ReadLine());

// int result = Distens(xa, xb, ya, yb);
// Console.WriteLine($"A ({xa, xb}); B ({ya, yb}) -> {result});

// double Distens(x1,  x2,  y1,  y2)
// {
//     double distens = Math.Pow(Math.Sqrt(x1 - x2) + Math.Sqrt(y1 - y2));
//     return distens;
// }

// Console.WriteLine("Введите координаты");
// Console.WriteLine("XA: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("XB: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YA: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YB: ");
// int yb = Convert.ToInt32(Console.ReadLine());

// double result = Math.Round(Method(xa, xb, ya, yb) ,2 ,MidpointRounding.ToZero);
// Console.WriteLine($"расстояние между ними {xa}, {xb} и {ya}, {yb} is {result}");

// double Method(int x1, int x2, int y1, int y2)
// {
//     double distens = Math.Sqrt(Math.Pow((x2 - x1) ,2) + Math.Pow((y2 - y1), 2));
//     return distens;
// }

// Задача 22
// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

// Console.WriteLine("Введите натуральное число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0 )
// {
//     Method(number);
// }
// else{
//     Console.WriteLine("Не натуральное число");
// }

// void Method(int num)
// { 
//     int count = 1;
//     while (count <= num)
//     {
//         Console.WriteLine($"{count,4} {Math.Pow(count, 2),4}");
//         count++;
//     }
// }