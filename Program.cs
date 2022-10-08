//_______________1 Задача________________
Console.WriteLine("_______________1 Задача________________");
int numberA = new Random().Next(100, 1000);
int num1 = numberA / 10;
int res = num1 % 10;

Console.WriteLine(numberA);
Console.WriteLine($"{res}");

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//_______________2 Задача________________

Console.WriteLine("_______________2 Задача________________");
int number = new Random().Next(100000);
if (number < 100)
{
    Console.WriteLine("Ваше число меньше 100. Попробуйте заново.");
    return;
}
int thirdnumber = 0;
if (number > 99 && number < 1000)
{
    thirdnumber = (number % 100) % 10;
} 
if (number > 999 && number < 10000)
{
    thirdnumber = (number % 100) / 10;
}
if ( number > 9999 && number < 100000)
{
    thirdnumber = (number % 1000) / 100;
}
Console.WriteLine($"{number} -> {thirdnumber}");


//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++===
//_______________3 Задача________________
Console.WriteLine("_______________3 Задача________________");
Console.WriteLine("Введите цифру, обозначающую день недели:");
int day = int.Parse(Console.ReadLine()!);

if (day > 0 && day < 8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine($"Выходной день");
    }
    else
    {
        Console.WriteLine($"Будни");
    }
}
else
{
    Console.WriteLine($"В неделе 7 дней,умник.");
}


