//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if (number >= 100 && number < 1000)
{
    int num = number % 100 / 10;
    Console.WriteLine($"{number} -> {num}");
}

else 
{
    Console.WriteLine("Число не является трехзначным!");
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
/*
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int number;
if (num >= 100 && num < 100000)
{
    if (num < 1000 && num >= 100)
    {
        number = num % 10;
        Console.WriteLine($"{num} -> {number}");
    } 
    else if (num < 10000 && num >= 1000)
    {
        number = num % 100 / 10;
        Console.WriteLine($"{num} -> {number}");
    }
    else if (num < 100000 && num >= 10000)
    {
        number = num % 1000 / 100;
        Console.WriteLine($"{num} -> {number}");
    }
}
Console.WriteLine($"{num} Не имеет третью цифру!");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*
Console.WriteLine("Введите день недели (В Цифрах от 1 до 7)");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num <=7)
{
    if (num >= 6 && num <= 7)
    {
        Console.WriteLine($"{num} Выходной день! ОуЕЕЕ");
    }
    else if (num < 6)
    {
        Console.WriteLine($"{num} Не время отдыхать! За работу! :(");
    }
}
else
{
    Console.WriteLine($"{num} Ты чего-то перепутал, не? =)");
}
*/