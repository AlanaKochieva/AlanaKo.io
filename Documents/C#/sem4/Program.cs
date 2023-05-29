//  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Summa(int num)
// {
//     int res = 0;
//     for (int i = 1; i <= num; i ++)
//     res += i;
//     return res;
// }



// try 
// {
// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {Summa(num)}");
// }
// catch
// {
//     System.Console.WriteLine("Надо вводить целое число"); 
// }


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// int sum(int num)
// {
//     int res = 0;
//     while(num > 0)
//     {
//     num = num/10;
//     res = res + 1;
//     }
//     return res;   
// }


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Сумма всех чисел в {num} равна {sum(num)}");


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int Resault(int num)
// {
// int result = 1;
// for (int i = 1; i <= num; i++)
// {
// result = result * i;
// }
// return result;
// }




// System.Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Факториал числа: {Resault(num)}");.


// Hапишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int [] CreateArray()
// {
// Random random = new Random();
// int[] numbers = new int[8];
// System.Console.Write("Массив:");
// for (int x = 0; x < numbers.Length; x++)
// {
// {
// numbers[x] = random.Next(0, 2);
// System.Console.Write($" {numbers[x]}");
// }
// }
// return numbers;

// }

// int [] numbers = CreateArray();


//  Hапишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] и находит среднеарифметическое
// int [] CreateArray()
// {
// Random random = new Random();
// int[] numbers = new int[8];
// System.Console.Write("Массив:");
// for (int x = 0; x < numbers.Length; x++)
// {
// {
// numbers[x] = random.Next(0, 2);

// }
// }
// return numbers;

// }

// void PrintArray(int [] numbers)
// {
// for (int x = 0; x < numbers.Length; x++)
// System.Console.Write($" {numbers[x]}");
// }

// double Result(int [] numbers)
// {
// double summ = 0;
// for (int x = 0; x < numbers.Length; x++)
// {
// summ = summ + numbers[x];

// }
// return summ / 8;
// }


// int [] numbers = CreateArray();
// PrintArray(numbers);



// палиндром?


// System.Console.WriteLine("введите 5 значное число");

// string? str = Console.ReadLine();
// int num =Convert.ToInt32(Convert.ToString(str[0]));
// Console.WriteLine(num);



