System.Console.Write("Введите номер четверти ");
int number = Convert.ToInt32(Console.ReadLine());
string[] strArray = {"x > 0 && y > 0", "x < 0 && y > 0", "x < 0 && y < 0","x > 0 && y < 0", "Такой четверти нет"};

if(number > 0 && number < 5)
{
  System.Console.WriteLine(strArray[number-1]);
}
else
{
  System.Console.WriteLine("Такой четверти не существует");
}
