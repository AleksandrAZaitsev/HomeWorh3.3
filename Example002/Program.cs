// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти от 1 до 4: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("X > 0 and Y > 0");
}

else if (number == 2)
{
    System.Console.WriteLine("X > 0 and Y < 0");
}

else if (number == 3)
{
    System.Console.WriteLine("X < 0 and Y < 0");
}

else if (number == 4)
{
    System.Console.WriteLine("X < 0 and Y > 0");
}

else
{
    System.Console.WriteLine("Не допустимая четверть");
}