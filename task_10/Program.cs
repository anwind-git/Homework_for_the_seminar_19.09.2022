// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int number2 = number / 10 % 10;

Console.WriteLine("Вторая цифра введенного числа: " + number2);

