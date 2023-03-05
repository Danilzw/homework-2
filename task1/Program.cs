//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.\

System.Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine());

if(number < 100 ^ number > 999)
{
    System.Console.WriteLine("Ваше число не трехзначное!");
}
else
{
    number = number / 10 % 10;
    System.Console.WriteLine(number);
}

