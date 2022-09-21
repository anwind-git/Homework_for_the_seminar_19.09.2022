// Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет

void Metod2()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string number_three = Convert.ToString(number);

    if (number_three.Length > 2)
    {
        int number_three2 = Convert.ToInt32(number_three.Substring(0,3));
        Console.WriteLine("третья цифра числа: " + number_three2 % 10 % 10);  
    }
    else 
    {
       Console.WriteLine("Третьей цыфры нет");
    }
}

Metod2();

void Metod1()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    string number_three = Convert.ToString(number);
    if (number_three.Length > 2)
    {
       Console.WriteLine("третья цифра числа: " + number_three[2]);
    }
    else 
    {
       Console.WriteLine("Третьей цыфры нет");
    }
}

Metod1();