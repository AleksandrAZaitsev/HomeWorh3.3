System.Console.Write("Введи х: ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Мы находимся в первой четверти");
}

else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Мы находимся во второй четверти");
}

else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Мы находимся в третьей четверти");
}

else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Мы находимся во четвертой четверти");
}

else
{
    System.Console.WriteLine("в центре");
}

