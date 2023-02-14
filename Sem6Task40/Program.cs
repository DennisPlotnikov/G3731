// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

int ReadData(string msg)

{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


int a = ReadData("Введите первое число: ");
int b = ReadData("Введите второе число: ");
int c = ReadData("Введите третье число: ");

if ((a < b + c) && (b < a + c) && (c < a + b))
{
    Console.WriteLine("Треугольник построить можно");
}
else
{
    Console.WriteLine("Треугольник построить нельзя");
}