// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число");
string str = Convert.ToString(Console.ReadLine());

char[] arr = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    arr[i] = str[i];
}   

if (arr[0] == arr[4] && arr[1] == arr[3])
{
    System.Console.Write("Значение является палиндромным"); 
}

else
{
    System.Console.Write("Значение НЕ является палиндромным"); 
}
