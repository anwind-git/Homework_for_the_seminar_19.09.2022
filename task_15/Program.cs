﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 0;
String d = " рабочий день";

String[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (num > 5 && num < 8)
{
    d = " и это выходной!";
}
if (num > 0 && num < 8)
{    
    num2 = num - 1;
    Console.WriteLine("День недели: " + array[num2] + d);
}
else
{
    Console.WriteLine("Ошибка ввода номера дня недели");
}