// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число B");
// int b = Convert.ToInt32(Console.ReadLine());
// int step = a;

// for (int i = 1; i < b; i++)
// {
// step = step * a;
// }
// Console.WriteLine("A в степени B равно: " + step);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum(int num)
// {
// int result = 0;
// while (num > 0)
// {
//     result = result + num % 10;
//      num = num/10;
// }
// return result;
// }


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {num} равна {Sum(num)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



// int [] CreateArray()
// {
// Random random = new Random();
// int[] numbers = new int[8];
// System.Console.Write("Массив:");
// for (int x = 0; x < numbers.Length; x++)
// {
// {
//     numbers[x] = random.Next(0, 1000);
// System.Console.Write($" {numbers[x]}");
// }
// }
// return numbers;

// }

// int [] numbers = CreateArray();