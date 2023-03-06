//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string [] days = new string[7] {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота - Выходной", "Воскресенье - Выходной"};

System.Console.Write("Введите число:");
int ourday = int.Parse(Console.ReadLine());

if(ourday < 1 ^ ourday > 7)
{
    System.Console.WriteLine("Нет такого дня недели");
}
else
{
    System.Console.WriteLine(days[ourday - 1]);
}




