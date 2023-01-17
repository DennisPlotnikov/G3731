// Задача №7
// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

string? imputNumber = Console.ReadLine();

if (imputNumber != null)
{
    int number = int.Parse(imputNumber);

    int lastDigit = number % 10;

    Console.WriteLine(lastDigit);
}