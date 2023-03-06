System.Console.WriteLine("Число:");
int number = int.Parse(Console.ReadLine());

if(number < 1 ^ number > 7)
{
    System.Console.WriteLine("Нет такого дня недели");
}

switch(number)
{
    case 1:
    System.Console.WriteLine("Понедельник");
    break;
    case 2:
    System.Console.WriteLine("Вторник");
    break;
    case 3:
    System.Console.WriteLine("Среда");
    break;
}

if(number == 3 && number == 2)
{
    System.Console.WriteLine(" - Это выходной");
}