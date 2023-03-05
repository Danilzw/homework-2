// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

System.Console.Write("Введите число:");
string number = Console.ReadLine();

if(int.Parse(number) < 100)
{
    System.Console.WriteLine("Нет третьего числа");
}
else
{
    System.Console.WriteLine(number[2]);
}
